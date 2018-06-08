<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ThemListSach
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Cl_MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TheLoaiSach = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cl_TacGia = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cl_NamXuatBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_NhaXuatBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TriGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Nhap = New System.Windows.Forms.Button()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_MaSach, Me.Cl_TenSach, Me.Cl_TheLoaiSach, Me.Cl_TacGia, Me.Cl_NamXuatBan, Me.Cl_NhaXuatBan, Me.Cl_TriGia})
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(59, 85)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowTemplate.Height = 24
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(1246, 303)
        Me.BunifuCustomDataGrid1.TabIndex = 0
        '
        'Cl_MaSach
        '
        Me.Cl_MaSach.HeaderText = "Mã Sách"
        Me.Cl_MaSach.Name = "Cl_MaSach"
        Me.Cl_MaSach.ReadOnly = True
        '
        'Cl_TenSach
        '
        Me.Cl_TenSach.HeaderText = "Tên Sách"
        Me.Cl_TenSach.Name = "Cl_TenSach"
        '
        'Cl_TheLoaiSach
        '
        Me.Cl_TheLoaiSach.HeaderText = "Thể Loại Sách"
        Me.Cl_TheLoaiSach.Name = "Cl_TheLoaiSach"
        '
        'Cl_TacGia
        '
        Me.Cl_TacGia.HeaderText = "Tác Giả"
        Me.Cl_TacGia.Name = "Cl_TacGia"
        Me.Cl_TacGia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cl_TacGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Cl_NamXuatBan
        '
        Me.Cl_NamXuatBan.HeaderText = "Năm Xuất Bản"
        Me.Cl_NamXuatBan.Name = "Cl_NamXuatBan"
        '
        'Cl_NhaXuatBan
        '
        Me.Cl_NhaXuatBan.HeaderText = "Nhà Xuất Bản"
        Me.Cl_NhaXuatBan.Name = "Cl_NhaXuatBan"
        '
        'Cl_TriGia
        '
        Me.Cl_TriGia.HeaderText = "Trị Giá"
        Me.Cl_TriGia.Name = "Cl_TriGia"
        '
        'Btn_Nhap
        '
        Me.Btn_Nhap.Location = New System.Drawing.Point(206, 425)
        Me.Btn_Nhap.Name = "Btn_Nhap"
        Me.Btn_Nhap.Size = New System.Drawing.Size(171, 60)
        Me.Btn_Nhap.TabIndex = 1
        Me.Btn_Nhap.Text = "Nhập"
        Me.Btn_Nhap.UseVisualStyleBackColor = True
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Location = New System.Drawing.Point(764, 12)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(200, 30)
        Me.MetroDateTime1.TabIndex = 2
        '
        'Frm_ThemListSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 518)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.Btn_Nhap)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ThemListSach"
        Me.Text = "Frm_ThemListSach"
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Btn_Nhap As Button
    Friend WithEvents Cl_MaSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TheLoaiSach As DataGridViewComboBoxColumn
    Friend WithEvents Cl_TacGia As DataGridViewComboBoxColumn
    Friend WithEvents Cl_NamXuatBan As DataGridViewTextBoxColumn
    Friend WithEvents Cl_NhaXuatBan As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TriGia As DataGridViewTextBoxColumn
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
End Class
