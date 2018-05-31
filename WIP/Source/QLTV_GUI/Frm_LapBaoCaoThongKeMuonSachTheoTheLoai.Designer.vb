<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_LapBaoCaoThongKeMuonSachTheoTheLoai
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Nam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cb_Thang = New System.Windows.Forms.ComboBox()
        Me.Dgv_ListLapBaoCaoThongKe = New System.Windows.Forms.DataGridView()
        Me.Cl_TenTheLoai = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Cl_SoLuotMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_TiLe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgv_ListBaoCaoThongKe = New System.Windows.Forms.DataGridView()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_Thang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cl_Nam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_TongSoLuotMuon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_LapBaoCao = New System.Windows.Forms.Button()
        Me.Txt_MaLapBaoCao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Dgv_ListLapBaoCaoThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListBaoCaoThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Năm"
        '
        'Txt_Nam
        '
        Me.Txt_Nam.Location = New System.Drawing.Point(195, 77)
        Me.Txt_Nam.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_Nam.Name = "Txt_Nam"
        Me.Txt_Nam.Size = New System.Drawing.Size(109, 22)
        Me.Txt_Nam.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tháng"
        '
        'Cb_Thang
        '
        Me.Cb_Thang.FormattingEnabled = True
        Me.Cb_Thang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.Cb_Thang.Location = New System.Drawing.Point(463, 72)
        Me.Cb_Thang.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_Thang.Name = "Cb_Thang"
        Me.Cb_Thang.Size = New System.Drawing.Size(109, 24)
        Me.Cb_Thang.TabIndex = 4
        '
        'Dgv_ListLapBaoCaoThongKe
        '
        Me.Dgv_ListLapBaoCaoThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListLapBaoCaoThongKe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cl_TenTheLoai, Me.Cl_SoLuotMuon, Me.Cl_TiLe})
        Me.Dgv_ListLapBaoCaoThongKe.Location = New System.Drawing.Point(79, 110)
        Me.Dgv_ListLapBaoCaoThongKe.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgv_ListLapBaoCaoThongKe.Name = "Dgv_ListLapBaoCaoThongKe"
        Me.Dgv_ListLapBaoCaoThongKe.RowTemplate.Height = 33
        Me.Dgv_ListLapBaoCaoThongKe.Size = New System.Drawing.Size(493, 266)
        Me.Dgv_ListLapBaoCaoThongKe.TabIndex = 5
        '
        'Cl_TenTheLoai
        '
        Me.Cl_TenTheLoai.HeaderText = "Tên Thể Loại"
        Me.Cl_TenTheLoai.Name = "Cl_TenTheLoai"
        Me.Cl_TenTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Cl_SoLuotMuon
        '
        Me.Cl_SoLuotMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cl_SoLuotMuon.HeaderText = "Số Lượt Mượn"
        Me.Cl_SoLuotMuon.Name = "Cl_SoLuotMuon"
        Me.Cl_SoLuotMuon.ReadOnly = True
        Me.Cl_SoLuotMuon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cl_SoLuotMuon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cl_SoLuotMuon.Width = 102
        '
        'Cl_TiLe
        '
        Me.Cl_TiLe.HeaderText = "Tỉ Lệ"
        Me.Cl_TiLe.Name = "Cl_TiLe"
        Me.Cl_TiLe.ReadOnly = True
        '
        'Dgv_ListBaoCaoThongKe
        '
        Me.Dgv_ListBaoCaoThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListBaoCaoThongKe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Cl_Thang, Me.Cl_Nam})
        Me.Dgv_ListBaoCaoThongKe.Location = New System.Drawing.Point(624, 110)
        Me.Dgv_ListBaoCaoThongKe.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgv_ListBaoCaoThongKe.Name = "Dgv_ListBaoCaoThongKe"
        Me.Dgv_ListBaoCaoThongKe.RowTemplate.Height = 33
        Me.Dgv_ListBaoCaoThongKe.Size = New System.Drawing.Size(493, 266)
        Me.Dgv_ListBaoCaoThongKe.TabIndex = 6
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "Tên Thể Loại"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tỉ Lệ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Cl_Thang
        '
        Me.Cl_Thang.HeaderText = "Tháng"
        Me.Cl_Thang.Name = "Cl_Thang"
        Me.Cl_Thang.ReadOnly = True
        '
        'Cl_Nam
        '
        Me.Cl_Nam.HeaderText = "Năm"
        Me.Cl_Nam.Name = "Cl_Nam"
        Me.Cl_Nam.ReadOnly = True
        '
        'Txt_TongSoLuotMuon
        '
        Me.Txt_TongSoLuotMuon.Location = New System.Drawing.Point(463, 398)
        Me.Txt_TongSoLuotMuon.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_TongSoLuotMuon.Name = "Txt_TongSoLuotMuon"
        Me.Txt_TongSoLuotMuon.ReadOnly = True
        Me.Txt_TongSoLuotMuon.Size = New System.Drawing.Size(109, 22)
        Me.Txt_TongSoLuotMuon.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 400)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tổng Số Lượt Mượn"
        '
        'Btn_LapBaoCao
        '
        Me.Btn_LapBaoCao.Location = New System.Drawing.Point(218, 456)
        Me.Btn_LapBaoCao.Name = "Btn_LapBaoCao"
        Me.Btn_LapBaoCao.Size = New System.Drawing.Size(130, 48)
        Me.Btn_LapBaoCao.TabIndex = 9
        Me.Btn_LapBaoCao.Text = "Lập Báo Cáo"
        Me.Btn_LapBaoCao.UseVisualStyleBackColor = True
        '
        'Txt_MaLapBaoCao
        '
        Me.Txt_MaLapBaoCao.Location = New System.Drawing.Point(195, 26)
        Me.Txt_MaLapBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_MaLapBaoCao.Name = "Txt_MaLapBaoCao"
        Me.Txt_MaLapBaoCao.ReadOnly = True
        Me.Txt_MaLapBaoCao.Size = New System.Drawing.Size(109, 22)
        Me.Txt_MaLapBaoCao.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mã Lập Báo Cáo"
        '
        'Frm_LapBaoCaoThongKeMuonSachTheoTheLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 531)
        Me.Controls.Add(Me.Txt_MaLapBaoCao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_LapBaoCao)
        Me.Controls.Add(Me.Txt_TongSoLuotMuon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dgv_ListBaoCaoThongKe)
        Me.Controls.Add(Me.Dgv_ListLapBaoCaoThongKe)
        Me.Controls.Add(Me.Cb_Thang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Nam)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_LapBaoCaoThongKeMuonSachTheoTheLoai"
        Me.Text = "Lập báo cáo thống kê mượn sách theo thể loại"
        CType(Me.Dgv_ListLapBaoCaoThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListBaoCaoThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Nam As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cb_Thang As ComboBox
    Friend WithEvents Dgv_ListLapBaoCaoThongKe As DataGridView
    Friend WithEvents Dgv_ListBaoCaoThongKe As DataGridView
    Friend WithEvents Txt_TongSoLuotMuon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cl_TenTheLoai As DataGridViewComboBoxColumn
    Friend WithEvents Cl_SoLuotMuon As DataGridViewTextBoxColumn
    Friend WithEvents Cl_TiLe As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Cl_Thang As DataGridViewTextBoxColumn
    Friend WithEvents Cl_Nam As DataGridViewTextBoxColumn
    Friend WithEvents Btn_LapBaoCao As Button
    Friend WithEvents Txt_MaLapBaoCao As TextBox
    Friend WithEvents Label4 As Label
End Class
