Public Class frm_Finalizacao_Manutencao
    Dim editando As Boolean = False
    Dim id_os_selecionada As Integer = 0

    Private Sub frm_Finalizacao_Manutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If db.State = 0 Then Conectar_Banco()

            ' Garante que o campo de descrição comece liberado para escrita
            txt_descricao.ReadOnly = False

            Carregar_Tags()
            Carregar_OS_Finalizacao()

        Catch ex As Exception
            MsgBox("Erro ao carregar a tela de encerramento: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub frm_Finalizacao_Manutencao_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If db.State = 0 Then Conectar_Banco()
            Carregar_OS_Finalizacao()
        Catch ex As Exception
        End Try
    End Sub

    ' Preenche o combo com as máquinas cadastradas
    Sub Carregar_Tags()
        Try
            If db.State = 0 Then Conectar_Banco()
            txt_tag_maquina.Items.Clear()

            Dim rs As New ADODB.Recordset
            sql = "SELECT tag_maquina FROM tb_maquinas ORDER BY tag_maquina"
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            Do While Not rs.EOF
                txt_tag_maquina.Items.Add(rs.Fields("tag_maquina").Value.ToString())
                rs.MoveNext()
            Loop
            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao carregar máquinas: " & ex.Message)
        End Try
    End Sub

    ' Lista O.S. no DataGridView
    Sub Carregar_OS_Finalizacao()
        Try
            If db.State = 0 Then Conectar_Banco()
            Dim rs As New ADODB.Recordset

            sql = "SELECT id_os AS [Nº O.S.], tag_maquina AS [TAG], data_abertura AS [Abertura], " &
                  "data_fechamento AS [Fechamento], " &
                  "status_os AS [Status], tecnico AS [Técnico], hora_inicio AS [Início], " &
                  "hora_fim AS [Fim], tipo_manutencao AS [Tipo], pecas AS [Peças] " &
                  "FROM tb_manutencao ORDER BY id_os DESC"

            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            Dim da As New System.Data.OleDb.OleDbDataAdapter()
            Dim dt As New DataTable
            da.Fill(dt, rs)

            dgv_os.Columns.Clear()
            dgv_os.DataSource = dt

            If dgv_os.Columns.Contains("Abertura") Then
                dgv_os.Columns("Abertura").DefaultCellStyle.Format = "dd/MM/yyyy"
            End If

            If dgv_os.Columns.Contains("Fechamento") Then
                dgv_os.Columns("Fechamento").DefaultCellStyle.Format = "dd/MM/yyyy"
            End If

            Dim btnAtender As New DataGridViewButtonColumn()
            btnAtender.HeaderText = "ATENDER"
            btnAtender.Name = "btnAtender"
            btnAtender.Text = "ATENDER"
            btnAtender.UseColumnTextForButtonValue = True
            dgv_os.Columns.Add(btnAtender)

            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao listar O.S.: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_os_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_os.CellContentClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            id_os_selecionada = CInt(dgv_os.Rows(e.RowIndex).Cells(0).Value)

            If e.ColumnIndex = 10 Then
                Dim rs_edit As New ADODB.Recordset
                sql = "SELECT * FROM tb_manutencao WHERE id_os = " & id_os_selecionada
                rs_edit.Open(sql, db)

                If Not rs_edit.EOF Then
                    txt_tag_maquina.Text = rs_edit.Fields("tag_maquina").Value.ToString()
                    txt_tecnico.Text = rs_edit.Fields("tecnico").Value.ToString()
                    txt_pecas.Text = rs_edit.Fields("pecas").Value.ToString()
                    txt_descricao.Text = rs_edit.Fields("descricao").Value.ToString()
                    msk_hora_inicio.Text = rs_edit.Fields("hora_inicio").Value.ToString()
                    msk_hora_fim.Text = rs_edit.Fields("hora_fim").Value.ToString()

                    If IsDate(rs_edit.Fields("data_fechamento").Value) Then
                        dtp_data_finalizacao.Value = CDate(rs_edit.Fields("data_fechamento").Value)
                    Else
                        dtp_data_finalizacao.Value = Today
                    End If

                    Dim tipo As String = rs_edit.Fields("tipo_manutencao").Value.ToString()
                    rdb_preventiva.Checked = (tipo = "Preventiva")
                    rdb_corretiva.Checked = (tipo = "Corretiva")

                    editando = True
                End If
                rs_edit.Close()
            End If


        Catch ex As Exception
            MsgBox("Erro ao selecionar registro: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_finalizar_os_Click(sender As Object, e As EventArgs) Handles btn_finalizar_os.Click
        Try
            If db.State = 0 Then Conectar_Banco()

            ' VALIDAÇÕES DE SEGURANÇA
            If id_os_selecionada = 0 Then
                MsgBox("Selecione uma O.S. no grid e clique em ATENDER primeiro.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txt_tecnico.Text.Trim = "" Then
                MsgBox("Informe o técnico responsável.", MsgBoxStyle.Critical)
                txt_tecnico.Focus() : Exit Sub
            End If

            If txt_descricao.Text.Trim = "" Then
                MsgBox("Descreva o serviço realizado na ocorrência.", MsgBoxStyle.Critical)
                txt_descricao.Focus() : Exit Sub
            End If

            If msk_hora_inicio.Text = "  :  " Or msk_hora_fim.Text = "  :  " Then
                MsgBox("Informe os horários de início e fim.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If rdb_preventiva.Checked = False And rdb_corretiva.Checked = False Then
                MsgBox("Selecione se a manutenção foi Preventiva ou Corretiva.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim tipo_os As String = If(rdb_preventiva.Checked, "Preventiva", "Corretiva")
            Dim data_fin As String = dtp_data_finalizacao.Value.ToString("yyyy-MM-dd")

            ' Executa o UPDATE para encerrar a O.S.
            sql = "UPDATE tb_manutencao SET " &
                  "tecnico = '" & txt_tecnico.Text & "', " &
                  "data_fechamento = '" & data_fin & "', " &
                  "hora_inicio = '" & msk_hora_inicio.Text & "', " &
                  "hora_fim = '" & msk_hora_fim.Text & "', " &
                  "tipo_manutencao = '" & tipo_os & "', " &
                  "pecas = '" & txt_pecas.Text & "', " &
                  "descricao = '" & txt_descricao.Text & "', " &
                  "status_os = 'Finalizado' " &
                  "WHERE id_os = " & id_os_selecionada

            Dim afetadas As Object = 0
            db.Execute(sql, afetadas)

            If CInt(afetadas) > 0 Then
                MsgBox("O.S. finalizada com sucesso!", MsgBoxStyle.Information)
                Limpar_Campos_Finalizacao()
                Carregar_OS_Finalizacao()
            End If

        Catch ex As Exception
            MsgBox("Erro ao finalizar O.S.: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub Limpar_Campos_Finalizacao()
        txt_tag_maquina.SelectedIndex = -1
        txt_tecnico.Clear()
        dtp_data_finalizacao.Value = Today
        msk_hora_inicio.Clear()
        msk_hora_fim.Clear()
        rdb_preventiva.Checked = False
        rdb_corretiva.Checked = False
        txt_pecas.Clear()
        txt_descricao.Clear()
        editando = False
        id_os_selecionada = 0
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        frm_Manutencao.Show()
        Me.Hide()
    End Sub

End Class