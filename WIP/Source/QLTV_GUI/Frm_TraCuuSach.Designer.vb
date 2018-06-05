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
        Me.Dgv_ListTraCuu = New System.Windows.Forms.DataGridView()
        Me.Txt_TenSach = New System.Windows.Forms.TextBox()
        Me.Btn_TraCuu = New System.Windows.Forms.Button()
        CType(Me.Dgv_ListTraCuu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_ListTraCuu
        '
        Me.Dgv_ListTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListTraCuu.Location = New System.Drawing.Point(76, 128)
        Me.Dgv_ListTraCuu.Name = "Dgv_ListTraCuu"
        Me.Dgv_ListTraCuu.RowTemplate.Height = 24
        Me.Dgv_ListTraCuu.Size = New System.Drawing.Size(775, 232)
        Me.Dgv_ListTraCuu.TabIndex = 0
        '
        'Txt_TenSach
        '
        Me.Txt_TenSach.Location = New System.Drawing.Point(155, 70)
        Me.Txt_TenSach.Name = "Txt_TenSach"
        Me.Txt_TenSach.Size = New System.Drawing.Size(111, 22)
        Me.Txt_TenSach.TabIndex = 1
        '
        'Btn_TraCuu
        '
        Me.Btn_TraCuu.Location = New System.Drawing.Point(230, 392)
        Me.Btn_TraCuu.Name = "Btn_TraCuu"
        Me.Btn_TraCuu.Size = New System.Drawing.Size(143, 70)
        Me.Btn_TraCuu.TabIndex = 2
        Me.Btn_TraCuu.Text = "Tra Cứu"
        Me.Btn_TraCuu.UseVisualStyleBackColor = True
        '
        'Frm_TraCuuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 511)
        Me.Controls.Add(Me.Btn_TraCuu)
        Me.Controls.Add(Me.Txt_TenSach)
        Me.Controls.Add(Me.Dgv_ListTraCuu)
        Me.Name = "Frm_TraCuuSach"
        Me.Text = "Tra Cứu Sách"
        CType(Me.Dgv_ListTraCuu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_ListTraCuu As DataGridView
    Friend WithEvents Txt_TenSach As TextBox
    Friend WithEvents Btn_TraCuu As Button
End Class
