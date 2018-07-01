<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_QuyDinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_QuyDinh))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gdf = New System.Windows.Forms.Label()
        Me.ad = New System.Windows.Forms.Label()
        Me.sa = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_CapNhap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Txt_SoNgayMuonToiDa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_SoLuongSachMuonToiDa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_KhoangCachNamXuatBan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_SoTacGiaToiDa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_SoTheLoaiSachToiDa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_ThoiGianSuDung = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_TuoiToiDa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_TuoiToiThieu = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label7.Location = New System.Drawing.Point(76, 492)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(463, 44)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Số Lượng Sách Mượn Tối Đa"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gdf
        '
        Me.gdf.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gdf.ForeColor = System.Drawing.Color.SeaGreen
        Me.gdf.Location = New System.Drawing.Point(76, 433)
        Me.gdf.Name = "gdf"
        Me.gdf.Size = New System.Drawing.Size(463, 44)
        Me.gdf.TabIndex = 26
        Me.gdf.Text = "Khoảng Cách Năm Xuất Bản"
        Me.gdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ad
        '
        Me.ad.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad.ForeColor = System.Drawing.Color.SeaGreen
        Me.ad.Location = New System.Drawing.Point(76, 369)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(463, 44)
        Me.ad.TabIndex = 24
        Me.ad.Text = "Số Tác Giả Tối Đa"
        Me.ad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sa
        '
        Me.sa.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sa.ForeColor = System.Drawing.Color.SeaGreen
        Me.sa.Location = New System.Drawing.Point(76, 305)
        Me.sa.Name = "sa"
        Me.sa.Size = New System.Drawing.Size(437, 44)
        Me.sa.TabIndex = 22
        Me.sa.Text = "Số Thể Loại Sách Tối Đa"
        Me.sa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label
        '
        Me.Label.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label.Location = New System.Drawing.Point(76, 244)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(463, 44)
        Me.Label.TabIndex = 20
        Me.Label.Text = "Thời Gian Sử Dụng Thẻ"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(76, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(463, 44)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tuổi Tối Đa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(76, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 44)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Tuổi Tối Thiểu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(76, 559)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(463, 44)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Số Ngày Mượn Tối Đa"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Btn_CapNhap.Location = New System.Drawing.Point(328, 623)
        Me.Btn_CapNhap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_CapNhap.Name = "Btn_CapNhap"
        Me.Btn_CapNhap.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_CapNhap.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_CapNhap.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_CapNhap.selected = False
        Me.Btn_CapNhap.Size = New System.Drawing.Size(247, 74)
        Me.Btn_CapNhap.TabIndex = 9
        Me.Btn_CapNhap.Text = "CẬP NHẬT"
        Me.Btn_CapNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_CapNhap.Textcolor = System.Drawing.Color.White
        Me.Btn_CapNhap.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 70)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Quy Định"
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
        Me.BunifuSeparator1.TabIndex = 52
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(840, 12)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 53
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Txt_SoNgayMuonToiDa
        '
        Me.Txt_SoNgayMuonToiDa.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_SoNgayMuonToiDa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SoNgayMuonToiDa.Location = New System.Drawing.Point(532, 559)
        Me.Txt_SoNgayMuonToiDa.Multiline = True
        Me.Txt_SoNgayMuonToiDa.Name = "Txt_SoNgayMuonToiDa"
        Me.Txt_SoNgayMuonToiDa.Size = New System.Drawing.Size(282, 44)
        Me.Txt_SoNgayMuonToiDa.TabIndex = 8
        '
        'Txt_SoLuongSachMuonToiDa
        '
        Me.Txt_SoLuongSachMuonToiDa.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_SoLuongSachMuonToiDa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SoLuongSachMuonToiDa.Location = New System.Drawing.Point(532, 492)
        Me.Txt_SoLuongSachMuonToiDa.Multiline = True
        Me.Txt_SoLuongSachMuonToiDa.Name = "Txt_SoLuongSachMuonToiDa"
        Me.Txt_SoLuongSachMuonToiDa.Size = New System.Drawing.Size(282, 44)
        Me.Txt_SoLuongSachMuonToiDa.TabIndex = 7
        '
        'Txt_KhoangCachNamXuatBan
        '
        Me.Txt_KhoangCachNamXuatBan.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_KhoangCachNamXuatBan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_KhoangCachNamXuatBan.Location = New System.Drawing.Point(532, 433)
        Me.Txt_KhoangCachNamXuatBan.Multiline = True
        Me.Txt_KhoangCachNamXuatBan.Name = "Txt_KhoangCachNamXuatBan"
        Me.Txt_KhoangCachNamXuatBan.Size = New System.Drawing.Size(282, 44)
        Me.Txt_KhoangCachNamXuatBan.TabIndex = 6
        '
        'Txt_SoTacGiaToiDa
        '
        Me.Txt_SoTacGiaToiDa.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_SoTacGiaToiDa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SoTacGiaToiDa.Location = New System.Drawing.Point(532, 369)
        Me.Txt_SoTacGiaToiDa.Multiline = True
        Me.Txt_SoTacGiaToiDa.Name = "Txt_SoTacGiaToiDa"
        Me.Txt_SoTacGiaToiDa.Size = New System.Drawing.Size(282, 44)
        Me.Txt_SoTacGiaToiDa.TabIndex = 5
        '
        'Txt_SoTheLoaiSachToiDa
        '
        Me.Txt_SoTheLoaiSachToiDa.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_SoTheLoaiSachToiDa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SoTheLoaiSachToiDa.Location = New System.Drawing.Point(532, 305)
        Me.Txt_SoTheLoaiSachToiDa.Multiline = True
        Me.Txt_SoTheLoaiSachToiDa.Name = "Txt_SoTheLoaiSachToiDa"
        Me.Txt_SoTheLoaiSachToiDa.Size = New System.Drawing.Size(282, 44)
        Me.Txt_SoTheLoaiSachToiDa.TabIndex = 4
        '
        'Txt_ThoiGianSuDung
        '
        Me.Txt_ThoiGianSuDung.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_ThoiGianSuDung.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ThoiGianSuDung.Location = New System.Drawing.Point(532, 244)
        Me.Txt_ThoiGianSuDung.Multiline = True
        Me.Txt_ThoiGianSuDung.Name = "Txt_ThoiGianSuDung"
        Me.Txt_ThoiGianSuDung.Size = New System.Drawing.Size(282, 44)
        Me.Txt_ThoiGianSuDung.TabIndex = 3
        '
        'Txt_TuoiToiDa
        '
        Me.Txt_TuoiToiDa.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TuoiToiDa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TuoiToiDa.Location = New System.Drawing.Point(532, 180)
        Me.Txt_TuoiToiDa.Multiline = True
        Me.Txt_TuoiToiDa.Name = "Txt_TuoiToiDa"
        Me.Txt_TuoiToiDa.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TuoiToiDa.TabIndex = 2
        '
        'Txt_TuoiToiThieu
        '
        Me.Txt_TuoiToiThieu.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TuoiToiThieu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TuoiToiThieu.Location = New System.Drawing.Point(532, 116)
        Me.Txt_TuoiToiThieu.Multiline = True
        Me.Txt_TuoiToiThieu.Name = "Txt_TuoiToiThieu"
        Me.Txt_TuoiToiThieu.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TuoiToiThieu.TabIndex = 1
        '
        'Frm_QuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(911, 720)
        Me.Controls.Add(Me.Txt_TuoiToiThieu)
        Me.Controls.Add(Me.Txt_TuoiToiDa)
        Me.Controls.Add(Me.Txt_ThoiGianSuDung)
        Me.Controls.Add(Me.Txt_SoTheLoaiSachToiDa)
        Me.Controls.Add(Me.Txt_SoTacGiaToiDa)
        Me.Controls.Add(Me.Txt_KhoangCachNamXuatBan)
        Me.Controls.Add(Me.Txt_SoLuongSachMuonToiDa)
        Me.Controls.Add(Me.Txt_SoNgayMuonToiDa)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_CapNhap)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gdf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ad)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.sa)
        Me.ForeColor = System.Drawing.Color.SeaGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(252, 73)
        Me.Name = "Frm_QuyDinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_QuyDinh"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gdf As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ad As Label
    Friend WithEvents Label As Label
    Friend WithEvents sa As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_CapNhap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Txt_TuoiToiThieu As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_TuoiToiDa As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_ThoiGianSuDung As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_SoTheLoaiSachToiDa As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_SoTacGiaToiDa As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_KhoangCachNamXuatBan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_SoLuongSachMuonToiDa As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_SoNgayMuonToiDa As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
