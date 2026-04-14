<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_1
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.txt_setor = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_tag = New System.Windows.Forms.TextBox()
        Me.btn_foto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dlg_foto = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.img_maquina = New System.Windows.Forms.PictureBox()
        Me.dgv_maquinas = New System.Windows.Forms.DataGridView()
        Me.pnl_topo = New System.Windows.Forms.Panel()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_aquisicao = New System.Windows.Forms.DateTimePicker()
        Me.txt_observacoes = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_fabricante = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.img_maquina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_maquinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_topo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salvar
        '
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Location = New System.Drawing.Point(238, 262)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(74, 24)
        Me.btn_salvar.TabIndex = 0
        Me.btn_salvar.Text = "SALVAR "
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'txt_setor
        '
        Me.txt_setor.Location = New System.Drawing.Point(26, 155)
        Me.txt_setor.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_setor.Name = "txt_setor"
        Me.txt_setor.Size = New System.Drawing.Size(213, 20)
        Me.txt_setor.TabIndex = 1
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(26, 108)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(213, 20)
        Me.txt_nome.TabIndex = 2
        '
        'txt_tag
        '
        Me.txt_tag.Location = New System.Drawing.Point(26, 58)
        Me.txt_tag.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_tag.Name = "txt_tag"
        Me.txt_tag.Size = New System.Drawing.Size(213, 20)
        Me.txt_tag.TabIndex = 3
        '
        'btn_foto
        '
        Me.btn_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_foto.Location = New System.Drawing.Point(664, 227)
        Me.btn_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_foto.Name = "btn_foto"
        Me.btn_foto.Size = New System.Drawing.Size(171, 28)
        Me.btn_foto.TabIndex = 5
        Me.btn_foto.Text = "SELECIONAR FOTO"
        Me.btn_foto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "TAG MAQUINA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "NOME DO MAQUINARIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "LOCAL/ SETOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "CADASTRO DE MAQUINARIO"
        '
        'dlg_foto
        '
        Me.dlg_foto.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(357, 262)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 24)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ABERTURA DE O.S."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'img_maquina
        '
        Me.img_maquina.BackgroundImage = Global.prj_Manutencao_Maquinas.My.Resources.Resources.rm373batch12_0101
        Me.img_maquina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.img_maquina.Location = New System.Drawing.Point(664, 28)
        Me.img_maquina.Margin = New System.Windows.Forms.Padding(2)
        Me.img_maquina.Name = "img_maquina"
        Me.img_maquina.Size = New System.Drawing.Size(171, 180)
        Me.img_maquina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_maquina.TabIndex = 4
        Me.img_maquina.TabStop = False
        '
        'dgv_maquinas
        '
        Me.dgv_maquinas.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_maquinas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_maquinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_maquinas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_maquinas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_maquinas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_maquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_maquinas.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_maquinas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_maquinas.EnableHeadersVisualStyles = False
        Me.dgv_maquinas.Location = New System.Drawing.Point(0, 430)
        Me.dgv_maquinas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_maquinas.Name = "dgv_maquinas"
        Me.dgv_maquinas.RowHeadersVisible = False
        Me.dgv_maquinas.RowHeadersWidth = 51
        Me.dgv_maquinas.Size = New System.Drawing.Size(896, 179)
        Me.dgv_maquinas.TabIndex = 16
        '
        'pnl_topo
        '
        Me.pnl_topo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnl_topo.Controls.Add(Me.lbl_titulo)
        Me.pnl_topo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_topo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_topo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_topo.MaximumSize = New System.Drawing.Size(0, 32)
        Me.pnl_topo.Name = "pnl_topo"
        Me.pnl_topo.Size = New System.Drawing.Size(896, 32)
        Me.pnl_topo.TabIndex = 17
        '
        'lbl_titulo
        '
        Me.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_titulo.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.Snow
        Me.lbl_titulo.Location = New System.Drawing.Point(0, 0)
        Me.lbl_titulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(896, 32)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "                                                                                C" &
    "ADASTRO DE MAQUINAS                "
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.dtp_aquisicao)
        Me.GroupBox1.Controls.Add(Me.txt_observacoes)
        Me.GroupBox1.Controls.Add(Me.txt_modelo)
        Me.GroupBox1.Controls.Add(Me.txt_fabricante)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_tag)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_foto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.img_maquina)
        Me.GroupBox1.Controls.Add(Me.txt_setor)
        Me.GroupBox1.Controls.Add(Me.btn_salvar)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(881, 297)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'dtp_aquisicao
        '
        Me.dtp_aquisicao.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_aquisicao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_aquisicao.Location = New System.Drawing.Point(357, 108)
        Me.dtp_aquisicao.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_aquisicao.Name = "dtp_aquisicao"
        Me.dtp_aquisicao.Size = New System.Drawing.Size(213, 22)
        Me.dtp_aquisicao.TabIndex = 24
        '
        'txt_observacoes
        '
        Me.txt_observacoes.Location = New System.Drawing.Point(357, 155)
        Me.txt_observacoes.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_observacoes.Name = "txt_observacoes"
        Me.txt_observacoes.Size = New System.Drawing.Size(213, 20)
        Me.txt_observacoes.TabIndex = 23
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(357, 58)
        Me.txt_modelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(213, 20)
        Me.txt_modelo.TabIndex = 21
        '
        'txt_fabricante
        '
        Me.txt_fabricante.Location = New System.Drawing.Point(26, 210)
        Me.txt_fabricante.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fabricante.Name = "txt_fabricante"
        Me.txt_fabricante.Size = New System.Drawing.Size(213, 20)
        Me.txt_fabricante.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(355, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "MODELO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(355, 93)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "DATA AQUISIÇÃO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(355, 140)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "OBSERVAÇÕES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 194)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "FABRICANTE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_busca)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 37)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(881, 46)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'txt_busca
        '
        Me.txt_busca.Location = New System.Drawing.Point(100, 20)
        Me.txt_busca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(213, 20)
        Me.txt_busca.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "PESQUISAR:"
        '
        'Form_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 609)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pnl_topo)
        Me.Controls.Add(Me.dgv_maquinas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_1"
        Me.Text = "Form1"
        CType(Me.img_maquina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_maquinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_topo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salvar As Button
    Friend WithEvents txt_setor As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_tag As TextBox
    Friend WithEvents img_maquina As PictureBox
    Friend WithEvents btn_foto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dlg_foto As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv_maquinas As DataGridView
    Friend WithEvents pnl_topo As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents txt_fabricante As TextBox
    Friend WithEvents txt_observacoes As TextBox
    Friend WithEvents dtp_aquisicao As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_busca As TextBox
    Friend WithEvents lbl_titulo As Label
End Class
