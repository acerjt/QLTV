<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_LapBaoCaoThongKeSachTraTre
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
        Me.Txt_MaLapBaoCao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_LapBaoCao = New System.Windows.Forms.Button()
        Me.Dgv_ListLapBaoCaoThongKe = New System.Windows.Forms.DataGridView()
        Me.Cl_TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_NgayMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_SoNgayTraTre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dtp_NgayLap = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_Thang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Nam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cl_Nam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_Thang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgv_ListBaoCaoThongKe = New System.Windows.Forms.DataGridView()
        CType(Me.Dgv_ListLapBaoCaoThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListBaoCaoThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_MaLapBaoCao
        '
        Me.Txt_MaLapBaoCao.Location = New System.Drawing.Point(196, 18)
        Me.Txt_MaLapBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_MaLapBaoCao.Name = "Txt_MaLapBaoCao"
        Me.Txt_MaLapBaoCao.ReadOnly = True
        Me.Txt_MaLapBaoCao.Size = New System.Drawing.Size(109, 22)
        Me.Txt_MaLapBaoCao.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Mã Lập Báo Cáo"
        '
        'Btn_LapBaoCao
        '
        Me.Btn_LapBaoCao.Location = New System.Drawing.Point(196, 400)
        Me.Btn_LapBaoCao.Name = "Btn_LapBaoCao"
        Me.Btn_LapBaoCao.Size = New System.Drawing.Size(130, 48)
        Me.Btn_LapBaoCao.TabIndex = 19
        Me.Btn_LapBaoCao.Text = "Lập Báo Cáo"
        Me.Btn_LapBaoCao.UseVisualStyleBackColor = True
        '
        'Dgv_ListLapBaoCaoThongKe
        '
        Me.Dgv_ListLapBaoCaoThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListLapBaoCaoThongKe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_TenSach, Me.Cl_NgayMuon, Me.Cl_SoNgayTraTre})
        Me.Dgv_ListLapBaoCaoThongKe.Location = New System.Drawing.Point(78, 110)
        Me.Dgv_ListLapBaoCaoThongKe.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgv_ListLapBaoCaoThongKe.Name = "Dgv_ListLapBaoCaoThongKe"
        Me.Dgv_ListLapBaoCaoThongKe.RowTemplate.Height = 33
        Me.Dgv_ListLapBaoCaoThongKe.Size = New System.Drawing.Size(567, 266)
        Me.Dgv_ListLapBaoCaoThongKe.TabIndex = 15
        '
        'Cl_TenSach
        '
        Me.Cl_TenSach.HeaderText = "Tên Sách"
        Me.Cl_TenSach.Name = "Cl_TenSach"
        Me.Cl_TenSach.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cl_TenSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Cl_NgayMuon
        '
        Me.Cl_NgayMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_NgayMuon.HeaderText = "Ngày Mượn"
        Me.Cl_NgayMuon.Name = "Cl_NgayMuon"
        Me.Cl_NgayMuon.ReadOnly = True
        Me.Cl_NgayMuon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cl_NgayMuon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cl_NgayMuon.Width = 77
        '
        'Cl_SoNgayTraTre
        '
        Me.Cl_SoNgayTraTre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_SoNgayTraTre.HeaderText = "Số Ngày Trả Trễ"
        Me.Cl_SoNgayTraTre.Name = "Cl_SoNgayTraTre"
        Me.Cl_SoNgayTraTre.ReadOnly = True
        Me.Cl_SoNgayTraTre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cl_SoNgayTraTre.Width = 88
        '
        'Dtp_NgayLap
        '
        Me.Dtp_NgayLap.Location = New System.Drawing.Point(443, 18)
        Me.Dtp_NgayLap.Name = "Dtp_NgayLap"
        Me.Dtp_NgayLap.Size = New System.Drawing.Size(200, 22)
        Me.Dtp_NgayLap.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Ngày Lập"
        '
        'Cb_Thang
        '
        Me.Cb_Thang.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.Cb_Thang.FormattingEnabled = True
        Me.Cb_Thang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.Cb_Thang.Location = New System.Drawing.Point(443, 59)
        Me.Cb_Thang.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_Thang.Name = "Cb_Thang"
        Me.Cb_Thang.Size = New System.Drawing.Size(200, 24)
        Me.Cb_Thang.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tháng"
        '
        'Txt_Nam
        '
        Me.Txt_Nam.Location = New System.Drawing.Point(196, 64)
        Me.Txt_Nam.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_Nam.Name = "Txt_Nam"
        Me.Txt_Nam.Size = New System.Drawing.Size(109, 22)
        Me.Txt_Nam.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Năm"
        '
        'Cl_Nam
        '
        Me.Cl_Nam.HeaderText = "Năm"
        Me.Cl_Nam.Name = "Cl_Nam"
        Me.Cl_Nam.ReadOnly = True
        '
        'Cl_Thang
        '
        Me.Cl_Thang.HeaderText = "Tháng"
        Me.Cl_Thang.Name = "Cl_Thang"
        Me.Cl_Thang.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tỉ Lệ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.HeaderText = "Số Lượt Mượn"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 102
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "Tên Thể Loại"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Dgv_ListBaoCaoThongKe
        '
        Me.Dgv_ListBaoCaoThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListBaoCaoThongKe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Cl_Thang, Me.Cl_Nam})
        Me.Dgv_ListBaoCaoThongKe.Location = New System.Drawing.Point(673, 110)
        Me.Dgv_ListBaoCaoThongKe.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgv_ListBaoCaoThongKe.Name = "Dgv_ListBaoCaoThongKe"
        Me.Dgv_ListBaoCaoThongKe.RowTemplate.Height = 33
        Me.Dgv_ListBaoCaoThongKe.Size = New System.Drawing.Size(601, 266)
        Me.Dgv_ListBaoCaoThongKe.TabIndex = 16
        '
        'Frm_LapBaoCaoThongKeSachTraTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 531)
        Me.Controls.Add(Me.Cb_Thang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Nam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dtp_NgayLap)
        Me.Controls.Add(Me.Txt_MaLapBaoCao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_LapBaoCao)
        Me.Controls.Add(Me.Dgv_ListBaoCaoThongKe)
        Me.Controls.Add(Me.Dgv_ListLapBaoCaoThongKe)
        Me.Name = "Frm_LapBaoCaoThongKeSachTraTre"
        Me.Text = "Lập Bá Cáo Thống Kê Sách Trả Trễ"
        CType(Me.Dgv_ListLapBaoCaoThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListBaoCaoThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_MaLapBaoCao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_LapBaoCao As Button
    Friend WithEvents Dgv_ListLapBaoCaoThongKe As DataGridView
    Friend WithEvents Dtp_NgayLap As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Cb_Thang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Nam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Cl_Nam As DataGridViewTextBoxColumn
    Friend WithEvents Cl_Thang As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Dgv_ListBaoCaoThongKe As DataGridView
    Friend WithEvents Cl_TenSach As DataGridViewTextBoxColumn
    Friend WithEvents Cl_NgayMuon As DataGridViewTextBoxColumn
    Friend WithEvents Cl_SoNgayTraTre As DataGridViewTextBoxColumn
End Class
