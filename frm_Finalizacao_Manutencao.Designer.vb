<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Finalizacao_Manutencao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_finalizar_os = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.pnl_topo = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_tag_maquina = New System.Windows.Forms.ComboBox()
        Me.lbl_tag = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_tecnico = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.msk_hora_fim = New System.Windows.Forms.MaskedTextBox()
        Me.msk_hora_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.rdb_corretiva = New System.Windows.Forms.RadioButton()
        Me.rdb_preventiva = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_pecas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.lbl_data_finalizacao = New System.Windows.Forms.Label()
        Me.dtp_data_finalizacao = New System.Windows.Forms.DateTimePicker()
        Me.dgv_os = New System.Windows.Forms.DataGridView()
        Me.pnl_topo.SuspendLayout()
        CType(Me.dgv_os, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_finalizar_os
        '
        Me.btn_finalizar_os.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_finalizar_os.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finalizar_os.Location = New System.Drawing.Point(281, 297)
        Me.btn_finalizar_os.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_finalizar_os.Name = "btn_finalizar_os"
        Me.btn_finalizar_os.Size = New System.Drawing.Size(104, 24)
        Me.btn_finalizar_os.TabIndex = 20
        Me.btn_finalizar_os.Text = "ENCERRAR  O.S."
        Me.btn_finalizar_os.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(398, 297)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(104, 24)
        Me.btn_voltar.TabIndex = 21
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'pnl_topo
        '
        Me.pnl_topo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnl_topo.Controls.Add(Me.Label10)
        Me.pnl_topo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_topo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_topo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_topo.Name = "pnl_topo"
        Me.pnl_topo.Size = New System.Drawing.Size(832, 48)
        Me.pnl_topo.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(253, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(316, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "ENCERRAMENTO DE ORDEM DE SERVIÇO"
        '
        'txt_tag_maquina
        '
        Me.txt_tag_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_tag_maquina.FormattingEnabled = True
        Me.txt_tag_maquina.Location = New System.Drawing.Point(20, 77)
        Me.txt_tag_maquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_tag_maquina.Name = "txt_tag_maquina"
        Me.txt_tag_maquina.Size = New System.Drawing.Size(163, 21)
        Me.txt_tag_maquina.TabIndex = 25
        '
        'lbl_tag
        '
        Me.lbl_tag.AutoSize = True
        Me.lbl_tag.Location = New System.Drawing.Point(17, 62)
        Me.lbl_tag.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tag.Name = "lbl_tag"
        Me.lbl_tag.Size = New System.Drawing.Size(100, 13)
        Me.lbl_tag.TabIndex = 24
        Me.lbl_tag.Text = "TAG DA MÁQUINA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "TÉCNICO RESPONSÁVEL"
        '
        'txt_tecnico
        '
        Me.txt_tecnico.Location = New System.Drawing.Point(304, 76)
        Me.txt_tecnico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_tecnico.Name = "txt_tecnico"
        Me.txt_tecnico.Size = New System.Drawing.Size(170, 20)
        Me.txt_tecnico.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(396, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "HORA FIM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "HORA INÍCIO"
        '
        'msk_hora_fim
        '
        Me.msk_hora_fim.Location = New System.Drawing.Point(398, 130)
        Me.msk_hora_fim.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.msk_hora_fim.Mask = "00:00"
        Me.msk_hora_fim.Name = "msk_hora_fim"
        Me.msk_hora_fim.Size = New System.Drawing.Size(38, 20)
        Me.msk_hora_fim.TabIndex = 29
        '
        'msk_hora_inicio
        '
        Me.msk_hora_inicio.Location = New System.Drawing.Point(304, 130)
        Me.msk_hora_inicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.msk_hora_inicio.Mask = "00:00"
        Me.msk_hora_inicio.Name = "msk_hora_inicio"
        Me.msk_hora_inicio.Size = New System.Drawing.Size(38, 20)
        Me.msk_hora_inicio.TabIndex = 28
        '
        'rdb_corretiva
        '
        Me.rdb_corretiva.AutoSize = True
        Me.rdb_corretiva.Location = New System.Drawing.Point(129, 112)
        Me.rdb_corretiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdb_corretiva.Name = "rdb_corretiva"
        Me.rdb_corretiva.Size = New System.Drawing.Size(87, 17)
        Me.rdb_corretiva.TabIndex = 33
        Me.rdb_corretiva.TabStop = True
        Me.rdb_corretiva.Text = "CORRETIVA"
        Me.rdb_corretiva.UseVisualStyleBackColor = True
        '
        'rdb_preventiva
        '
        Me.rdb_preventiva.AutoSize = True
        Me.rdb_preventiva.Location = New System.Drawing.Point(20, 112)
        Me.rdb_preventiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdb_preventiva.Name = "rdb_preventiva"
        Me.rdb_preventiva.Size = New System.Drawing.Size(93, 17)
        Me.rdb_preventiva.TabIndex = 32
        Me.rdb_preventiva.TabStop = True
        Me.rdb_preventiva.Text = "PREVENTIVA"
        Me.rdb_preventiva.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 161)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "PEÇA UTILIZADA"
        '
        'txt_pecas
        '
        Me.txt_pecas.Location = New System.Drawing.Point(20, 176)
        Me.txt_pecas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_pecas.Multiline = True
        Me.txt_pecas.Name = "txt_pecas"
        Me.txt_pecas.Size = New System.Drawing.Size(277, 53)
        Me.txt_pecas.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 161)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "DESCRIÇÃO DA OCORRÊNCIA"
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(304, 176)
        Me.txt_descricao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(277, 53)
        Me.txt_descricao.TabIndex = 37
        '
        'lbl_data_finalizacao
        '
        Me.lbl_data_finalizacao.AutoSize = True
        Me.lbl_data_finalizacao.Location = New System.Drawing.Point(494, 62)
        Me.lbl_data_finalizacao.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_data_finalizacao.Name = "lbl_data_finalizacao"
        Me.lbl_data_finalizacao.Size = New System.Drawing.Size(126, 13)
        Me.lbl_data_finalizacao.TabIndex = 39
        Me.lbl_data_finalizacao.Text = "DATA DA FINALIZAÇÃO"
        '
        'dtp_data_finalizacao
        '
        Me.dtp_data_finalizacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data_finalizacao.Location = New System.Drawing.Point(496, 77)
        Me.dtp_data_finalizacao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp_data_finalizacao.Name = "dtp_data_finalizacao"
        Me.dtp_data_finalizacao.Size = New System.Drawing.Size(122, 20)
        Me.dtp_data_finalizacao.TabIndex = 38
        '
        'dgv_os
        '
        Me.dgv_os.AllowUserToAddRows = False
        Me.dgv_os.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_os.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_os.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_os.BackgroundColor = System.Drawing.Color.White
        Me.dgv_os.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_os.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_os.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_os.EnableHeadersVisualStyles = False
        Me.dgv_os.Location = New System.Drawing.Point(0, 344)
        Me.dgv_os.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_os.Name = "dgv_os"
        Me.dgv_os.RowHeadersWidth = 51
        Me.dgv_os.Size = New System.Drawing.Size(832, 178)
        Me.dgv_os.TabIndex = 40
        '
        'frm_Finalizacao_Manutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 522)
        Me.Controls.Add(Me.dgv_os)
        Me.Controls.Add(Me.lbl_data_finalizacao)
        Me.Controls.Add(Me.dtp_data_finalizacao)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_pecas)
        Me.Controls.Add(Me.rdb_corretiva)
        Me.Controls.Add(Me.rdb_preventiva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.msk_hora_fim)
        Me.Controls.Add(Me.msk_hora_inicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_tecnico)
        Me.Controls.Add(Me.txt_tag_maquina)
        Me.Controls.Add(Me.lbl_tag)
        Me.Controls.Add(Me.pnl_topo)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_finalizar_os)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_Finalizacao_Manutencao"
        Me.Text = "frm_Finalizacao_Manutencao"
        Me.pnl_topo.ResumeLayout(False)
        Me.pnl_topo.PerformLayout()
        CType(Me.dgv_os, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_finalizar_os As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents pnl_topo As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_tag_maquina As ComboBox
    Friend WithEvents lbl_tag As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_tecnico As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents msk_hora_fim As MaskedTextBox
    Friend WithEvents msk_hora_inicio As MaskedTextBox
    Friend WithEvents rdb_corretiva As RadioButton
    Friend WithEvents rdb_preventiva As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_pecas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents lbl_data_finalizacao As Label
    Friend WithEvents dtp_data_finalizacao As DateTimePicker
    Friend WithEvents dgv_os As DataGridView
End Class