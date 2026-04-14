Public Class frm_Finalizacao_Manutencao
    Dim editando As Boolean = False
    Dim id_os_selecionada As Integer = 0

    Private Sub frm_Finalizacao_Manutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If db.State = 0 Then Conectar_Banco()

            txt_descricao.ReadOnly = True
            Carregar_Tags()
            Carregar_OS_Finalizacao()

        Catch ex As Exception
            MsgBox("Erro ao carregar a tela de finalização: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub frm_Finalizacao_Manutencao_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If db.State = 0 Then Conectar_Banco()
            Carregar_OS_Finalizacao()
        Catch ex As Exception
        End Try
    End Sub

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
            MsgBox("Erro ao carregar TAGs: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Sub Carregar_OS_Finalizacao()
        Try
            If db.State = 0 Then Conectar_Banco()

            Dim rs As New ADODB.Recordset

            sql = "SELECT id_os AS [Nº O.S.], " &
                  "tag_maquina AS [TAG da Máquina], " &
                  "data_abertura AS [Data de Abertura], " &
                  "status_os AS [Status], " &
                  "tecnico AS [Técnico Responsável], " &
                  "hora_inicio AS [Hora Início], " &
                  "hora_fim AS [Hora Fim], " &
                  "tipo_manutencao AS [Preventiva/Corretiva], " &
                  "pecas AS [Peça Utilizada] " &
                  "FROM tb_manutencao ORDER BY id_os DESC"

            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            Dim da As New System.Data.OleDb.OleDbDataAdapter()
            Dim dt As New DataTable
            da.Fill(dt, rs)

            dgv_os.Columns.Clear()
            dgv_os.DataSource = dt

            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = "EDITAR"
            btnEdit.Name = "btnEditar"
            btnEdit.Text = "EDITAR"
            btnEdit.UseColumnTextForButtonValue = True
            dgv_os.Columns.Add(btnEdit)

            Dim btnDel As New DataGridViewButtonColumn()
            btnDel.HeaderText = "EXCLUIR"
            btnDel.Name = "btnExcluir"
            btnDel.Text = "EXCLUIR"
            btnDel.UseColumnTextForButtonValue = True
            dgv_os.Columns.Add(btnDel)

            rs.Close()

        Catch ex As Exception
            MsgBox("Erro ao carregar O.S. para finalização: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub dgv_os_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_os.CellContentClick
        Try
            If e.RowIndex < 0 Then Exit Sub

            id_os_selecionada = CInt(dgv_os.Rows(e.RowIndex).Cells(0).Value)

            If e.ColumnIndex = 9 Then ' Botão Editar
                Dim rs_edit As New ADODB.Recordset
                sql = "SELECT * FROM tb_manutencao WHERE id_os = " & id_os_selecionada
                rs_edit.Open(sql, db)

                If Not rs_edit.EOF Then
                    txt_tag_maquina.Text = rs_edit.Fields("tag_maquina").Value.ToString()

                    If Not IsDBNull(rs_edit.Fields("tecnico").Value) Then
                        txt_tecnico.Text = rs_edit.Fields("tecnico").Value.ToString()
                    Else
                        txt_tecnico.Clear()
                    End If

                    If Not IsDBNull(rs_edit.Fields("data_fechamento").Value) Then
                        dtp_data_finalizacao.Value = CDate(rs_edit.Fields("data_fechamento").Value)
                    Else
                        dtp_data_finalizacao.Value = Today
                    End If

                    If Not IsDBNull(rs_edit.Fields("hora_inicio").Value) Then
                        msk_hora_inicio.Text = rs_edit.Fields("hora_inicio").Value.ToString()
                    Else
                        msk_hora_inicio.Clear()
                    End If

                    If Not IsDBNull(rs_edit.Fields("hora_fim").Value) Then
                        msk_hora_fim.Text = rs_edit.Fields("hora_fim").Value.ToString()
                    Else
                        msk_hora_fim.Clear()
                    End If

                    If Not IsDBNull(rs_edit.Fields("descricao").Value) Then
                        txt_descricao.Text = rs_edit.Fields("descricao").Value.ToString()
                    Else
                        txt_descricao.Clear()
                    End If

                    If Not IsDBNull(rs_edit.Fields("pecas").Value) Then
                        txt_pecas.Text = rs_edit.Fields("pecas").Value.ToString()
                    Else
                        txt_pecas.Clear()
                    End If

                    If Not IsDBNull(rs_edit.Fields("tipo_manutencao").Value) Then
                        If rs_edit.Fields("tipo_manutencao").Value.ToString() = "Preventiva" Then
                            rdb_preventiva.Checked = True
                            rdb_corretiva.Checked = False
                        ElseIf rs_edit.Fields("tipo_manutencao").Value.ToString() = "Corretiva" Then
                            rdb_corretiva.Checked = True
                            rdb_preventiva.Checked = False
                        Else
                            rdb_preventiva.Checked = False
                            rdb_corretiva.Checked = False
                        End If
                    Else
                        rdb_preventiva.Checked = False
                        rdb_corretiva.Checked = False
                    End If

                    editando = True
                End If

                rs_edit.Close()

            ElseIf e.ColumnIndex = 10 Then ' Botão Excluir
                Dim resp As MsgBoxResult = MsgBox("Deseja excluir a O.S. Nº " & id_os_selecionada & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir")
                If resp = MsgBoxResult.Yes Then
                    db.Execute("DELETE FROM tb_manutencao WHERE id_os = " & id_os_selecionada)
                    Limpar_Campos_Finalizacao()
                    Carregar_OS_Finalizacao()
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao selecionar O.S.: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        frm_Manutencao.Show()
        Me.Hide()
    End Sub

    Private Sub btn_finalizar_os_Click(sender As Object, e As EventArgs) Handles btn_finalizar_os.Click
        Try
            If db.State = 0 Then Conectar_Banco()

            If id_os_selecionada = 0 Then
                MsgBox("Selecione uma O.S. no grid e clique em EDITAR antes de finalizar.", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

            If txt_tecnico.Text.Trim = "" Then
                MsgBox("Informe o técnico responsável.", MsgBoxStyle.Exclamation, "Atenção")
                txt_tecnico.Focus()
                Exit Sub
            End If

            If rdb_preventiva.Checked = False And rdb_corretiva.Checked = False Then
                MsgBox("Selecione Preventiva ou Corretiva.", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

            Dim tipo_os As String = If(rdb_preventiva.Checked, "Preventiva", "Corretiva")
            Dim data_finalizacao As String = dtp_data_finalizacao.Value.ToString("yyyy-MM-dd")

            sql = "UPDATE tb_manutencao SET " &
                  "tecnico = '" & txt_tecnico.Text & "', " &
                  "data_fechamento = '" & data_finalizacao & "', " &
                  "hora_inicio = '" & msk_hora_inicio.Text & "', " &
                  "hora_fim = '" & msk_hora_fim.Text & "', " &
                  "tipo_manutencao = '" & tipo_os & "', " &
                  "pecas = '" & txt_pecas.Text & "', " &
                  "status_os = 'Finalizado' " &
                  "WHERE id_os = " & id_os_selecionada

            db.Execute(sql)

            MsgBox("O.S. finalizada com sucesso!", MsgBoxStyle.Information, "Sucesso")

            Limpar_Campos_Finalizacao()
            Carregar_OS_Finalizacao()

        Catch ex As Exception
            MsgBox("Erro ao finalizar a O.S.: " & ex.Message, MsgBoxStyle.Critical, "Erro")
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

End Class