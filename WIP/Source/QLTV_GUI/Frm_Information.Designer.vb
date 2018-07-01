<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Information
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Information))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DoubleBitmapControl1 = New BunifuAnimatorNS.DoubleBitmapControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.form = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_yes = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.m = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'DoubleBitmapControl1
        '
        Me.DoubleBitmapControl1.Location = New System.Drawing.Point(578, 311)
        Me.DoubleBitmapControl1.Name = "DoubleBitmapControl1"
        Me.DoubleBitmapControl1.Size = New System.Drawing.Size(75, 23)
        Me.DoubleBitmapControl1.TabIndex = 0
        Me.DoubleBitmapControl1.Text = "DoubleBitmapControl1"
        Me.DoubleBitmapControl1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.form)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 48)
        Me.Panel1.TabIndex = 1
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.DarkGreen
        Me.BunifuImageButton1.Image = Global.QLTV_GUI.My.Resources.Resources.icons8_about_30
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(226, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(57, 45)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'form
        '
        Me.form.AutoSize = True
        Me.form.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.form.ForeColor = System.Drawing.Color.Yellow
        Me.form.Location = New System.Drawing.Point(289, 9)
        Me.form.Name = "form"
        Me.form.Size = New System.Drawing.Size(211, 37)
        Me.form.TabIndex = 0
        Me.form.Text = "THÔNG BÁO"
        Me.form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_yes
        '
        Me.btn_yes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_yes.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_yes.BorderRadius = 7
        Me.btn_yes.ButtonText = "OK"
        Me.btn_yes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_yes.DisabledColor = System.Drawing.Color.Gray
        Me.btn_yes.ForeColor = System.Drawing.Color.Black
        Me.btn_yes.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_yes.Iconimage = CType(resources.GetObject("btn_yes.Iconimage"), System.Drawing.Image)
        Me.btn_yes.Iconimage_right = Nothing
        Me.btn_yes.Iconimage_right_Selected = Nothing
        Me.btn_yes.Iconimage_Selected = Nothing
        Me.btn_yes.IconMarginLeft = 0
        Me.btn_yes.IconMarginRight = 0
        Me.btn_yes.IconRightVisible = False
        Me.btn_yes.IconRightZoom = 0R
        Me.btn_yes.IconVisible = False
        Me.btn_yes.IconZoom = 90.0R
        Me.btn_yes.IsTab = False
        Me.btn_yes.Location = New System.Drawing.Point(296, 131)
        Me.btn_yes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_yes.Name = "btn_yes"
        Me.btn_yes.Normalcolor = System.Drawing.Color.SeaGreen
        Me.btn_yes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_yes.OnHoverTextColor = System.Drawing.Color.DarkRed
        Me.btn_yes.selected = False
        Me.btn_yes.Size = New System.Drawing.Size(159, 60)
        Me.btn_yes.TabIndex = 4
        Me.btn_yes.Text = "OK"
        Me.btn_yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_yes.Textcolor = System.Drawing.Color.Yellow
        Me.btn_yes.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'm
        '
        Me.m.AutoSize = True
        Me.m.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m.ForeColor = System.Drawing.Color.Black
        Me.m.Location = New System.Drawing.Point(60, 81)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(0, 33)
        Me.m.TabIndex = 5
        '
        'Frm_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(742, 205)
        Me.Controls.Add(Me.m)
        Me.Controls.Add(Me.btn_yes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DoubleBitmapControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DoubleBitmapControl1 As BunifuAnimatorNS.DoubleBitmapControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents form As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_yes As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents m As Bunifu.Framework.UI.BunifuCustomLabel
End Class
