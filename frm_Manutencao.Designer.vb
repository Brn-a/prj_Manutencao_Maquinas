<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Manutencao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_tecnico = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_data = New System.Windows.Forms.DateTimePicker()
        Me.msk_hora_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.msk_hora_fim = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rdb_preventiva = New System.Windows.Forms.RadioButton()
        Me.rdb_corretiva = New System.Windows.Forms.RadioButton()
        Me.txt_pecas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_maquina = New System.Windows.Forms.ComboBox()
        Me.btn_salvar_os = New System.Windows.Forms.Button()
        Me.dgv_os = New System.Windows.Forms.DataGridView()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.pnl_topo = New System.Windows.Forms.Panel()
        CType(Me.dgv_os, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_topo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_tecnico
        '
        Me.txt_tecnico.Location = New System.Drawing.Point(333, 93)
        Me.txt_tecnico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_tecnico.Name = "txt_tecnico"
        Me.txt_tecnico.Size = New System.Drawing.Size(170, 20)
        Me.txt_tecnico.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TAG MAQUINA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TECNICO RESPONSAVEL"
        '
        'dtp_data
        '
        Me.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data.Location = New System.Drawing.Point(34, 160)
        Me.dtp_data.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.Size = New System.Drawing.Size(212, 20)
        Me.dtp_data.TabIndex = 5
        '
        'msk_hora_inicio
        '
        Me.msk_hora_inicio.Location = New System.Drawing.Point(333, 160)
        Me.msk_hora_inicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.msk_hora_inicio.Mask = "00:00"
        Me.msk_hora_inicio.Name = "msk_hora_inicio"
        Me.msk_hora_inicio.Size = New System.Drawing.Size(76, 20)
        Me.msk_hora_inicio.TabIndex = 6
        '
        'msk_hora_fim
        '
        Me.msk_hora_fim.Location = New System.Drawing.Point(427, 160)
        Me.msk_hora_fim.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.msk_hora_fim.Mask = "00:00"
        Me.msk_hora_fim.Name = "msk_hora_fim"
        Me.msk_hora_fim.Size = New System.Drawing.Size(76, 20)
        Me.msk_hora_fim.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "HORA INICIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(424, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "HORA FIM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "DATA "
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(33, 260)
        Me.txt_descricao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(466, 51)
        Me.txt_descricao.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 244)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "DESCRIÇÃO DO SERVIÇO"
        '
        'rdb_preventiva
        '
        Me.rdb_preventiva.AutoSize = True
        Me.rdb_preventiva.Location = New System.Drawing.Point(34, 205)
        Me.rdb_preventiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdb_preventiva.Name = "rdb_preventiva"
        Me.rdb_preventiva.Size = New System.Drawing.Size(93, 17)
        Me.rdb_preventiva.TabIndex = 13
        Me.rdb_preventiva.TabStop = True
        Me.rdb_preventiva.Text = "PREVENTIVA"
        Me.rdb_preventiva.UseVisualStyleBackColor = True
        '
        'rdb_corretiva
        '
        Me.rdb_corretiva.AutoSize = True
        Me.rdb_corretiva.Location = New System.Drawing.Point(165, 205)
        Me.rdb_corretiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdb_corretiva.Name = "rdb_corretiva"
        Me.rdb_corretiva.Size = New System.Drawing.Size(87, 17)
        Me.rdb_corretiva.TabIndex = 14
        Me.rdb_corretiva.TabStop = True
        Me.rdb_corretiva.Text = "CORRETIVA"
        Me.rdb_corretiva.UseVisualStyleBackColor = True
        '
        'txt_pecas
        '
        Me.txt_pecas.Location = New System.Drawing.Point(33, 344)
        Me.txt_pecas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_pecas.Multiline = True
        Me.txt_pecas.Name = "txt_pecas"
        Me.txt_pecas.Size = New System.Drawing.Size(466, 51)
        Me.txt_pecas.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 328)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "PEÇAS UTILIZADAS "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(172, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "LANÇAMENTO DE MANUTENÇÕES "
        '
        'cmb_maquina
        '
        Me.cmb_maquina.FormattingEnabled = True
        Me.cmb_maquina.Location = New System.Drawing.Point(33, 93)
        Me.cmb_maquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_maquina.Name = "cmb_maquina"
        Me.cmb_maquina.Size = New System.Drawing.Size(163, 21)
        Me.cmb_maquina.TabIndex = 18
        '
        'btn_salvar_os
        '
        Me.btn_salvar_os.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_salvar_os.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar_os.Location = New System.Drawing.Point(100, 429)
        Me.btn_salvar_os.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_salvar_os.Name = "btn_salvar_os"
        Me.btn_salvar_os.Size = New System.Drawing.Size(145, 24)
        Me.btn_salvar_os.TabIndex = 19
        Me.btn_salvar_os.Text = "SALVAR"
        Me.btn_salvar_os.UseVisualStyleBackColor = True
        '
        'dgv_os
        '
        Me.dgv_os.AllowUserToAddRows = False
        Me.dgv_os.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_os.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_os.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_os.BackgroundColor = System.Drawing.Color.White
        Me.dgv_os.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_os.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_os.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_os.EnableHeadersVisualStyles = False
        Me.dgv_os.Location = New System.Drawing.Point(-1, 485)
        Me.dgv_os.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_os.Name = "dgv_os"
        Me.dgv_os.RowHeadersWidth = 51
        Me.dgv_os.Size = New System.Drawing.Size(562, 158)
        Me.dgv_os.TabIndex = 20
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(290, 429)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(145, 24)
        Me.btn_voltar.TabIndex = 21
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'pnl_topo
        '
        Me.pnl_topo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnl_topo.Controls.Add(Me.Label8)
        Me.pnl_topo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_topo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_topo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_topo.Name = "pnl_topo"
        Me.pnl_topo.Size = New System.Drawing.Size(560, 48)
        Me.pnl_topo.TabIndex = 22
        '
        'frm_Manutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 585)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.dgv_os)
        Me.Controls.Add(Me.btn_salvar_os)
        Me.Controls.Add(Me.cmb_maquina)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_pecas)
        Me.Controls.Add(Me.rdb_corretiva)
        Me.Controls.Add(Me.rdb_preventiva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.msk_hora_fim)
        Me.Controls.Add(Me.msk_hora_inicio)
        Me.Controls.Add(Me.dtp_data)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_tecnico)
        Me.Controls.Add(Me.pnl_topo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_Manutencao"
        Me.Text = "frm_Manutencao"
        CType(Me.dgv_os, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_topo.ResumeLayout(False)
        Me.pnl_topo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_tecnico As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_data As DateTimePicker
    Friend WithEvents msk_hora_inicio As MaskedTextBox
    Friend WithEvents msk_hora_fim As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rdb_preventiva As RadioButton
    Friend WithEvents rdb_corretiva As RadioButton
    Friend WithEvents txt_pecas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_maquina As ComboBox
    Friend WithEvents btn_salvar_os As Button
    Friend WithEvents dgv_os As DataGridView
    Friend WithEvents btn_voltar As Button
    Friend WithEvents pnl_topo As Panel
End Class
