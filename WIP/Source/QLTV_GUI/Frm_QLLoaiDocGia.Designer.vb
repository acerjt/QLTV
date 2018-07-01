<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_QLLoaiDocGia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_QLLoaiDocGia))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_TenLoaiDocGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_MaLoaiDocGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Btn_CapNhat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Xoa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Dgv_ListLoaiDocGia = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListLoaiDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(128, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 44)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Tên Loại Độc Giả"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(128, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 44)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Mã Loại Độc Giả"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(758, 12)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 75
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(-1, -3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(504, 70)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Quản Lí Loại Độc Giả"
        '
        'Txt_TenLoaiDocGia
        '
        Me.Txt_TenLoaiDocGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TenLoaiDocGia.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TenLoaiDocGia.Location = New System.Drawing.Point(415, 399)
        Me.Txt_TenLoaiDocGia.Multiline = True
        Me.Txt_TenLoaiDocGia.Name = "Txt_TenLoaiDocGia"
        Me.Txt_TenLoaiDocGia.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TenLoaiDocGia.TabIndex = 95
        '
        'Txt_MaLoaiDocGia
        '
        Me.Txt_MaLoaiDocGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaLoaiDocGia.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaLoaiDocGia.Location = New System.Drawing.Point(415, 335)
        Me.Txt_MaLoaiDocGia.Multiline = True
        Me.Txt_MaLoaiDocGia.Name = "Txt_MaLoaiDocGia"
        Me.Txt_MaLoaiDocGia.ReadOnly = True
        Me.Txt_MaLoaiDocGia.Size = New System.Drawing.Size(282, 44)
        Me.Txt_MaLoaiDocGia.TabIndex = 94
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-6, 47)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(819, 54)
        Me.BunifuSeparator1.TabIndex = 96
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Btn_CapNhat
        '
        Me.Btn_CapNhat.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_CapNhat.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_CapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_CapNhat.BorderRadius = 7
        Me.Btn_CapNhat.ButtonText = "CẬP NHẬT"
        Me.Btn_CapNhat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CapNhat.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_CapNhat.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_CapNhat.Iconimage = CType(resources.GetObject("Btn_CapNhat.Iconimage"), System.Drawing.Image)
        Me.Btn_CapNhat.Iconimage_right = Nothing
        Me.Btn_CapNhat.Iconimage_right_Selected = Nothing
        Me.Btn_CapNhat.Iconimage_Selected = Nothing
        Me.Btn_CapNhat.IconMarginLeft = 0
        Me.Btn_CapNhat.IconMarginRight = 0
        Me.Btn_CapNhat.IconRightVisible = True
        Me.Btn_CapNhat.IconRightZoom = 0R
        Me.Btn_CapNhat.IconVisible = False
        Me.Btn_CapNhat.IconZoom = 90.0R
        Me.Btn_CapNhat.IsTab = False
        Me.Btn_CapNhat.Location = New System.Drawing.Point(125, 500)
        Me.Btn_CapNhat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_CapNhat.Name = "Btn_CapNhat"
        Me.Btn_CapNhat.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_CapNhat.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_CapNhat.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_CapNhat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_CapNhat.selected = False
        Me.Btn_CapNhat.Size = New System.Drawing.Size(243, 74)
        Me.Btn_CapNhat.TabIndex = 97
        Me.Btn_CapNhat.Text = "CẬP NHẬT"
        Me.Btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_CapNhat.Textcolor = System.Drawing.Color.White
        Me.Btn_CapNhat.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Btn_Xoa.Location = New System.Drawing.Point(450, 500)
        Me.Btn_Xoa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Xoa.Name = "Btn_Xoa"
        Me.Btn_Xoa.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Xoa.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Xoa.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Xoa.selected = False
        Me.Btn_Xoa.Size = New System.Drawing.Size(258, 74)
        Me.Btn_Xoa.TabIndex = 98
        Me.Btn_Xoa.Text = "XÓA"
        Me.Btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Xoa.Textcolor = System.Drawing.Color.White
        Me.Btn_Xoa.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Dgv_ListLoaiDocGia
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_ListLoaiDocGia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ListLoaiDocGia.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListLoaiDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListLoaiDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListLoaiDocGia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ListLoaiDocGia.ColumnHeadersHeight = 40
        Me.Dgv_ListLoaiDocGia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.a})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_ListLoaiDocGia.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_ListLoaiDocGia.DoubleBuffered = True
        Me.Dgv_ListLoaiDocGia.EnableHeadersVisualStyles = False
        Me.Dgv_ListLoaiDocGia.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListLoaiDocGia.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListLoaiDocGia.Location = New System.Drawing.Point(85, 109)
        Me.Dgv_ListLoaiDocGia.Name = "Dgv_ListLoaiDocGia"
        Me.Dgv_ListLoaiDocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListLoaiDocGia.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ListLoaiDocGia.RowHeadersWidth = 50
        Me.Dgv_ListLoaiDocGia.RowTemplate.Height = 28
        Me.Dgv_ListLoaiDocGia.Size = New System.Drawing.Size(668, 184)
        Me.Dgv_ListLoaiDocGia.TabIndex = 99
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "Mã Loại Độc Giả"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 272
        '
        'a
        '
        Me.a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.a.HeaderText = "Tên Loại Độc Giả"
        Me.a.Name = "a"
        Me.a.Width = 278
        '
        'Frm_QLLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(849, 602)
        Me.Controls.Add(Me.Dgv_ListLoaiDocGia)
        Me.Controls.Add(Me.Btn_Xoa)
        Me.Controls.Add(Me.Btn_CapNhat)
        Me.Controls.Add(Me.Txt_TenLoaiDocGia)
        Me.Controls.Add(Me.Txt_MaLoaiDocGia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_QLLoaiDocGia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_QLLoaiDocGia"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListLoaiDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_TenLoaiDocGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_MaLoaiDocGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Btn_CapNhat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_Xoa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Dgv_ListLoaiDocGia As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents a As DataGridViewTextBoxColumn
End Class
