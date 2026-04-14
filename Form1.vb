Public Class Form_1
    Dim editando As Boolean = False

    Private Sub Form_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Tenta conectar e carregar a lista ao abrir a tela
            If db.State = 0 Then Conectar_Banco()
            Carregar_Maquinas()
        Catch ex As Exception
            MsgBox("Erro ao iniciar tela: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If db.State = 0 Then Conectar_Banco()

            Dim data_formatada As String = dtp_aquisicao.Value.ToString("yyyy-MM-dd")
            Dim caminhoFotoParaSalvar As String = ""

            ' Verifica se os campos básicos foram preenchidos
            If txt_tag.Text.Trim = "" Or txt_nome.Text.Trim = "" Then
                MsgBox("Preencha a TAG e o Nome da máquina.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Decide se vai inserir novo ou atualizar existente
            If editando = False Then
                ' --- CADASTRO NOVO ---
                ' Primeiro verifica se a TAG já existe pra não dar erro no banco
                Dim rs_verifica As New ADODB.Recordset
                sql = "SELECT tag_maquina FROM tb_maquinas WHERE tag_maquina = '" & txt_tag.Text.Trim() & "'"
                rs_verifica.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

                If Not rs_verifica.EOF Then
                    MsgBox("A TAG informada já existe no sistema.", MsgBoxStyle.Exclamation)
                    rs_verifica.Close()
                    Exit Sub
                End If
                rs_verifica.Close()

                caminhoFotoParaSalvar = dlg_foto.FileName

                sql = "INSERT INTO tb_maquinas (tag_maquina, nome_maquina, setor, fabricante, modelo, data_aquisicao, observacoes, status_maquina, caminho_foto) " &
                      "VALUES ('" & txt_tag.Text & "', '" & txt_nome.Text & "', '" & txt_setor.Text & "', '" & txt_fabricante.Text & "', '" & txt_modelo.Text & "', '" & data_formatada & "', '" & txt_observacoes.Text & "', 'Ativa', '" & caminhoFotoParaSalvar & "')"
            Else
                ' --- ATUALIZAR EXISTENTE ---
                ' Se escolheu foto nova usa ela, senão mantém a que já estava carregada
                If dlg_foto.FileName <> "" Then
                    caminhoFotoParaSalvar = dlg_foto.FileName
                Else
                    caminhoFotoParaSalvar = img_maquina.ImageLocation
                End If

                sql = "UPDATE tb_maquinas SET " &
                      "nome_maquina = '" & txt_nome.Text & "', " &
                      "setor = '" & txt_setor.Text & "', " &
                      "fabricante = '" & txt_fabricante.Text & "', " &
                      "modelo = '" & txt_modelo.Text & "', " &
                      "data_aquisicao = '" & data_formatada & "', " &
                      "observacoes = '" & txt_observacoes.Text & "', " &
                      "caminho_foto = '" & caminhoFotoParaSalvar & "' " &
                      "WHERE tag_maquina = '" & txt_tag.Text & "'"
            End If

            ' Executa o comando e verifica se o banco aceitou
            Dim linhasAfetadas As Object = 0
            db.Execute(sql, linhasAfetadas)

            If CInt(linhasAfetadas) > 0 Then
                MsgBox("Dados processados com sucesso!", MsgBoxStyle.Information)

                ' Reseta a tela para o modo padrão
                editando = False
                txt_tag.Enabled = True
                Limpar_Campos()
                Carregar_Maquinas()
            Else
                MsgBox("O banco não realizou a alteração. Verifique os dados.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Erro ao salvar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub Carregar_Maquinas()
        Try
            If db.State = 0 Then Conectar_Banco()
            Dim rs As New ADODB.Recordset

            ' Puxa os dados das máquinas pro grid
            sql = "SELECT tag_maquina AS [TAG], nome_maquina AS [Equipamento], setor AS [Local], fabricante AS [Fabricante], modelo AS [Modelo], data_aquisicao AS [Aquisição] FROM tb_maquinas ORDER BY tag_maquina"
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            Dim da As New System.Data.OleDb.OleDbDataAdapter()
            Dim dt As New DataTable
            da.Fill(dt, rs)

            ' Atualiza o grid e cria os botões de ação
            dgv_maquinas.Columns.Clear()
            dgv_maquinas.DataSource = dt

            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = "EDITAR" : btnEdit.Name = "btnEditar" : btnEdit.Text = "EDITAR" : btnEdit.UseColumnTextForButtonValue = True
            dgv_maquinas.Columns.Add(btnEdit)

            Dim btnDel As New DataGridViewButtonColumn()
            btnDel.HeaderText = "EXCLUIR" : btnDel.Name = "btnExcluir" : btnDel.Text = "EXCLUIR" : btnDel.UseColumnTextForButtonValue = True
            dgv_maquinas.Columns.Add(btnDel)

            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao listar máquinas: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_maquinas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_maquinas.CellContentClick
        Try
            ' Verifica se clicou em uma linha válida
            If e.RowIndex < 0 Then Exit Sub

            Dim tag_selecionada As String = dgv_maquinas.Rows(e.RowIndex).Cells(0).Value.ToString()

            ' Coluna 6 é o botão de Editar
            If e.ColumnIndex = 6 Then
                If db.State = 0 Then Conectar_Banco()
                Dim rs_edit As New ADODB.Recordset
                sql = "SELECT * FROM tb_maquinas WHERE tag_maquina = '" & tag_selecionada & "'"
                rs_edit.Open(sql, db)

                If Not rs_edit.EOF Then
                    ' Carrega as informações nos campos da tela
                    txt_tag.Text = rs_edit.Fields("tag_maquina").Value.ToString()
                    txt_nome.Text = rs_edit.Fields("nome_maquina").Value.ToString()
                    txt_setor.Text = rs_edit.Fields("setor").Value.ToString()
                    txt_fabricante.Text = rs_edit.Fields("fabricante").Value.ToString()
                    txt_modelo.Text = rs_edit.Fields("modelo").Value.ToString()
                    dtp_aquisicao.Value = rs_edit.Fields("data_aquisicao").Value
                    txt_observacoes.Text = rs_edit.Fields("observacoes").Value.ToString()
                    img_maquina.ImageLocation = rs_edit.Fields("caminho_foto").Value.ToString()

                    ' Ativa o modo de edição e trava a TAG (que é a chave do banco)
                    editando = True
                    txt_tag.Enabled = False
                End If
                rs_edit.Close()

                ' Coluna 7 é o botão de Excluir
            ElseIf e.ColumnIndex = 7 Then
                Dim resp As MsgBoxResult = MsgBox("Deseja realmente excluir a máquina " & tag_selecionada & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir")
                If resp = MsgBoxResult.Yes Then
                    db.Execute("DELETE FROM tb_maquinas WHERE tag_maquina = '" & tag_selecionada & "'")
                    Carregar_Maquinas()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro na ação do grid: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_foto_Click(sender As Object, e As EventArgs) Handles btn_foto.Click
        ' Configura o diálogo para buscar apenas imagens
        dlg_foto.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png"
        dlg_foto.FileName = ""
        If dlg_foto.ShowDialog() = DialogResult.OK Then
            img_maquina.ImageLocation = dlg_foto.FileName
            img_maquina.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            ' Filtro de busca em tempo real por TAG ou Nome
            If db.State = 0 Then Conectar_Banco()
            Dim rs As New ADODB.Recordset
            sql = "SELECT tag_maquina AS [TAG], nome_maquina AS [Equipamento], setor AS [Local], fabricante AS [Fabricante], modelo AS [Modelo], data_aquisicao AS [Aquisição] " &
                  "FROM tb_maquinas WHERE tag_maquina LIKE '%" & txt_busca.Text & "%' OR nome_maquina LIKE '%" & txt_busca.Text & "%' ORDER BY tag_maquina"

            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            Dim da As New System.Data.OleDb.OleDbDataAdapter()
            Dim dt As New DataTable
            da.Fill(dt, rs)
            dgv_maquinas.DataSource = dt
            rs.Close()
        Catch ex As Exception
        End Try
    End Sub

    Sub Limpar_Campos()
        txt_tag.Clear()
        txt_nome.Clear()
        txt_setor.Clear()
        txt_fabricante.Clear()
        txt_modelo.Clear()
        txt_observacoes.Clear()
        dtp_aquisicao.Value = Today
        dlg_foto.FileName = ""
        img_maquina.Image = Nothing
        img_maquina.ImageLocation = Nothing
        txt_tag.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Vai para a tela de Ordens de Serviço
        frm_Manutencao.Show()
    End Sub

End Class