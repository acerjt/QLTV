<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QLTacGia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_QLTacGia))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.Dgv_ListTacGia = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.M = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Xoa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_CapNhap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Txt_TenTacGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_MaTacGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListTacGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(-1, -6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 70)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Quản Lí Tác Giả"
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(719, 16)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 40
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-6, 47)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(780, 54)
        Me.BunifuSeparator1.TabIndex = 39
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(124, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 44)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Tên Tác Giả"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd
        '
        Me.d.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.ForeColor = System.Drawing.Color.SeaGreen
        Me.d.Location = New System.Drawing.Point(124, 356)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(232, 44)
        Me.d.TabIndex = 46
        Me.d.Text = "Mã Tác Giả"
        Me.d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dgv_ListTacGia
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListTacGia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ListTacGia.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListTacGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListTacGia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ListTacGia.ColumnHeadersHeight = 40
        Me.Dgv_ListTacGia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M, Me.v})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_ListTacGia.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_ListTacGia.DoubleBuffered = True
        Me.Dgv_ListTacGia.EnableHeadersVisualStyles = False
        Me.Dgv_ListTacGia.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListTacGia.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListTacGia.Location = New System.Drawing.Point(75, 94)
        Me.Dgv_ListTacGia.Name = "Dgv_ListTacGia"
        Me.Dgv_ListTacGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListTacGia.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ListTacGia.RowHeadersWidth = 20
        Me.Dgv_ListTacGia.RowTemplate.Height = 28
        Me.Dgv_ListTacGia.Size = New System.Drawing.Size(641, 234)
        Me.Dgv_ListTacGia.TabIndex = 63
        '
        'M
        '
        Me.M.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.M.HeaderText = "Mã Tác Giả"
        Me.M.Name = "M"
        Me.M.Width = 199
        '
        'v
        '
        Me.v.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.v.HeaderText = "Tên Tác Giả"
        Me.v.Name = "v"
        Me.v.Width = 205
        '
        'Btn_Xoa
        '
        Me.Btn_Xoa.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Xoa.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Xoa.BorderRadius = 7
        Me.Btn_Xoa.ButtonText = "XÓA"
        Me.Btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Xoa.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Xoa.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Xoa.Iconimage = CType(resources.GetObject("Btn_Xoa.Iconimage"), System.Drawing.Image)
        Me.Btn_Xoa.Iconimage_right = Nothing
        Me.Btn_Xoa.Iconimage_right_Selected = Nothing
        Me.Btn_Xoa.Iconimage_Selected = Nothing
        Me.Btn_Xoa.IconMarginLeft = 0
        Me.Btn_Xoa.IconMarginRight = 0
        Me.Btn_Xoa.IconRightVisible = True
        Me.Btn_Xoa.IconRightZoom = 0R
        Me.Btn_Xoa.IconVisible = False
        Me.Btn_Xoa.IconZoom = 90.0R
        Me.Btn_Xoa.IsTab = False
        Me.Btn_Xoa.Location = New System.Drawing.Point(461, 534)
        Me.Btn_Xoa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Xoa.Name = "Btn_Xoa"
        Me.Btn_Xoa.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Xoa.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Xoa.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Xoa.selected = False
        Me.Btn_Xoa.Size = New System.Drawing.Size(227, 74)
        Me.Btn_Xoa.TabIndex = 75
        Me.Btn_Xoa.Text = "XÓA"
        Me.Btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Xoa.Textcolor = System.Drawing.Color.White
        Me.Btn_Xoa.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_CapNhap
        '
        Me.Btn_CapNhap.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_CapNhap.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_CapNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_CapNhap.BorderRadius = 7
        Me.Btn_CapNhap.ButtonText = "CẬP NHẬT"
        Me.Btn_CapNhap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CapNhap.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_CapNhap.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_CapNhap.Iconimage = CType(resources.GetObject("Btn_CapNhap.Iconimage"), System.Drawing.Image)
        Me.Btn_CapNhap.Iconimage_right = Nothing
        Me.Btn_CapNhap.Iconimage_right_Selected = Nothing
        Me.Btn_CapNhap.Iconimage_Selected = Nothing
        Me.Btn_CapNhap.IconMarginLeft = 0
        Me.Btn_CapNhap.IconMarginRight = 0
        Me.Btn_CapNhap.IconRightVisible = True
        Me.Btn_CapNhap.IconRightZoom = 0R
        Me.Btn_CapNhap.IconVisible = False
        Me.Btn_CapNhap.IconZoom = 90.0R
        Me.Btn_CapNhap.IsTab = False
        Me.Btn_CapNhap.Location = New System.Drawing.Point(129, 532)
        Me.Btn_CapNhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_CapNhap.Name = "Btn_CapNhap"
        Me.Btn_CapNhap.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_CapNhap.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_CapNhap.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_CapNhap.selected = False
        Me.Btn_CapNhap.Size = New System.Drawing.Size(227, 74)
        Me.Btn_CapNhap.TabIndex = 74
        Me.Btn_CapNhap.Text = "CẬP NHẬT"
        Me.Btn_CapNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_CapNhap.Textcolor = System.Drawing.Color.White
        Me.Btn_CapNhap.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Txt_TenTacGia
        '
        Me.Txt_TenTacGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TenTacGia.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TenTacGia.Location = New System.Drawing.Point(406, 419)
        Me.Txt_TenTacGia.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_TenTacGia.Multiline = True
        Me.Txt_TenTacGia.Name = "Txt_TenTacGia"
        Me.Txt_TenTacGia.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TenTacGia.TabIndex = 135
        '
        'Txt_MaTacGia
        '
        Me.Txt_MaTacGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaTacGia.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaTacGia.Location = New System.Drawing.Point(406, 356)
        Me.Txt_MaTacGia.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_MaTacGia.Multiline = True
        Me.Txt_MaTacGia.Name = "Txt_MaTacGia"
        Me.Txt_MaTacGia.ReadOnly = True
        Me.Txt_MaTacGia.Size = New System.Drawing.Size(282, 44)
        Me.Txt_MaTacGia.TabIndex = 134
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Frm_QLTacGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 654)
        Me.ControlBox = False
        Me.Controls.Add(Me.Txt_TenTacGia)
        Me.Controls.Add(Me.Txt_MaTacGia)
        Me.Controls.Add(Me.Btn_Xoa)
        Me.Controls.Add(Me.Btn_CapNhap)
        Me.Controls.Add(Me.Dgv_ListTacGia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_QLTacGia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListTacGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents d As Label
    Friend WithEvents Dgv_ListTacGia As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Btn_Xoa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_CapNhap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Txt_TenTacGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_MaTacGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents M As DataGridViewTextBoxColumn
    Friend WithEvents v As DataGridViewTextBoxColumn
End Class
