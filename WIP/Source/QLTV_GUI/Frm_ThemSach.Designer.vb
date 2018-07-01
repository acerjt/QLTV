<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ThemSach
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ThemSach))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Dgv_ThemListSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Dtp_NgayNhap = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Btn_Nhap = New System.Windows.Forms.Button()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Cl_MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TheLoaiSach = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cl_TacGia = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cl_NamXuatBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_NhaXuatBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TriGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_ThemListSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Dgv_ThemListSach
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ThemListSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ThemListSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Dgv_ThemListSach.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ThemListSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ThemListSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ThemListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ThemListSach.ColumnHeadersHeight = 50
        Me.Dgv_ThemListSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_MaSach, Me.Cl_TenSach, Me.Cl_TheLoaiSach, Me.Cl_TacGia, Me.Cl_NamXuatBan, Me.Cl_NhaXuatBan, Me.Cl_TriGia})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_ThemListSach.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_ThemListSach.DoubleBuffered = True
        Me.Dgv_ThemListSach.EnableHeadersVisualStyles = False
        Me.Dgv_ThemListSach.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ThemListSach.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ThemListSach.Location = New System.Drawing.Point(77, 158)
        Me.Dgv_ThemListSach.Name = "Dgv_ThemListSach"
        Me.Dgv_ThemListSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ThemListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ThemListSach.RowHeadersWidth = 30
        Me.Dgv_ThemListSach.RowTemplate.Height = 35
        Me.Dgv_ThemListSach.Size = New System.Drawing.Size(1595, 303)
        Me.Dgv_ThemListSach.TabIndex = 1
        '
        'Dtp_NgayNhap
        '
        Me.Dtp_NgayNhap.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayNhap.BorderRadius = 0
        Me.Dtp_NgayNhap.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_NgayNhap.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayNhap.FormatCustom = Nothing
        Me.Dtp_NgayNhap.Location = New System.Drawing.Point(388, 97)
        Me.Dtp_NgayNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.Dtp_NgayNhap.Name = "Dtp_NgayNhap"
        Me.Dtp_NgayNhap.Size = New System.Drawing.Size(245, 33)
        Me.Dtp_NgayNhap.TabIndex = 2
        Me.Dtp_NgayNhap.Value = New Date(2018, 6, 9, 10, 7, 9, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(-2, -4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 60)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Thêm Sách"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-5, 48)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1677, 25)
        Me.BunifuSeparator1.TabIndex = 102
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.label5.Location = New System.Drawing.Point(180, 97)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(202, 33)
        Me.label5.TabIndex = 104
        Me.label5.Text = "Ngày Nhập"
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Nhap.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nhap.Image = Global.QLTV_GUI.My.Resources.Resources.Untitled
        Me.Btn_Nhap.Location = New System.Drawing.Point(768, 491)
        Me.Btn_Nhap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Size = New System.Drawing.Size(230, 52)
        Me.Btn_Nhap.TabIndex = 106
        Me.Btn_Nhap.Text = "Nhập"
        Me.Btn_Nhap.UseVisualStyleBackColor = False
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1623, 4)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(49, 38)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 103
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Cl_MaSach
        '
        Me.Cl_MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cl_MaSach.FillWeight = 111.0!
        Me.Cl_MaSach.HeaderText = "Mã Sách"
        Me.Cl_MaSach.Name = "Cl_MaSach"
        Me.Cl_MaSach.ReadOnly = True
        '
        'Cl_TenSach
        '
        Me.Cl_TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cl_TenSach.HeaderText = "Tên Sách"
        Me.Cl_TenSach.Name = "Cl_TenSach"
        Me.Cl_TenSach.Width = 260
        '
        'Cl_TheLoaiSach
        '
        Me.Cl_TheLoaiSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cl_TheLoaiSach.HeaderText = "Thể Loại Sách"
        Me.Cl_TheLoaiSach.Name = "Cl_TheLoaiSach"
        Me.Cl_TheLoaiSach.Width = 85
        '
        'Cl_TacGia
        '
        Me.Cl_TacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cl_TacGia.HeaderText = "Tác Giả"
        Me.Cl_TacGia.Name = "Cl_TacGia"
        Me.Cl_TacGia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cl_TacGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Cl_TacGia.Width = 240
        '
        'Cl_NamXuatBan
        '
        Me.Cl_NamXuatBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cl_NamXuatBan.HeaderText = "Năm Xuất Bản"
        Me.Cl_NamXuatBan.Name = "Cl_NamXuatBan"
        Me.Cl_NamXuatBan.Width = 85
        '
        'Cl_NhaXuatBan
        '
        Me.Cl_NhaXuatBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cl_NhaXuatBan.HeaderText = "Nhà Xuất Bản"
        Me.Cl_NhaXuatBan.Name = "Cl_NhaXuatBan"
        Me.Cl_NhaXuatBan.Width = 177
        '
        'Cl_TriGia
        '
        Me.Cl_TriGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cl_TriGia.HeaderText = "Trị Giá"
        Me.Cl_TriGia.Name = "Cl_TriGia"
        Me.Cl_TriGia.Width = 106
        '
        'Frm_ThemSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1710, 554)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Dtp_NgayNhap)
        Me.Controls.Add(Me.Dgv_ThemListSach)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_ThemSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "??"
        CType(Me.Dgv_ThemListSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Dgv_ThemListSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Dtp_NgayNhap As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Private WithEvents label5 As Label
    Friend WithEvents Btn_Nhap As Button
    Friend WithEvents Cl_MaSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TheLoaiSach As DataGridViewComboBoxColumn
    Friend WithEvents Cl_TacGia As DataGridViewComboBoxColumn
    Friend WithEvents Cl_NamXuatBan As DataGridViewTextBoxColumn
    Friend WithEvents Cl_NhaXuatBan As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TriGia As DataGridViewTextBoxColumn
End Class
