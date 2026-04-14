Public Class frm_Manutencao
    Dim editando As Boolean = False
    Dim id_os_selecionada As Integer

    Private Sub frm_Manutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If db.State = 0 Then Conectar_Banco()

            ' Busca as máquinas cadastradas e preenche o ComboBox
            cmb_maquina.Items.Clear()
            Dim rs As New ADODB.Recordset
            sql = "SELECT tag_maquina FROM tb_maquinas ORDER BY tag_maquina"
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            Do While Not rs.EOF
                cmb_maquina.Items.Add(rs.Fields(0).Value.ToString())
                rs.MoveNext()
            Loop
            rs.Close()

            Carregar_OS()
        Catch ex As Exception
            MsgBox("Erro ao carregar tela de manutenção: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub frm_Manutencao_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If db.State = 0 Then Conectar_Banco()
            Carregar_OS()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_salvar_os_Click(sender As Object, e As EventArgs) Handles btn_salvar_os.Click
        Try
            If db.State = 0 Then Conectar_Banco()

            ' Formata a data para o padrão aceito pelo SQL (Ano-Mês-Dia)
            Dim data_formatada As String = dtp_data.Value.ToString("yyyy-MM-dd")

            ' Validações para garantir que os campos não fiquem em branco
            If cmb_maquina.Text.Trim = "" Then
                MsgBox("Selecione a TAG da máquina.", MsgBoxStyle.Exclamation, "Atenção")
                cmb_maquina.Focus()
                Exit Sub
            End If

            If txt_descricao.Text.Trim = "" Then
                MsgBox("Informe a descrição do serviço.", MsgBoxStyle.Exclamation, "Atenção")
                txt_descricao.Focus()
                Exit Sub
            End If

            ' Define se é um novo registro ou atualização de um existente
            If editando = False Then
                sql = "INSERT INTO tb_manutencao (tag_maquina, data_abertura, descricao, status_os) " &
                      "VALUES ('" & cmb_maquina.Text & "', '" & data_formatada & "', '" & txt_descricao.Text & "', 'Pendente')"
            Else
                sql = "UPDATE tb_manutencao SET " &
                      "tag_maquina = '" & cmb_maquina.Text & "', data_abertura = '" & data_formatada & "', " &
                      "descricao = '" & txt_descricao.Text & "' " &
                      "WHERE id_os = " & id_os_selecionada
            End If

            ' Executa o SQL e guarda quantas linhas foram afetadas no banco
            Dim linhasAfetadas As Object = 0
            db.Execute(sql, linhasAfetadas)

            ' Se afetou pelo menos 1 linha, significa que o banco salvou com sucesso
            If CInt(linhasAfetadas) > 0 Then
                If editando = False Then
                    MsgBox("Ordem de Serviço lançada com sucesso!", MsgBoxStyle.Information, "Sucesso")
                Else
                    MsgBox("Ordem de Serviço atualizada com sucesso!", MsgBoxStyle.Information, "Sucesso")
                End If

                editando = False
                Limpar_Campos_OS()
                Carregar_OS()
            Else
                ' Se afetou 0 linhas, o banco recusou a instrução por causa de alguma restrição
                MsgBox("Erro: O banco de dados recusou o salvamento da O.S.", MsgBoxStyle.Critical, "Aviso")
            End If

        Catch ex As Exception
            MsgBox("Erro ao salvar a O.S.: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Sub Carregar_OS()
        Try
            If db.State = 0 Then Conectar_Banco()
            Dim rs As New ADODB.Recordset

            sql = "SELECT id_os AS [Nº O.S.], tag_maquina AS [TAG da Máquina], data_abertura AS [Data de Abertura], status_os AS [Status] FROM tb_manutencao ORDER BY id_os DESC"
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            ' Passa os dados do Recordset (ADODB) para um DataTable do .NET
            Dim da As New System.Data.OleDb.OleDbDataAdapter()
            Dim dt As New DataTable
            da.Fill(dt, rs)

            ' Limpa o grid completamente antes de preencher para forçar a atualização visual
            dgv_os.DataSource = Nothing
            dgv_os.Columns.Clear()
            dgv_os.DataSource = dt

            ' Garante que a coluna de data seja exibida no padrão brasileiro
            If dgv_os.Columns.Contains("Data de Abertura") Then
                dgv_os.Columns("Data de Abertura").DefaultCellStyle.Format = "dd/MM/yyyy"
            End If

            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao carregar O.S.: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_os_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_os.CellContentClick
        Try
            If e.RowIndex < 0 Then Exit Sub

            ' Pega o ID da O.S. com base na linha que o usuário clicou
            id_os_selecionada = CInt(dgv_os.Rows(e.RowIndex).Cells(0).Value)

            Dim rs_edit As New ADODB.Recordset
            sql = "SELECT * FROM tb_manutencao WHERE id_os = " & id_os_selecionada
            rs_edit.Open(sql, db)

            ' Carrega os dados do banco de volta para os campos da tela
            If Not rs_edit.EOF Then
                cmb_maquina.Text = rs_edit.Fields("tag_maquina").Value.ToString()
                dtp_data.Value = rs_edit.Fields("data_abertura").Value
                txt_descricao.Text = rs_edit.Fields("descricao").Value.ToString()

                editando = True
            End If
            rs_edit.Close()

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form_1.Show()
        Me.Hide()
    End Sub

    Sub Limpar_Campos_OS()
        txt_descricao.Clear()
        cmb_maquina.SelectedIndex = -1
        dtp_data.Value = Today
        editando = False
        id_os_selecionada = 0
    End Sub

    Private Sub dtp_data_ValueChanged(sender As Object, e As EventArgs) Handles dtp_data.ValueChanged

    End Sub

    Private Sub btn_ir_finalizacao_Click(sender As Object, e As EventArgs) Handles btn_ir_finalizacao.Click
        frm_Finalizacao_Manutencao.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class