<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Main
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
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.Pn_Menu = New System.Windows.Forms.Panel()
        Me.btn_GioiThieu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuMain = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuDocGia = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Menu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PanelAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Pn_Main = New System.Windows.Forms.Panel()
        Me.Tile_BaoCaoSachTraTre = New MetroFramework.Controls.MetroTile()
        Me.Tile_BaoCaoTheoTheLoai = New MetroFramework.Controls.MetroTile()
        Me.Tile_TraCuuSach = New MetroFramework.Controls.MetroTile()
        Me.Tile_NhanTraSach = New MetroFramework.Controls.MetroTile()
        Me.Tile_LapPhieuMuonSach = New MetroFramework.Controls.MetroTile()
        Me.Tile_QuanLiTheLoaiSach = New MetroFramework.Controls.MetroTile()
        Me.Tile_ThemTheLoaiSach = New MetroFramework.Controls.MetroTile()
        Me.Tile_QuanLiTacGia = New MetroFramework.Controls.MetroTile()
        Me.Tile_ThemTacGia = New MetroFramework.Controls.MetroTile()
        Me.Tile_QuanLiSach = New MetroFramework.Controls.MetroTile()
        Me.Tile_ThemSach = New MetroFramework.Controls.MetroTile()
        Me.Tile_QuanLiLoaiDocGia = New MetroFramework.Controls.MetroTile()
        Me.Tile_ThemLoaiDocGia = New MetroFramework.Controls.MetroTile()
        Me.Tile_QuanLiDocGia = New MetroFramework.Controls.MetroTile()
        Me.Tile_QuyDinh = New MetroFramework.Controls.MetroTile()
        Me.Tile_ThemDocGia = New MetroFramework.Controls.MetroTile()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PanelAnimator1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Pn_Menu.SuspendLayout()
        CType(Me.Btn_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pn_Main.SuspendLayout()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pn_Menu
        '
        Me.Pn_Menu.BackColor = System.Drawing.Color.SeaGreen
        Me.Pn_Menu.Controls.Add(Me.btn_GioiThieu)
        Me.Pn_Menu.Controls.Add(Me.BunifuFlatButton1)
        Me.Pn_Menu.Controls.Add(Me.MenuMain)
        Me.Pn_Menu.Controls.Add(Me.MenuDocGia)
        Me.Pn_Menu.Controls.Add(Me.Btn_Menu)
        Me.PanelAnimator1.SetDecoration(Me.Pn_Menu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Pn_Menu, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pn_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Pn_Menu.Name = "Pn_Menu"
        Me.Pn_Menu.Size = New System.Drawing.Size(240, 1094)
        Me.Pn_Menu.TabIndex = 1
        '
        'btn_GioiThieu
        '
        Me.btn_GioiThieu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_GioiThieu.BackColor = System.Drawing.Color.Transparent
        Me.btn_GioiThieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_GioiThieu.BorderRadius = 7
        Me.btn_GioiThieu.ButtonText = "Giới Thiệu"
        Me.btn_GioiThieu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator1.SetDecoration(Me.btn_GioiThieu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.btn_GioiThieu, BunifuAnimatorNS.DecorationType.None)
        Me.btn_GioiThieu.DisabledColor = System.Drawing.Color.Gray
        Me.btn_GioiThieu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GioiThieu.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_GioiThieu.Iconimage = Global.QLTV_GUI.My.Resources.Resources.icons8_info_50
        Me.btn_GioiThieu.Iconimage_right = Nothing
        Me.btn_GioiThieu.Iconimage_right_Selected = Nothing
        Me.btn_GioiThieu.Iconimage_Selected = Nothing
        Me.btn_GioiThieu.IconMarginLeft = 0
        Me.btn_GioiThieu.IconMarginRight = 0
        Me.btn_GioiThieu.IconRightVisible = False
        Me.btn_GioiThieu.IconRightZoom = 0R
        Me.btn_GioiThieu.IconVisible = True
        Me.btn_GioiThieu.IconZoom = 50.0R
        Me.btn_GioiThieu.IsTab = False
        Me.btn_GioiThieu.Location = New System.Drawing.Point(7, 345)
        Me.btn_GioiThieu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_GioiThieu.Name = "btn_GioiThieu"
        Me.btn_GioiThieu.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_GioiThieu.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_GioiThieu.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_GioiThieu.selected = False
        Me.btn_GioiThieu.Size = New System.Drawing.Size(220, 46)
        Me.btn_GioiThieu.TabIndex = 12
        Me.btn_GioiThieu.Text = "Giới Thiệu"
        Me.btn_GioiThieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GioiThieu.Textcolor = System.Drawing.Color.White
        Me.btn_GioiThieu.TextFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "Trợ Giúp"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.QLTV_GUI.My.Resources.Resources.icons8_help_50
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(3, 275)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(224, 56)
        Me.BunifuFlatButton1.TabIndex = 11
        Me.BunifuFlatButton1.Text = "Trợ Giúp"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuMain
        '
        Me.MenuMain.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MenuMain.BackColor = System.Drawing.Color.Transparent
        Me.MenuMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuMain.BorderRadius = 7
        Me.MenuMain.ButtonText = " Trang Chủ"
        Me.MenuMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator1.SetDecoration(Me.MenuMain, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.MenuMain, BunifuAnimatorNS.DecorationType.None)
        Me.MenuMain.DisabledColor = System.Drawing.Color.Gray
        Me.MenuMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuMain.Iconcolor = System.Drawing.Color.Transparent
        Me.MenuMain.Iconimage = Global.QLTV_GUI.My.Resources.Resources.icons8_home_501
        Me.MenuMain.Iconimage_right = Nothing
        Me.MenuMain.Iconimage_right_Selected = Nothing
        Me.MenuMain.Iconimage_Selected = Nothing
        Me.MenuMain.IconMarginLeft = 0
        Me.MenuMain.IconMarginRight = 0
        Me.MenuMain.IconRightVisible = False
        Me.MenuMain.IconRightZoom = 0R
        Me.MenuMain.IconVisible = True
        Me.MenuMain.IconZoom = 50.0R
        Me.MenuMain.IsTab = False
        Me.MenuMain.Location = New System.Drawing.Point(4, 145)
        Me.MenuMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MenuMain.Name = "MenuMain"
        Me.MenuMain.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuMain.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuMain.OnHoverTextColor = System.Drawing.Color.White
        Me.MenuMain.selected = False
        Me.MenuMain.Size = New System.Drawing.Size(223, 55)
        Me.MenuMain.TabIndex = 8
        Me.MenuMain.Text = " Trang Chủ"
        Me.MenuMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MenuMain.Textcolor = System.Drawing.Color.White
        Me.MenuMain.TextFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MenuDocGia
        '
        Me.MenuDocGia.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuDocGia.BackColor = System.Drawing.Color.Transparent
        Me.MenuDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuDocGia.BorderRadius = 7
        Me.MenuDocGia.ButtonText = "Đăng Xuất"
        Me.MenuDocGia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator1.SetDecoration(Me.MenuDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.MenuDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.MenuDocGia.DisabledColor = System.Drawing.Color.Gray
        Me.MenuDocGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDocGia.Iconcolor = System.Drawing.Color.Transparent
        Me.MenuDocGia.Iconimage = Global.QLTV_GUI.My.Resources.Resources.icons8_exit_50
        Me.MenuDocGia.Iconimage_right = Nothing
        Me.MenuDocGia.Iconimage_right_Selected = Nothing
        Me.MenuDocGia.Iconimage_Selected = Nothing
        Me.MenuDocGia.IconMarginLeft = 0
        Me.MenuDocGia.IconMarginRight = 0
        Me.MenuDocGia.IconRightVisible = False
        Me.MenuDocGia.IconRightZoom = 0R
        Me.MenuDocGia.IconVisible = True
        Me.MenuDocGia.IconZoom = 50.0R
        Me.MenuDocGia.IsTab = False
        Me.MenuDocGia.Location = New System.Drawing.Point(7, 210)
        Me.MenuDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MenuDocGia.Name = "MenuDocGia"
        Me.MenuDocGia.Normalcolor = System.Drawing.Color.Transparent
        Me.MenuDocGia.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuDocGia.OnHoverTextColor = System.Drawing.Color.White
        Me.MenuDocGia.selected = False
        Me.MenuDocGia.Size = New System.Drawing.Size(220, 55)
        Me.MenuDocGia.TabIndex = 7
        Me.MenuDocGia.Text = "Đăng Xuất"
        Me.MenuDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MenuDocGia.Textcolor = System.Drawing.Color.White
        Me.MenuDocGia.TextFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Menu
        '
        Me.Btn_Menu.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator1.SetDecoration(Me.Btn_Menu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Btn_Menu, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Menu.Image = Global.QLTV_GUI.My.Resources.Resources.icons8_menu_32
        Me.Btn_Menu.ImageActive = Nothing
        Me.Btn_Menu.Location = New System.Drawing.Point(172, 13)
        Me.Btn_Menu.Name = "Btn_Menu"
        Me.Btn_Menu.Size = New System.Drawing.Size(47, 50)
        Me.Btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Menu.TabIndex = 1
        Me.Btn_Menu.TabStop = False
        Me.Btn_Menu.Zoom = 10
        '
        'PanelAnimator
        '
        Me.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.PanelAnimator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 20
        Animation2.Padding = New System.Windows.Forms.Padding(30)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.PanelAnimator.DefaultAnimation = Animation2
        '
        'Pn_Main
        '
        Me.Pn_Main.AutoSize = True
        Me.Pn_Main.Controls.Add(Me.Tile_BaoCaoSachTraTre)
        Me.Pn_Main.Controls.Add(Me.Tile_BaoCaoTheoTheLoai)
        Me.Pn_Main.Controls.Add(Me.Tile_TraCuuSach)
        Me.Pn_Main.Controls.Add(Me.Tile_NhanTraSach)
        Me.Pn_Main.Controls.Add(Me.Tile_LapPhieuMuonSach)
        Me.Pn_Main.Controls.Add(Me.Tile_QuanLiTheLoaiSach)
        Me.Pn_Main.Controls.Add(Me.Tile_ThemTheLoaiSach)
        Me.Pn_Main.Controls.Add(Me.Tile_QuanLiTacGia)
        Me.Pn_Main.Controls.Add(Me.Tile_ThemTacGia)
        Me.Pn_Main.Controls.Add(Me.Tile_QuanLiSach)
        Me.Pn_Main.Controls.Add(Me.Tile_ThemSach)
        Me.Pn_Main.Controls.Add(Me.Tile_QuanLiLoaiDocGia)
        Me.Pn_Main.Controls.Add(Me.Tile_ThemLoaiDocGia)
        Me.Pn_Main.Controls.Add(Me.Tile_QuanLiDocGia)
        Me.Pn_Main.Controls.Add(Me.Tile_QuyDinh)
        Me.Pn_Main.Controls.Add(Me.Tile_ThemDocGia)
        Me.Pn_Main.Controls.Add(Me.Btn_Close)
        Me.Pn_Main.Controls.Add(Me.Label3)
        Me.Pn_Main.Controls.Add(Me.BunifuSeparator1)
        Me.PanelAnimator1.SetDecoration(Me.Pn_Main, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Pn_Main, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Main.Location = New System.Drawing.Point(240, 0)
        Me.Pn_Main.Name = "Pn_Main"
        Me.Pn_Main.Size = New System.Drawing.Size(1565, 1094)
        Me.Pn_Main.TabIndex = 2
        '
        'Tile_BaoCaoSachTraTre
        '
        Me.Tile_BaoCaoSachTraTre.ActiveControl = Nothing
        Me.Tile_BaoCaoSachTraTre.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_BaoCaoSachTraTre, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_BaoCaoSachTraTre, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_BaoCaoSachTraTre.ForeColor = System.Drawing.Color.White
        Me.Tile_BaoCaoSachTraTre.Location = New System.Drawing.Point(51, 811)
        Me.Tile_BaoCaoSachTraTre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_BaoCaoSachTraTre.Name = "Tile_BaoCaoSachTraTre"
        Me.Tile_BaoCaoSachTraTre.Size = New System.Drawing.Size(438, 220)
        Me.Tile_BaoCaoSachTraTre.TabIndex = 60
        Me.Tile_BaoCaoSachTraTre.Text = "Báo Cáo Thống Kê Sách Trả Trễ"
        Me.Tile_BaoCaoSachTraTre.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_edit_graph_report_80
        Me.Tile_BaoCaoSachTraTre.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_BaoCaoSachTraTre.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_BaoCaoSachTraTre.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_BaoCaoSachTraTre.UseCustomBackColor = True
        Me.Tile_BaoCaoSachTraTre.UseCustomForeColor = True
        Me.Tile_BaoCaoSachTraTre.UseSelectable = True
        Me.Tile_BaoCaoSachTraTre.UseStyleColors = True
        Me.Tile_BaoCaoSachTraTre.UseTileImage = True
        '
        'Tile_BaoCaoTheoTheLoai
        '
        Me.Tile_BaoCaoTheoTheLoai.ActiveControl = Nothing
        Me.Tile_BaoCaoTheoTheLoai.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_BaoCaoTheoTheLoai, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_BaoCaoTheoTheLoai, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_BaoCaoTheoTheLoai.ForeColor = System.Drawing.Color.White
        Me.Tile_BaoCaoTheoTheLoai.Location = New System.Drawing.Point(51, 581)
        Me.Tile_BaoCaoTheoTheLoai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_BaoCaoTheoTheLoai.Name = "Tile_BaoCaoTheoTheLoai"
        Me.Tile_BaoCaoTheoTheLoai.Size = New System.Drawing.Size(438, 220)
        Me.Tile_BaoCaoTheoTheLoai.TabIndex = 59
        Me.Tile_BaoCaoTheoTheLoai.Text = "Báo Cáo Thống Kê Theo Thể Loại"
        Me.Tile_BaoCaoTheoTheLoai.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_pie_chart_80
        Me.Tile_BaoCaoTheoTheLoai.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_BaoCaoTheoTheLoai.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_BaoCaoTheoTheLoai.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_BaoCaoTheoTheLoai.UseCustomBackColor = True
        Me.Tile_BaoCaoTheoTheLoai.UseCustomForeColor = True
        Me.Tile_BaoCaoTheoTheLoai.UseSelectable = True
        Me.Tile_BaoCaoTheoTheLoai.UseStyleColors = True
        Me.Tile_BaoCaoTheoTheLoai.UseTileImage = True
        '
        'Tile_TraCuuSach
        '
        Me.Tile_TraCuuSach.ActiveControl = Nothing
        Me.Tile_TraCuuSach.BackColor = System.Drawing.Color.SeaGreen
        Me.Tile_TraCuuSach.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelAnimator1.SetDecoration(Me.Tile_TraCuuSach, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_TraCuuSach, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_TraCuuSach.ForeColor = System.Drawing.Color.White
        Me.Tile_TraCuuSach.Location = New System.Drawing.Point(551, 811)
        Me.Tile_TraCuuSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_TraCuuSach.Name = "Tile_TraCuuSach"
        Me.Tile_TraCuuSach.Size = New System.Drawing.Size(628, 220)
        Me.Tile_TraCuuSach.TabIndex = 58
        Me.Tile_TraCuuSach.Text = "Tra Cứu Sách"
        Me.Tile_TraCuuSach.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_google_web_search_80
        Me.Tile_TraCuuSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_TraCuuSach.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_TraCuuSach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_TraCuuSach.UseCustomBackColor = True
        Me.Tile_TraCuuSach.UseCustomForeColor = True
        Me.Tile_TraCuuSach.UseSelectable = True
        Me.Tile_TraCuuSach.UseStyleColors = True
        Me.Tile_TraCuuSach.UseTileImage = True
        '
        'Tile_NhanTraSach
        '
        Me.Tile_NhanTraSach.ActiveControl = Nothing
        Me.Tile_NhanTraSach.BackColor = System.Drawing.Color.SeaGreen
        Me.Tile_NhanTraSach.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelAnimator1.SetDecoration(Me.Tile_NhanTraSach, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_NhanTraSach, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_NhanTraSach.ForeColor = System.Drawing.Color.White
        Me.Tile_NhanTraSach.Location = New System.Drawing.Point(869, 581)
        Me.Tile_NhanTraSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_NhanTraSach.Name = "Tile_NhanTraSach"
        Me.Tile_NhanTraSach.Size = New System.Drawing.Size(310, 220)
        Me.Tile_NhanTraSach.TabIndex = 55
        Me.Tile_NhanTraSach.Text = "Lập Phiếu Trả Sách"
        Me.Tile_NhanTraSach.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_report_card_80
        Me.Tile_NhanTraSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_NhanTraSach.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_NhanTraSach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_NhanTraSach.UseCustomBackColor = True
        Me.Tile_NhanTraSach.UseCustomForeColor = True
        Me.Tile_NhanTraSach.UseSelectable = True
        Me.Tile_NhanTraSach.UseStyleColors = True
        Me.Tile_NhanTraSach.UseTileImage = True
        '
        'Tile_LapPhieuMuonSach
        '
        Me.Tile_LapPhieuMuonSach.ActiveControl = Nothing
        Me.Tile_LapPhieuMuonSach.BackColor = System.Drawing.Color.SeaGreen
        Me.Tile_LapPhieuMuonSach.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelAnimator1.SetDecoration(Me.Tile_LapPhieuMuonSach, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_LapPhieuMuonSach, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_LapPhieuMuonSach.ForeColor = System.Drawing.Color.White
        Me.Tile_LapPhieuMuonSach.Location = New System.Drawing.Point(551, 581)
        Me.Tile_LapPhieuMuonSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_LapPhieuMuonSach.Name = "Tile_LapPhieuMuonSach"
        Me.Tile_LapPhieuMuonSach.Size = New System.Drawing.Size(310, 220)
        Me.Tile_LapPhieuMuonSach.TabIndex = 54
        Me.Tile_LapPhieuMuonSach.Text = "Lập Phiếu Mượn Sách"
        Me.Tile_LapPhieuMuonSach.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_compose_80
        Me.Tile_LapPhieuMuonSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_LapPhieuMuonSach.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_LapPhieuMuonSach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_LapPhieuMuonSach.UseCustomBackColor = True
        Me.Tile_LapPhieuMuonSach.UseCustomForeColor = True
        Me.Tile_LapPhieuMuonSach.UseSelectable = True
        Me.Tile_LapPhieuMuonSach.UseStyleColors = True
        Me.Tile_LapPhieuMuonSach.UseTileImage = True
        '
        'Tile_QuanLiTheLoaiSach
        '
        Me.Tile_QuanLiTheLoaiSach.ActiveControl = Nothing
        Me.Tile_QuanLiTheLoaiSach.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_QuanLiTheLoaiSach, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_QuanLiTheLoaiSach, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_QuanLiTheLoaiSach.ForeColor = System.Drawing.Color.White
        Me.Tile_QuanLiTheLoaiSach.Location = New System.Drawing.Point(1147, 318)
        Me.Tile_QuanLiTheLoaiSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_QuanLiTheLoaiSach.Name = "Tile_QuanLiTheLoaiSach"
        Me.Tile_QuanLiTheLoaiSach.Size = New System.Drawing.Size(328, 220)
        Me.Tile_QuanLiTheLoaiSach.TabIndex = 51
        Me.Tile_QuanLiTheLoaiSach.Text = "Quản Lí Thể Loại Sách"
        Me.Tile_QuanLiTheLoaiSach.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_kindle_80
        Me.Tile_QuanLiTheLoaiSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_QuanLiTheLoaiSach.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_QuanLiTheLoaiSach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_QuanLiTheLoaiSach.UseCustomBackColor = True
        Me.Tile_QuanLiTheLoaiSach.UseCustomForeColor = True
        Me.Tile_QuanLiTheLoaiSach.UseSelectable = True
        Me.Tile_QuanLiTheLoaiSach.UseStyleColors = True
        Me.Tile_QuanLiTheLoaiSach.UseTileImage = True
        '
        'Tile_ThemTheLoaiSach
        '
        Me.Tile_ThemTheLoaiSach.ActiveControl = Nothing
        Me.Tile_ThemTheLoaiSach.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_ThemTheLoaiSach, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_ThemTheLoaiSach, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_ThemTheLoaiSach.ForeColor = System.Drawing.Color.White
        Me.Tile_ThemTheLoaiSach.Location = New System.Drawing.Point(1147, 88)
        Me.Tile_ThemTheLoaiSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_ThemTheLoaiSach.Name = "Tile_ThemTheLoaiSach"
        Me.Tile_ThemTheLoaiSach.Size = New System.Drawing.Size(328, 220)
        Me.Tile_ThemTheLoaiSach.TabIndex = 50
        Me.Tile_ThemTheLoaiSach.Text = "Thêm Thể Loại Sách"
        Me.Tile_ThemTheLoaiSach.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_abc_80
        Me.Tile_ThemTheLoaiSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_ThemTheLoaiSach.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_ThemTheLoaiSach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_ThemTheLoaiSach.UseCustomBackColor = True
        Me.Tile_ThemTheLoaiSach.UseCustomForeColor = True
        Me.Tile_ThemTheLoaiSach.UseSelectable = True
        Me.Tile_ThemTheLoaiSach.UseStyleColors = True
        Me.Tile_ThemTheLoaiSach.UseTileImage = True
        '
        'Tile_QuanLiTacGia
        '
        Me.Tile_QuanLiTacGia.ActiveControl = Nothing
        Me.Tile_QuanLiTacGia.BackColor = System.Drawing.Color.SeaGreen
        Me.Tile_QuanLiTacGia.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelAnimator1.SetDecoration(Me.Tile_QuanLiTacGia, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_QuanLiTacGia, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_QuanLiTacGia.ForeColor = System.Drawing.Color.White
        Me.Tile_QuanLiTacGia.Location = New System.Drawing.Point(877, 318)
        Me.Tile_QuanLiTacGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_QuanLiTacGia.Name = "Tile_QuanLiTacGia"
        Me.Tile_QuanLiTacGia.Size = New System.Drawing.Size(262, 220)
        Me.Tile_QuanLiTacGia.TabIndex = 49
        Me.Tile_QuanLiTacGia.Text = "Quản Lí Tác Giả"
        Me.Tile_QuanLiTacGia.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_applicant_80__1_
        Me.Tile_QuanLiTacGia.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_QuanLiTacGia.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_QuanLiTacGia.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_QuanLiTacGia.UseCustomBackColor = True
        Me.Tile_QuanLiTacGia.UseCustomForeColor = True
        Me.Tile_QuanLiTacGia.UseSelectable = True
        Me.Tile_QuanLiTacGia.UseStyleColors = True
        Me.Tile_QuanLiTacGia.UseTileImage = True
        '
        'Tile_ThemTacGia
        '
        Me.Tile_ThemTacGia.ActiveControl = Nothing
        Me.Tile_ThemTacGia.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_ThemTacGia, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_ThemTacGia, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_ThemTacGia.ForeColor = System.Drawing.Color.White
        Me.Tile_ThemTacGia.Location = New System.Drawing.Point(877, 88)
        Me.Tile_ThemTacGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_ThemTacGia.Name = "Tile_ThemTacGia"
        Me.Tile_ThemTacGia.Size = New System.Drawing.Size(262, 220)
        Me.Tile_ThemTacGia.TabIndex = 48
        Me.Tile_ThemTacGia.Text = "Thêm Tác Giả"
        Me.Tile_ThemTacGia.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_quill_with_ink_80
        Me.Tile_ThemTacGia.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_ThemTacGia.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_ThemTacGia.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_ThemTacGia.UseCustomBackColor = True
        Me.Tile_ThemTacGia.UseCustomForeColor = True
        Me.Tile_ThemTacGia.UseSelectable = True
        Me.Tile_ThemTacGia.UseStyleColors = True
        Me.Tile_ThemTacGia.UseTileImage = True
        '
        'Tile_QuanLiSach
        '
        Me.Tile_QuanLiSach.ActiveControl = Nothing
        Me.Tile_QuanLiSach.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_QuanLiSach, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_QuanLiSach, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_QuanLiSach.ForeColor = System.Drawing.Color.White
        Me.Tile_QuanLiSach.Location = New System.Drawing.Point(654, 318)
        Me.Tile_QuanLiSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_QuanLiSach.Name = "Tile_QuanLiSach"
        Me.Tile_QuanLiSach.Size = New System.Drawing.Size(215, 220)
        Me.Tile_QuanLiSach.TabIndex = 47
        Me.Tile_QuanLiSach.Text = "Quản Lí Sách"
        Me.Tile_QuanLiSach.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_book_shelf_80
        Me.Tile_QuanLiSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_QuanLiSach.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_QuanLiSach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_QuanLiSach.UseCustomBackColor = True
        Me.Tile_QuanLiSach.UseCustomForeColor = True
        Me.Tile_QuanLiSach.UseSelectable = True
        Me.Tile_QuanLiSach.UseStyleColors = True
        Me.Tile_QuanLiSach.UseTileImage = True
        '
        'Tile_ThemSach
        '
        Me.Tile_ThemSach.ActiveControl = Nothing
        Me.Tile_ThemSach.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_ThemSach, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_ThemSach, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_ThemSach.ForeColor = System.Drawing.Color.White
        Me.Tile_ThemSach.Location = New System.Drawing.Point(654, 88)
        Me.Tile_ThemSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_ThemSach.Name = "Tile_ThemSach"
        Me.Tile_ThemSach.Size = New System.Drawing.Size(215, 220)
        Me.Tile_ThemSach.TabIndex = 46
        Me.Tile_ThemSach.Text = "Thêm Sách"
        Me.Tile_ThemSach.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_contacts_80
        Me.Tile_ThemSach.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_ThemSach.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_ThemSach.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_ThemSach.UseCustomBackColor = True
        Me.Tile_ThemSach.UseCustomForeColor = True
        Me.Tile_ThemSach.UseSelectable = True
        Me.Tile_ThemSach.UseStyleColors = True
        Me.Tile_ThemSach.UseTileImage = True
        '
        'Tile_QuanLiLoaiDocGia
        '
        Me.Tile_QuanLiLoaiDocGia.ActiveControl = Nothing
        Me.Tile_QuanLiLoaiDocGia.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_QuanLiLoaiDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_QuanLiLoaiDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_QuanLiLoaiDocGia.ForeColor = System.Drawing.Color.White
        Me.Tile_QuanLiLoaiDocGia.Location = New System.Drawing.Point(295, 318)
        Me.Tile_QuanLiLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_QuanLiLoaiDocGia.Name = "Tile_QuanLiLoaiDocGia"
        Me.Tile_QuanLiLoaiDocGia.Size = New System.Drawing.Size(303, 220)
        Me.Tile_QuanLiLoaiDocGia.TabIndex = 45
        Me.Tile_QuanLiLoaiDocGia.Text = "Quản Lí Loại Độc Giả"
        Me.Tile_QuanLiLoaiDocGia.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_resume_80__1_
        Me.Tile_QuanLiLoaiDocGia.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_QuanLiLoaiDocGia.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_QuanLiLoaiDocGia.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_QuanLiLoaiDocGia.UseCustomBackColor = True
        Me.Tile_QuanLiLoaiDocGia.UseCustomForeColor = True
        Me.Tile_QuanLiLoaiDocGia.UseSelectable = True
        Me.Tile_QuanLiLoaiDocGia.UseStyleColors = True
        Me.Tile_QuanLiLoaiDocGia.UseTileImage = True
        '
        'Tile_ThemLoaiDocGia
        '
        Me.Tile_ThemLoaiDocGia.ActiveControl = Nothing
        Me.Tile_ThemLoaiDocGia.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_ThemLoaiDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_ThemLoaiDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_ThemLoaiDocGia.ForeColor = System.Drawing.Color.White
        Me.Tile_ThemLoaiDocGia.Location = New System.Drawing.Point(295, 88)
        Me.Tile_ThemLoaiDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_ThemLoaiDocGia.Name = "Tile_ThemLoaiDocGia"
        Me.Tile_ThemLoaiDocGia.Size = New System.Drawing.Size(303, 220)
        Me.Tile_ThemLoaiDocGia.TabIndex = 44
        Me.Tile_ThemLoaiDocGia.Text = "Thêm Loại Độc Giả"
        Me.Tile_ThemLoaiDocGia.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_customer_80__1_
        Me.Tile_ThemLoaiDocGia.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_ThemLoaiDocGia.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_ThemLoaiDocGia.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_ThemLoaiDocGia.UseCustomBackColor = True
        Me.Tile_ThemLoaiDocGia.UseCustomForeColor = True
        Me.Tile_ThemLoaiDocGia.UseSelectable = True
        Me.Tile_ThemLoaiDocGia.UseStyleColors = True
        Me.Tile_ThemLoaiDocGia.UseTileImage = True
        '
        'Tile_QuanLiDocGia
        '
        Me.Tile_QuanLiDocGia.ActiveControl = Nothing
        Me.Tile_QuanLiDocGia.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_QuanLiDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_QuanLiDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_QuanLiDocGia.ForeColor = System.Drawing.Color.White
        Me.Tile_QuanLiDocGia.Location = New System.Drawing.Point(51, 318)
        Me.Tile_QuanLiDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_QuanLiDocGia.Name = "Tile_QuanLiDocGia"
        Me.Tile_QuanLiDocGia.Size = New System.Drawing.Size(236, 220)
        Me.Tile_QuanLiDocGia.TabIndex = 43
        Me.Tile_QuanLiDocGia.Text = "Quản Lí Độc Giả"
        Me.Tile_QuanLiDocGia.TileImage = Global.QLTV_GUI.My.Resources.Resources.icons8_cv_80
        Me.Tile_QuanLiDocGia.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_QuanLiDocGia.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_QuanLiDocGia.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_QuanLiDocGia.UseCustomBackColor = True
        Me.Tile_QuanLiDocGia.UseCustomForeColor = True
        Me.Tile_QuanLiDocGia.UseSelectable = True
        Me.Tile_QuanLiDocGia.UseStyleColors = True
        Me.Tile_QuanLiDocGia.UseTileImage = True
        '
        'Tile_QuyDinh
        '
        Me.Tile_QuyDinh.ActiveControl = Nothing
        Me.Tile_QuyDinh.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_QuyDinh, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_QuyDinh, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_QuyDinh.ForeColor = System.Drawing.Color.White
        Me.Tile_QuyDinh.Location = New System.Drawing.Point(1234, 581)
        Me.Tile_QuyDinh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_QuyDinh.Name = "Tile_QuyDinh"
        Me.Tile_QuyDinh.Size = New System.Drawing.Size(241, 450)
        Me.Tile_QuyDinh.TabIndex = 42
        Me.Tile_QuyDinh.Text = "Quy Định"
        Me.Tile_QuyDinh.TileImage = CType(resources.GetObject("Tile_QuyDinh.TileImage"), System.Drawing.Image)
        Me.Tile_QuyDinh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_QuyDinh.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_QuyDinh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_QuyDinh.UseCustomBackColor = True
        Me.Tile_QuyDinh.UseCustomForeColor = True
        Me.Tile_QuyDinh.UseSelectable = True
        Me.Tile_QuyDinh.UseStyleColors = True
        Me.Tile_QuyDinh.UseTileImage = True
        '
        'Tile_ThemDocGia
        '
        Me.Tile_ThemDocGia.ActiveControl = Nothing
        Me.Tile_ThemDocGia.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelAnimator1.SetDecoration(Me.Tile_ThemDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Tile_ThemDocGia, BunifuAnimatorNS.DecorationType.None)
        Me.Tile_ThemDocGia.ForeColor = System.Drawing.Color.White
        Me.Tile_ThemDocGia.Location = New System.Drawing.Point(51, 88)
        Me.Tile_ThemDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tile_ThemDocGia.Name = "Tile_ThemDocGia"
        Me.Tile_ThemDocGia.Size = New System.Drawing.Size(236, 220)
        Me.Tile_ThemDocGia.TabIndex = 39
        Me.Tile_ThemDocGia.Text = "Thêm Độc Giả"
        Me.Tile_ThemDocGia.TileImage = Global.QLTV_GUI.My.Resources.Resources._1
        Me.Tile_ThemDocGia.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tile_ThemDocGia.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.Tile_ThemDocGia.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.Tile_ThemDocGia.UseCustomBackColor = True
        Me.Tile_ThemDocGia.UseCustomForeColor = True
        Me.Tile_ThemDocGia.UseSelectable = True
        Me.Tile_ThemDocGia.UseStyleColors = True
        Me.Tile_ThemDocGia.UseTileImage = True
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator1.SetDecoration(Me.Btn_Close, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Btn_Close, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1473, 13)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 38
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnimator.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(420, 70)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Quản Lí Thư Viện"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelAnimator1.SetDecoration(Me.BunifuSeparator1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuSeparator1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(20, 57)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1494, 35)
        Me.BunifuSeparator1.TabIndex = 32
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'PanelAnimator1
        '
        Me.PanelAnimator1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.PanelAnimator1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 1.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.PanelAnimator1.DefaultAnimation = Animation1
        Me.PanelAnimator1.Interval = 50
        Me.PanelAnimator1.MaxAnimationTime = 5000
        Me.PanelAnimator1.TimeStep = 0.07!
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1805, 1094)
        Me.Controls.Add(Me.Pn_Main)
        Me.Controls.Add(Me.Pn_Menu)
        Me.PanelAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Pn_Menu.ResumeLayout(False)
        CType(Me.Btn_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pn_Main.ResumeLayout(False)
        Me.Pn_Main.PerformLayout()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pn_Menu As Panel
    Friend WithEvents Btn_Menu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MenuDocGia As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PanelAnimator1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Pn_Main As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents Tile_QuyDinh As MetroFramework.Controls.MetroTile
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents MenuMain As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents Tile_LapPhieuMuonSach As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_NhanTraSach As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_TraCuuSach As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_BaoCaoSachTraTre As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_BaoCaoTheoTheLoai As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_QuanLiTheLoaiSach As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_ThemTheLoaiSach As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_QuanLiTacGia As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_ThemTacGia As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_QuanLiSach As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_ThemSach As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_QuanLiLoaiDocGia As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_ThemLoaiDocGia As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_QuanLiDocGia As MetroFramework.Controls.MetroTile
    Private WithEvents Tile_ThemDocGia As MetroFramework.Controls.MetroTile
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_GioiThieu As Bunifu.Framework.UI.BunifuFlatButton
End Class
