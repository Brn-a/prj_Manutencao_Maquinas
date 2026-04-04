Public Class Form_1
    Dim editando As Boolean = False

    Private Sub Form_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If db.State = 0 Then Conectar_Banco()
        Carregar_Maquinas()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If db.State = 0 Then Conectar_Banco()

            Dim data_formatada As String = dtp_aquisicao.Value.ToString("yyyy-MM-dd")
            Dim caminhoFotoParaSalvar As String = ""

            If editando = False Then
                ' Salva máquina nova
                caminhoFotoParaSalvar = dlg_foto.FileName

                sql = "INSERT INTO tb_maquinas (tag_maquina, nome_maquina, setor, fabricante, modelo, data_aquisicao, observacoes, status_maquina, caminho_foto) " &
                      "VALUES ('" & txt_tag.Text & "', '" & txt_nome.Text & "', '" & txt_setor.Text & "', '" & txt_fabricante.Text & "', '" & txt_modelo.Text & "', '" & data_formatada & "', '" & txt_observacoes.Text & "', 'Ativa', '" & caminhoFotoParaSalvar & "')"
                db.Execute(sql)
                MsgBox("Equipamento " & txt_nome.Text & " salvo com sucesso!", MsgBoxStyle.Information, "Sucesso")
            Else
                ' Atualiza os dados da máquina que já existe
                If Not String.IsNullOrEmpty(dlg_foto.FileName) AndAlso dlg_foto.FileName <> img_maquina.ImageLocation Then
                    caminhoFotoParaSalvar = dlg_foto.FileName
                Else
                    caminhoFotoParaSalvar = img_maquina.ImageLocation
                End If

                sql = "UPDATE tb_maquinas SET " &
                      "nome_maquina = '" & txt_nome.Text & "', setor = '" & txt_setor.Text & "', fabricante = '" & txt_fabricante.Text & "', " &
                      "modelo = '" & txt_modelo.Text & "', data_aquisicao = '" & data_formatada & "', observacoes = '" & txt_observacoes.Text & "', " &
                      "caminho_foto = '" & caminhoFotoParaSalvar & "' WHERE tag_maquina = '" & txt_tag.Text & "'"
                db.Execute(sql)
                MsgBox("Equipamento " & txt_nome.Text & " atualizado com sucesso!", MsgBoxStyle.Information, "Sucesso")
            End If

            editando = False
            txt_tag.Enabled = True
            Limpar_Campos()
            Carregar_Maquinas()
            dlg_foto.FileName = ""

        Catch ex As Exception
            MsgBox("Erro ao processar no banco: " & ex.Message, MsgBoxStyle.Critical, "Erro")
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

            dgv_maquinas.Columns.Clear()
            dgv_maquinas.DataSource = dt

            ' Cria os botões de Editar e Excluir no Grid
            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = "EDITAR" : btnEdit.Name = "btnEditar" : btnEdit.Text = "EDITAR" : btnEdit.UseColumnTextForButtonValue = True
            dgv_maquinas.Columns.Add(btnEdit)

            Dim btnDel As New DataGridViewButtonColumn()
            btnDel.HeaderText = "EXCLUIR" : btnDel.Name = "btnExcluir" : btnDel.Text = "EXCLUIR" : btnDel.UseColumnTextForButtonValue = True
            dgv_maquinas.Columns.Add(btnDel)

            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao carregar máquinas: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_maquinas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_maquinas.CellContentClick
        Try
            If e.RowIndex < 0 Then Exit Sub

            Dim tag_selecionada As String = dgv_maquinas.Rows(e.RowIndex).Cells(0).Value.ToString()

            If e.ColumnIndex = 6 Then ' Botão Editar
                If db.State = 0 Then Conectar_Banco()
                Dim rs_edit As New ADODB.Recordset
                sql = "SELECT * FROM tb_maquinas WHERE tag_maquina = '" & tag_selecionada & "'"
                rs_edit.Open(sql, db)

                If Not rs_edit.EOF Then
                    dlg_foto.FileName = ""
                    txt_tag.Text = rs_edit.Fields("tag_maquina").Value.ToString()
                    txt_nome.Text = rs_edit.Fields("nome_maquina").Value.ToString()
                    txt_setor.Text = rs_edit.Fields("setor").Value.ToString()
                    txt_fabricante.Text = rs_edit.Fields("fabricante").Value.ToString()
                    txt_modelo.Text = rs_edit.Fields("modelo").Value.ToString()
                    dtp_aquisicao.Value = rs_edit.Fields("data_aquisicao").Value
                    txt_observacoes.Text = rs_edit.Fields("observacoes").Value.ToString()
                    img_maquina.ImageLocation = rs_edit.Fields("caminho_foto").Value.ToString()

                    editando = True
                    txt_tag.Enabled = False
                End If
                rs_edit.Close()

            ElseIf e.ColumnIndex = 7 Then ' Botão Excluir
                Dim resp As MsgBoxResult = MsgBox("Deseja realmente excluir a máquina " & tag_selecionada & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmação")
                If resp = MsgBoxResult.Yes Then
                    db.Execute("DELETE FROM tb_maquinas WHERE tag_maquina = '" & tag_selecionada & "'")
                    Carregar_Maquinas()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_foto_Click(sender As Object, e As EventArgs) Handles btn_foto.Click
        dlg_foto.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png"
        dlg_foto.FileName = ""
        If dlg_foto.ShowDialog() = DialogResult.OK Then
            img_maquina.ImageLocation = dlg_foto.FileName
            img_maquina.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            ' Filtra o grid enquanto digita na busca
            If db.State = 0 Then Conectar_Banco()
            Dim rs As New ADODB.Recordset
            sql = "SELECT tag_maquina AS [TAG], nome_maquina AS [Equipamento], setor AS [Local], fabricante AS [Fabricante], modelo AS [Modelo], data_aquisicao AS [Aquisição] FROM tb_maquinas WHERE tag_maquina LIKE '%" & txt_busca.Text & "%' OR nome_maquina LIKE '%" & txt_busca.Text & "%' ORDER BY tag_maquina"
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            Dim da As New System.Data.OleDb.OleDbDataAdapter() : Dim dt As New DataTable : da.Fill(dt, rs)
            dgv_maquinas.DataSource = dt : rs.Close()
        Catch ex As Exception
        End Try
    End Sub

    Sub Limpar_Campos()
        txt_tag.Clear() : txt_nome.Clear() : txt_setor.Clear() : txt_fabricante.Clear()
        txt_modelo.Clear() : txt_observacoes.Clear() : dtp_aquisicao.Value = Today
        txt_tag.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frm_Manutencao.Show()
    End Sub
End Class