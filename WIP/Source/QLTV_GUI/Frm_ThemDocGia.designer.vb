<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ThemDocGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ThemDocGia))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dtp_NgaySinh = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Dtp_NgayLap = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_Nhap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Btn_NhapVaDong = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Txt_HoVaTen = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_MaDocGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_Email = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_DiaChi = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Cb_LoaiDocGia = New System.Windows.Forms.ComboBox()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(179, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã Độc Giả"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dtp_NgaySinh
        '
        Me.Dtp_NgaySinh.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgaySinh.BorderRadius = 0
        Me.Dtp_NgaySinh.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgaySinh.FormatCustom = Nothing
        Me.Dtp_NgaySinh.Location = New System.Drawing.Point(413, 279)
        Me.Dtp_NgaySinh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp_NgaySinh.Name = "Dtp_NgaySinh"
        Me.Dtp_NgaySinh.Size = New System.Drawing.Size(282, 44)
        Me.Dtp_NgaySinh.TabIndex = 93
        Me.Dtp_NgaySinh.Value = New Date(2018, 6, 8, 0, 0, 0, 0)
        '
        'Dtp_NgayLap
        '
        Me.Dtp_NgayLap.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayLap.BorderRadius = 0
        Me.Dtp_NgayLap.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayLap.FormatCustom = Nothing
        Me.Dtp_NgayLap.Location = New System.Drawing.Point(413, 449)
        Me.Dtp_NgayLap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp_NgayLap.Name = "Dtp_NgayLap"
        Me.Dtp_NgayLap.Size = New System.Drawing.Size(282, 44)
        Me.Dtp_NgayLap.TabIndex = 96
        Me.Dtp_NgayLap.Value = New Date(2018, 6, 8, 0, 0, 0, 0)
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(13, 47)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(882, 54)
        Me.BunifuSeparator1.TabIndex = 29
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(351, 70)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Thêm Độc Giả"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(179, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 44)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Họ Và Tên"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(179, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 44)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Loại Độc Giả"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(179, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 44)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Ngày Sinh"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label6.Location = New System.Drawing.Point(179, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 44)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Địa Chỉ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label8.Location = New System.Drawing.Point(179, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 44)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Email"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label9.Location = New System.Drawing.Point(179, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 44)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Ngày Lập"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Nhap.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Nhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Nhap.BorderRadius = 7
        Me.Btn_Nhap.ButtonText = "NHẬP"
        Me.Btn_Nhap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Nhap.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Nhap.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Nhap.Iconimage = CType(resources.GetObject("Btn_Nhap.Iconimage"), System.Drawing.Image)
        Me.Btn_Nhap.Iconimage_right = Nothing
        Me.Btn_Nhap.Iconimage_right_Selected = Nothing
        Me.Btn_Nhap.Iconimage_Selected = Nothing
        Me.Btn_Nhap.IconMarginLeft = 0
        Me.Btn_Nhap.IconMarginRight = 0
        Me.Btn_Nhap.IconRightVisible = True
        Me.Btn_Nhap.IconRightZoom = 0R
        Me.Btn_Nhap.IconVisible = False
        Me.Btn_Nhap.IconZoom = 90.0R
        Me.Btn_Nhap.IsTab = False
        Me.Btn_Nhap.Location = New System.Drawing.Point(147, 542)
        Me.Btn_Nhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Nhap.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Nhap.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Nhap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Nhap.selected = False
        Me.Btn_Nhap.Size = New System.Drawing.Size(283, 74)
        Me.Btn_Nhap.TabIndex = 97
        Me.Btn_Nhap.Text = "NHẬP"
        Me.Btn_Nhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Nhap.Textcolor = System.Drawing.Color.White
        Me.Btn_Nhap.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(844, 12)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 37
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Btn_NhapVaDong
        '
        Me.Btn_NhapVaDong.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_NhapVaDong.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_NhapVaDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_NhapVaDong.BorderRadius = 7
        Me.Btn_NhapVaDong.ButtonText = "NHẬP VÀ ĐÓNG"
        Me.Btn_NhapVaDong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NhapVaDong.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_NhapVaDong.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_NhapVaDong.Iconimage = CType(resources.GetObject("Btn_NhapVaDong.Iconimage"), System.Drawing.Image)
        Me.Btn_NhapVaDong.Iconimage_right = Nothing
        Me.Btn_NhapVaDong.Iconimage_right_Selected = Nothing
        Me.Btn_NhapVaDong.Iconimage_Selected = Nothing
        Me.Btn_NhapVaDong.IconMarginLeft = 0
        Me.Btn_NhapVaDong.IconMarginRight = 0
        Me.Btn_NhapVaDong.IconRightVisible = True
        Me.Btn_NhapVaDong.IconRightZoom = 0R
        Me.Btn_NhapVaDong.IconVisible = False
        Me.Btn_NhapVaDong.IconZoom = 90.0R
        Me.Btn_NhapVaDong.IsTab = False
        Me.Btn_NhapVaDong.Location = New System.Drawing.Point(479, 542)
        Me.Btn_NhapVaDong.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_NhapVaDong.Name = "Btn_NhapVaDong"
        Me.Btn_NhapVaDong.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_NhapVaDong.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_NhapVaDong.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_NhapVaDong.selected = False
        Me.Btn_NhapVaDong.Size = New System.Drawing.Size(283, 74)
        Me.Btn_NhapVaDong.TabIndex = 98
        Me.Btn_NhapVaDong.Text = "NHẬP VÀ ĐÓNG"
        Me.Btn_NhapVaDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_NhapVaDong.Textcolor = System.Drawing.Color.White
        Me.Btn_NhapVaDong.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_HoVaTen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(413, 163)
        Me.Txt_HoVaTen.Multiline = True
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(282, 44)
        Me.Txt_HoVaTen.TabIndex = 91
        '
        'Txt_MaDocGia
        '
        Me.Txt_MaDocGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaDocGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaDocGia.Location = New System.Drawing.Point(413, 106)
        Me.Txt_MaDocGia.Multiline = True
        Me.Txt_MaDocGia.Name = "Txt_MaDocGia"
        Me.Txt_MaDocGia.ReadOnly = True
        Me.Txt_MaDocGia.Size = New System.Drawing.Size(282, 44)
        Me.Txt_MaDocGia.TabIndex = 90
        '
        'Txt_Email
        '
        Me.Txt_Email.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Email.Location = New System.Drawing.Point(413, 394)
        Me.Txt_Email.Multiline = True
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(282, 44)
        Me.Txt_Email.TabIndex = 95
        '
        'Txt_DiaChi
        '
        Me.Txt_DiaChi.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_DiaChi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DiaChi.Location = New System.Drawing.Point(413, 336)
        Me.Txt_DiaChi.Multiline = True
        Me.Txt_DiaChi.Name = "Txt_DiaChi"
        Me.Txt_DiaChi.Size = New System.Drawing.Size(282, 44)
        Me.Txt_DiaChi.TabIndex = 94
        '
        'Cb_LoaiDocGia
        '
        Me.Cb_LoaiDocGia.DropDownWidth = 269
        Me.Cb_LoaiDocGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_LoaiDocGia.FormattingEnabled = True
        Me.Cb_LoaiDocGia.IntegralHeight = False
        Me.Cb_LoaiDocGia.ItemHeight = 27
        Me.Cb_LoaiDocGia.Location = New System.Drawing.Point(413, 225)
        Me.Cb_LoaiDocGia.Name = "Cb_LoaiDocGia"
        Me.Cb_LoaiDocGia.Size = New System.Drawing.Size(282, 35)
        Me.Cb_LoaiDocGia.TabIndex = 92
        '
        'Frm_ThemDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(911, 644)
        Me.Controls.Add(Me.Cb_LoaiDocGia)
        Me.Controls.Add(Me.Txt_DiaChi)
        Me.Controls.Add(Me.Txt_Email)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Txt_MaDocGia)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Dtp_NgayLap)
        Me.Controls.Add(Me.Dtp_NgaySinh)
        Me.Controls.Add(Me.Btn_NhapVaDong)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(262, 80)
        Me.MaximizeBox = False
        Me.Name = "Frm_ThemDocGia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ThemDocGia"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_NhapVaDong As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Dtp_NgayLap As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Dtp_NgaySinh As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Btn_Nhap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Txt_HoVaTen As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_MaDocGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_DiaChi As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_Email As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Cb_LoaiDocGia As ComboBox
End Class
