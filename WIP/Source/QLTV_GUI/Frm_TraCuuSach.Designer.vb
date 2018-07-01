<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TraCuuSach
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_TraCuuSach))
        Me.DoubleBitmapControl1 = New BunifuAnimatorNS.DoubleBitmapControl()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Dgv_ListTraCuu = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Txt_TenSach = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Btn_TraCuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.Dgv_ListTraCuu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DoubleBitmapControl1
        '
        Me.DoubleBitmapControl1.Location = New System.Drawing.Point(293, 127)
        Me.DoubleBitmapControl1.Name = "DoubleBitmapControl1"
        Me.DoubleBitmapControl1.Size = New System.Drawing.Size(75, 23)
        Me.DoubleBitmapControl1.TabIndex = 0
        Me.DoubleBitmapControl1.Text = "DoubleBitmapControl1"
        Me.DoubleBitmapControl1.Visible = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Dgv_ListTraCuu
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListTraCuu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ListTraCuu.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListTraCuu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListTraCuu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListTraCuu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv_ListTraCuu.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_ListTraCuu.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv_ListTraCuu.DoubleBuffered = True
        Me.Dgv_ListTraCuu.EnableHeadersVisualStyles = False
        Me.Dgv_ListTraCuu.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListTraCuu.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListTraCuu.Location = New System.Drawing.Point(33, 43)
        Me.Dgv_ListTraCuu.Name = "Dgv_ListTraCuu"
        Me.Dgv_ListTraCuu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_ListTraCuu.RowHeadersWidth = 20
        Me.Dgv_ListTraCuu.RowTemplate.Height = 28
        Me.Dgv_ListTraCuu.Size = New System.Drawing.Size(1724, 455)
        Me.Dgv_ListTraCuu.TabIndex = 167
        '
        'Txt_TenSach
        '
        Me.Txt_TenSach.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TenSach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TenSach.Location = New System.Drawing.Point(206, 122)
        Me.Txt_TenSach.MaximumSize = New System.Drawing.Size(282, 44)
        Me.Txt_TenSach.Multiline = True
        Me.Txt_TenSach.Name = "Txt_TenSach"
        Me.Txt_TenSach.Size = New System.Drawing.Size(282, 44)
        Me.Txt_TenSach.TabIndex = 161
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1815, 16)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 158
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label6.Location = New System.Drawing.Point(13, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(328, 70)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Tra Cứu Sách"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(3, 72)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1854, 26)
        Me.BunifuSeparator1.TabIndex = 154
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Btn_TraCuu
        '
        Me.Btn_TraCuu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_TraCuu.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_TraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_TraCuu.BorderRadius = 7
        Me.Btn_TraCuu.ButtonText = "Tra Cứu"
        Me.Btn_TraCuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_TraCuu.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_TraCuu.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_TraCuu.Iconimage = CType(resources.GetObject("Btn_TraCuu.Iconimage"), System.Drawing.Image)
        Me.Btn_TraCuu.Iconimage_right = Nothing
        Me.Btn_TraCuu.Iconimage_right_Selected = Nothing
        Me.Btn_TraCuu.Iconimage_Selected = Nothing
        Me.Btn_TraCuu.IconMarginLeft = 0
        Me.Btn_TraCuu.IconMarginRight = 0
        Me.Btn_TraCuu.IconRightVisible = True
        Me.Btn_TraCuu.IconRightZoom = 0R
        Me.Btn_TraCuu.IconVisible = False
        Me.Btn_TraCuu.IconZoom = 90.0R
        Me.Btn_TraCuu.IsTab = False
        Me.Btn_TraCuu.Location = New System.Drawing.Point(825, 782)
        Me.Btn_TraCuu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_TraCuu.Name = "Btn_TraCuu"
        Me.Btn_TraCuu.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_TraCuu.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_TraCuu.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_TraCuu.selected = False
        Me.Btn_TraCuu.Size = New System.Drawing.Size(247, 74)
        Me.Btn_TraCuu.TabIndex = 152
        Me.Btn_TraCuu.Text = "Tra Cứu"
        Me.Btn_TraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_TraCuu.Textcolor = System.Drawing.Color.White
        Me.Btn_TraCuu.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label
        '
        Me.Label.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label.Location = New System.Drawing.Point(61, 120)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(139, 53)
        Me.Label.TabIndex = 144
        Me.Label.Text = "Nhập"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(544, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 27)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Nhập (Mã Sách, Tên Sách, Thể Loại Sách, Tên Tác Giả,...)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv_ListTraCuu)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox1.Location = New System.Drawing.Point(47, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1781, 523)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kết quả tra cứu"
        '
        'Frm_TraCuuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1882, 870)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_TenSach)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Btn_TraCuu)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.DoubleBitmapControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_TraCuuSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_TraCuuSach"
        CType(Me.Dgv_ListTraCuu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DoubleBitmapControl1 As BunifuAnimatorNS.DoubleBitmapControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Dgv_ListTraCuu As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Txt_TenSach As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Btn_TraCuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label As Label
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GroupBox1 As GroupBox
End Class
