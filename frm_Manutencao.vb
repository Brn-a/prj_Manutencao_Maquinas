Public Class frm_Manutencao
    Dim editando As Boolean = False
    Dim id_os_selecionada As Integer

    Private Sub frm_Manutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If db.State = 0 Then Conectar_Banco()

            ' Puxa as máquinas cadastradas pro combo
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
        End Try
    End Sub

    Private Sub btn_salvar_os_Click(sender As Object, e As EventArgs) Handles btn_salvar_os.Click
        Try
            If db.State = 0 Then Conectar_Banco()

            Dim tipo_os As String = If(rdb_preventiva.Checked, "Preventiva", "Corretiva")
            Dim data_formatada As String = dtp_data.Value.ToString("yyyy-MM-dd")

            If editando = False Then
                ' Salva uma OS nova
                sql = "INSERT INTO tb_manutencao (tag_maquina, tecnico, data_servico, hora_inicio, hora_fim, tipo_manutencao, descricao, pecas) " &
                      "VALUES ('" & cmb_maquina.Text & "', '" & txt_tecnico.Text & "', '" & data_formatada & "', '" & msk_hora_inicio.Text & "', '" & msk_hora_fim.Text & "', '" & tipo_os & "', '" & txt_descricao.Text & "', '" & txt_pecas.Text & "')"
                MsgBox("Ordem de Serviço salva com sucesso!", MsgBoxStyle.Information, "Sucesso")
            Else
                ' Atualiza a OS que já existe
                sql = "UPDATE tb_manutencao SET " &
                      "tag_maquina = '" & cmb_maquina.Text & "', tecnico = '" & txt_tecnico.Text & "', data_servico = '" & data_formatada & "', " &
                      "hora_inicio = '" & msk_hora_inicio.Text & "', hora_fim = '" & msk_hora_fim.Text & "', tipo_manutencao = '" & tipo_os & "', " &
                      "descricao = '" & txt_descricao.Text & "', pecas = '" & txt_pecas.Text & "' " &
                      "WHERE id_os = " & id_os_selecionada
                MsgBox("Ordem de Serviço atualizada com sucesso!", MsgBoxStyle.Information, "Sucesso")
            End If

            db.Execute(sql)

            editando = False
            Limpar_Campos_OS()
            Carregar_OS()

        Catch ex As Exception
            MsgBox("Erro ao salvar a O.S.: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Sub Carregar_OS()
        Try
            If db.State = 0 Then Conectar_Banco()
            Dim rs As New ADODB.Recordset

            sql = "SELECT id_os AS [Nº O.S.], tag_maquina AS [Máquina], tecnico AS [Técnico], data_servico AS [Data], tipo_manutencao AS [Tipo] FROM tb_manutencao ORDER BY id_os DESC"
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            Dim da As New System.Data.OleDb.OleDbDataAdapter()
            Dim dt As New DataTable
            da.Fill(dt, rs)

            dgv_os.Columns.Clear()
            dgv_os.DataSource = dt

            ' Cria os botões de ação no grid
            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = "EDITAR" : btnEdit.Name = "btnEditar" : btnEdit.Text = "EDITAR" : btnEdit.UseColumnTextForButtonValue = True
            dgv_os.Columns.Add(btnEdit)

            Dim btnDel As New DataGridViewButtonColumn()
            btnDel.HeaderText = "EXCLUIR" : btnDel.Name = "btnExcluir" : btnDel.Text = "EXCLUIR" : btnDel.UseColumnTextForButtonValue = True
            dgv_os.Columns.Add(btnDel)

            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao carregar O.S.: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_os_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_os.CellContentClick
        Try
            If e.RowIndex < 0 Then Exit Sub

            id_os_selecionada = CInt(dgv_os.Rows(e.RowIndex).Cells(0).Value)

            If e.ColumnIndex = 5 Then ' Botão Editar
                Dim rs_edit As New ADODB.Recordset
                sql = "SELECT * FROM tb_manutencao WHERE id_os = " & id_os_selecionada
                rs_edit.Open(sql, db)

                If Not rs_edit.EOF Then
                    ' Joga os dados pros campos pra poder editar
                    cmb_maquina.Text = rs_edit.Fields("tag_maquina").Value.ToString()
                    txt_tecnico.Text = rs_edit.Fields("tecnico").Value.ToString()
                    dtp_data.Value = rs_edit.Fields("data_servico").Value
                    msk_hora_inicio.Text = rs_edit.Fields("hora_inicio").Value.ToString()
                    msk_hora_fim.Text = rs_edit.Fields("hora_fim").Value.ToString()
                    txt_descricao.Text = rs_edit.Fields("descricao").Value.ToString()
                    txt_pecas.Text = rs_edit.Fields("pecas").Value.ToString()

                    If rs_edit.Fields("tipo_manutencao").Value.ToString() = "Preventiva" Then
                        rdb_preventiva.Checked = True
                    Else
                        rdb_corretiva.Checked = True
                    End If

                    editando = True
                End If
                rs_edit.Close()

            ElseIf e.ColumnIndex = 6 Then ' Botão Excluir
                Dim resp As MsgBoxResult = MsgBox("Deseja excluir a O.S. Nº " & id_os_selecionada & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Excluir")
                If resp = MsgBoxResult.Yes Then
                    db.Execute("DELETE FROM tb_manutencao WHERE id_os = " & id_os_selecionada)
                    Carregar_OS()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form_1.Show()
        Me.Hide()
    End Sub

    Sub Limpar_Campos_OS()
        txt_tecnico.Clear()
        msk_hora_inicio.Clear()
        msk_hora_fim.Clear()
        txt_descricao.Clear()
        txt_pecas.Clear()
        cmb_maquina.SelectedIndex = -1
        dtp_data.Value = Today
        rdb_preventiva.Checked = True
        editando = False
    End Sub
End Class