<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Manutencao
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_os = New System.Windows.Forms.DataGridView()
        Me.pnl_topo = New System.Windows.Forms.Panel()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salvar_os = New System.Windows.Forms.Button()
        Me.cmb_maquina = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_data = New System.Windows.Forms.DateTimePicker()
        Me.btn_ir_finalizacao = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        CType(Me.dgv_os, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_topo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(185, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(270, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "ABERTURA DE ORDEM DE SERVIÇO"
        '
        'dgv_os
        '
        Me.dgv_os.AllowUserToAddRows = False
        Me.dgv_os.AllowUserToDeleteRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_os.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dgv_os.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_os.BackgroundColor = System.Drawing.Color.White
        Me.dgv_os.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_os.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgv_os.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_os.EnableHeadersVisualStyles = False
        Me.dgv_os.Location = New System.Drawing.Point(0, 354)
        Me.dgv_os.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_os.Name = "dgv_os"
        Me.dgv_os.RowHeadersWidth = 51
        Me.dgv_os.Size = New System.Drawing.Size(650, 111)
        Me.dgv_os.TabIndex = 20
        '
        'pnl_topo
        '
        Me.pnl_topo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnl_topo.Controls.Add(Me.Label8)
        Me.pnl_topo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_topo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_topo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_topo.Name = "pnl_topo"
        Me.pnl_topo.Size = New System.Drawing.Size(652, 48)
        Me.pnl_topo.TabIndex = 22
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(25, 145)
        Me.txt_descricao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(457, 51)
        Me.txt_descricao.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "DESCRIÇÃO DA OCORRÊNCIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TAG MAQUINA"
        '
        'btn_salvar_os
        '
        Me.btn_salvar_os.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_salvar_os.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar_os.Location = New System.Drawing.Point(25, 210)
        Me.btn_salvar_os.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_salvar_os.Name = "btn_salvar_os"
        Me.btn_salvar_os.Size = New System.Drawing.Size(80, 24)
        Me.btn_salvar_os.TabIndex = 19
        Me.btn_salvar_os.Text = "SALVAR"
        Me.btn_salvar_os.UseVisualStyleBackColor = True
        '
        'cmb_maquina
        '
        Me.cmb_maquina.FormattingEnabled = True
        Me.cmb_maquina.Location = New System.Drawing.Point(25, 83)
        Me.cmb_maquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_maquina.Name = "cmb_maquina"
        Me.cmb_maquina.Size = New System.Drawing.Size(163, 21)
        Me.cmb_maquina.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "DATA DE ABERTURA"
        '
        'dtp_data
        '
        Me.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_data.Location = New System.Drawing.Point(236, 84)
        Me.dtp_data.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp_data.Name = "dtp_data"
        Me.dtp_data.Size = New System.Drawing.Size(122, 20)
        Me.dtp_data.TabIndex = 5
        '
        'btn_ir_finalizacao
        '
        Me.btn_ir_finalizacao.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_ir_finalizacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ir_finalizacao.Location = New System.Drawing.Point(30, 300)
        Me.btn_ir_finalizacao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_ir_finalizacao.Name = "btn_ir_finalizacao"
        Me.btn_ir_finalizacao.Size = New System.Drawing.Size(216, 24)
        Me.btn_ir_finalizacao.TabIndex = 23
        Me.btn_ir_finalizacao.Text = "ENCERRAMENTO DE O.S."
        Me.btn_ir_finalizacao.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Location = New System.Drawing.Point(270, 300)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(80, 24)
        Me.btn_voltar.TabIndex = 21
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'frm_Manutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 466)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_ir_finalizacao)
        Me.Controls.Add(Me.btn_salvar_os)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgv_os)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_data)
        Me.Controls.Add(Me.pnl_topo)
        Me.Controls.Add(Me.cmb_maquina)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_Manutencao"
        Me.Text = "frm_Manutencao"
        CType(Me.dgv_os, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_topo.ResumeLayout(False)
        Me.pnl_topo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_os As DataGridView
    Friend WithEvents pnl_topo As Panel
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_salvar_os As Button
    Friend WithEvents cmb_maquina As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_data As DateTimePicker
    Friend WithEvents btn_ir_finalizacao As Button
    Friend WithEvents btn_voltar As Button
End Class
