<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Close
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Close))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.i = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_no = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_yes = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Yellow
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(319, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(233, 40)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "THÔNG BÁO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 48)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.DarkGreen
        Me.BunifuImageButton1.Image = Global.QLTV_GUI.My.Resources.Resources.icons8_about_30
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(256, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(57, 45)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'i
        '
        Me.i.AutoSize = True
        Me.i.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i.ForeColor = System.Drawing.Color.Black
        Me.i.Location = New System.Drawing.Point(53, 81)
        Me.i.Name = "i"
        Me.i.Size = New System.Drawing.Size(549, 41)
        Me.i.TabIndex = 1
        Me.i.Text = "BẠN CÓ MUỐN THOÁT KHÔNG?"
        '
        'btn_no
        '
        Me.btn_no.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_no.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_no.BorderRadius = 7
        Me.btn_no.ButtonText = "NO"
        Me.btn_no.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_no.DisabledColor = System.Drawing.Color.Gray
        Me.btn_no.ForeColor = System.Drawing.Color.Black
        Me.btn_no.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_no.Iconimage = CType(resources.GetObject("btn_no.Iconimage"), System.Drawing.Image)
        Me.btn_no.Iconimage_right = Nothing
        Me.btn_no.Iconimage_right_Selected = Nothing
        Me.btn_no.Iconimage_Selected = Nothing
        Me.btn_no.IconMarginLeft = 0
        Me.btn_no.IconMarginRight = 0
        Me.btn_no.IconRightVisible = False
        Me.btn_no.IconRightZoom = 0R
        Me.btn_no.IconVisible = False
        Me.btn_no.IconZoom = 90.0R
        Me.btn_no.IsTab = False
        Me.btn_no.Location = New System.Drawing.Point(461, 151)
        Me.btn_no.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_no.Name = "btn_no"
        Me.btn_no.Normalcolor = System.Drawing.Color.SeaGreen
        Me.btn_no.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_no.OnHoverTextColor = System.Drawing.Color.DarkRed
        Me.btn_no.selected = False
        Me.btn_no.Size = New System.Drawing.Size(145, 40)
        Me.btn_no.TabIndex = 4
        Me.btn_no.Text = "NO"
        Me.btn_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_no.Textcolor = System.Drawing.Color.Yellow
        Me.btn_no.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_yes
        '
        Me.btn_yes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_yes.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_yes.BorderRadius = 7
        Me.btn_yes.ButtonText = "YES"
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
        Me.btn_yes.Location = New System.Drawing.Point(226, 151)
        Me.btn_yes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_yes.Name = "btn_yes"
        Me.btn_yes.Normalcolor = System.Drawing.Color.SeaGreen
        Me.btn_yes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_yes.OnHoverTextColor = System.Drawing.Color.DarkRed
        Me.btn_yes.selected = False
        Me.btn_yes.Size = New System.Drawing.Size(145, 40)
        Me.btn_yes.TabIndex = 3
        Me.btn_yes.Text = "YES"
        Me.btn_yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_yes.Textcolor = System.Drawing.Color.Yellow
        Me.btn_yes.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Frm_Close
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(834, 218)
        Me.Controls.Add(Me.btn_no)
        Me.Controls.Add(Me.btn_yes)
        Me.Controls.Add(Me.i)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Close"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Close"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_no As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_yes As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Public WithEvents i As Bunifu.Framework.UI.BunifuCustomLabel
End Class
