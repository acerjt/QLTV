<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_LapPhieuMuonSach
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_MaPhieuMuonSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_HoVaTen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cl_STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_MaSach = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_NgayDuKienTra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cb_MaDocGia = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu"
        '
        'Txt_MaPhieuMuonSach
        '
        Me.Txt_MaPhieuMuonSach.Location = New System.Drawing.Point(151, 79)
        Me.Txt_MaPhieuMuonSach.Name = "Txt_MaPhieuMuonSach"
        Me.Txt_MaPhieuMuonSach.ReadOnly = True
        Me.Txt_MaPhieuMuonSach.Size = New System.Drawing.Size(180, 26)
        Me.Txt_MaPhieuMuonSach.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Độc Giả"
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(151, 194)
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.ReadOnly = True
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(180, 26)
        Me.Txt_HoVaTen.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Họ và Tên"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(517, 73)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(162, 26)
        Me.TextBox4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ngày Mượn"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(517, 132)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(162, 26)
        Me.TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(414, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Loại Độc Giả"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(517, 188)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(162, 26)
        Me.TextBox6.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ngày Sinh"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_STT, Me.Cl_MaSach, Me.Cl_TenSach, Me.Cl_TacGia, Me.Cl_TinhTrang, Me.Cl_NgayDuKienTra})
        Me.DataGridView1.Location = New System.Drawing.Point(52, 267)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(869, 310)
        Me.DataGridView1.TabIndex = 12
        '
        'Cl_STT
        '
        Me.Cl_STT.HeaderText = "STT"
        Me.Cl_STT.Name = "Cl_STT"
        Me.Cl_STT.ReadOnly = True
        '
        'Cl_MaSach
        '
        Me.Cl_MaSach.HeaderText = "Mã Sách"
        Me.Cl_MaSach.Name = "Cl_MaSach"
        '
        'Cl_TenSach
        '
        Me.Cl_TenSach.HeaderText = "Tên Sách"
        Me.Cl_TenSach.Name = "Cl_TenSach"
        Me.Cl_TenSach.ReadOnly = True
        '
        'Cl_TacGia
        '
        Me.Cl_TacGia.HeaderText = "Tác Giả"
        Me.Cl_TacGia.Name = "Cl_TacGia"
        Me.Cl_TacGia.ReadOnly = True
        '
        'Cl_TinhTrang
        '
        Me.Cl_TinhTrang.HeaderText = "Tình Trạng"
        Me.Cl_TinhTrang.Name = "Cl_TinhTrang"
        Me.Cl_TinhTrang.ReadOnly = True
        '
        'Cl_NgayDuKienTra
        '
        Me.Cl_NgayDuKienTra.HeaderText = "Ngày Dự Kiến Trả"
        Me.Cl_NgayDuKienTra.Name = "Cl_NgayDuKienTra"
        Me.Cl_NgayDuKienTra.ReadOnly = True
        '
        'Cb_MaDocGia
        '
        Me.Cb_MaDocGia.FormattingEnabled = True
        Me.Cb_MaDocGia.Location = New System.Drawing.Point(148, 129)
        Me.Cb_MaDocGia.Name = "Cb_MaDocGia"
        Me.Cb_MaDocGia.Size = New System.Drawing.Size(183, 28)
        Me.Cb_MaDocGia.TabIndex = 13
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(834, 106)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 14
        Me.DataGridView2.Visible = False
        '
        'Frm_LapPhieuMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 659)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Cb_MaDocGia)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaPhieuMuonSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_LapPhieuMuonSach"
        Me.Text = "Phiếu Mượn Sách"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_MaPhieuMuonSach As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_HoVaTen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cl_STT As DataGridViewTextBoxColumn
    Friend WithEvents Cl_MaSach As DataGridViewComboBoxColumn
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TacGia As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TinhTrang As DataGridViewTextBoxColumn
    Friend WithEvents Cl_NgayDuKienTra As DataGridViewTextBoxColumn
    Friend WithEvents Cb_MaDocGia As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
End Class
