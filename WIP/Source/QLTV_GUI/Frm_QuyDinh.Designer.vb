<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_QuyDinh
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
        Me.Txt_TuoiToiThieu = New System.Windows.Forms.TextBox()
        Me.Txt_TuoiToiDa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_CapNhap = New System.Windows.Forms.Button()
        Me.Txt_ThoiGianSuDung = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tuổi tối thiểu"
        '
        'Txt_TuoiToiThieu
        '
        Me.Txt_TuoiToiThieu.Location = New System.Drawing.Point(341, 72)
        Me.Txt_TuoiToiThieu.Name = "Txt_TuoiToiThieu"
        Me.Txt_TuoiToiThieu.Size = New System.Drawing.Size(227, 26)
        Me.Txt_TuoiToiThieu.TabIndex = 1
        '
        'Txt_TuoiToiDa
        '
        Me.Txt_TuoiToiDa.Location = New System.Drawing.Point(341, 157)
        Me.Txt_TuoiToiDa.Name = "Txt_TuoiToiDa"
        Me.Txt_TuoiToiDa.Size = New System.Drawing.Size(227, 26)
        Me.Txt_TuoiToiDa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tuổi tối đa"
        '
        'Btn_CapNhap
        '
        Me.Btn_CapNhap.Location = New System.Drawing.Point(289, 327)
        Me.Btn_CapNhap.Name = "Btn_CapNhap"
        Me.Btn_CapNhap.Size = New System.Drawing.Size(202, 62)
        Me.Btn_CapNhap.TabIndex = 4
        Me.Btn_CapNhap.Text = "Cập Nhập"
        Me.Btn_CapNhap.UseVisualStyleBackColor = True
        '
        'Txt_ThoiGianSuDung
        '
        Me.Txt_ThoiGianSuDung.Location = New System.Drawing.Point(341, 224)
        Me.Txt_ThoiGianSuDung.Name = "Txt_ThoiGianSuDung"
        Me.Txt_ThoiGianSuDung.Size = New System.Drawing.Size(227, 26)
        Me.Txt_ThoiGianSuDung.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Thời gian sử dụng"
        '
        'Frm_QuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Txt_ThoiGianSuDung)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_CapNhap)
        Me.Controls.Add(Me.Txt_TuoiToiDa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_TuoiToiThieu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_QuyDinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quy Định"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_TuoiToiThieu As TextBox
    Friend WithEvents Txt_TuoiToiDa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_CapNhap As Button
    Friend WithEvents Txt_ThoiGianSuDung As TextBox
    Friend WithEvents Label3 As Label
End Class
