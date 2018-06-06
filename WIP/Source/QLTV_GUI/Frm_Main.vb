Imports System
Imports System.Windows.Forms

Public Class Frm_Main

    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Location = New Point(40, 40)
        Me.Size = New Size(1190, 695)
        Pn_Menu.Width = 170
        Btn_Menu.Location = New Point(125, 12)

    End Sub
    Private Sub MenuMain_Click(sender As Object, e As EventArgs) Handles MenuMain.Click


    End Sub
    Private Sub Btn_Menu_Click(sender As Object, e As EventArgs) Handles Btn_Menu.Click 'menu click

        If Pn_Menu.Width = 50 Then
            Pn_Menu.Visible = False
            Pn_Menu.Width = 170
            Me.Size = New Size(1190, 600)
            PanelAnimator1.ShowSync(Pn_Menu)
            Btn_Menu.Location = New Point(125, 12)

        Else
            Pn_Menu.Visible = False
            Pn_Menu.Width = 50
            Btn_Menu.Location = New Point(10, 12)
            'Pn_Main.Width = 700
            PanelAnimator.ShowSync(Pn_Menu)
            Me.Width = 1070
        End If
    End Sub


    Private Sub Btn_QuanLiDocGia_Click(sender As Object, e As EventArgs)
        Dim frmQLDocGia = New Frm_QLDocGia
        frmQLDocGia.Show()
    End Sub

    Private Sub Btn_QuanLiLoaiDocGia_Click(sender As Object, e As EventArgs)
        Dim frmQLLoaiDocGIA = New Frm_QLLoaiDocGia
        frmQLLoaiDocGIA.Show()
    End Sub


    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        'Hide()
        'Dim frm_Close = New Frm_Close()
        'Frm_Close.ShowDialog()
        'If (MetroFramework.MetroMessageBox.Show(Me, "Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
        '    Application.Exit()
        Me.Close()
        'End If
        '

    End Sub


    Private Sub Tile_ThemLoaiDocGia_Click(sender As Object, e As EventArgs) Handles Tile_ThemLoaiDocGia.Click
        Hide()
        Dim frmThemLoaiDocGia = New Frm_ThemLoaiDocGia()
        frmThemLoaiDocGia.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_QuanLiLoaiDocGia_Click(sender As Object, e As EventArgs) Handles Tile_QuanLiLoaiDocGia.Click
        Hide()
        Dim frmQuanLiLoaiDocGia = New Frm_QLLoaiDocGia()
        frmQuanLiLoaiDocGia.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_ThemSach_Click(sender As Object, e As EventArgs) Handles Tile_ThemSach.Click
        Hide()
        Dim frmThemSach = New Frm_ThemSach()
        frmThemSach.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_ThemTacGia_Click(sender As Object, e As EventArgs) Handles Tile_ThemTacGia.Click
        Hide()
        Dim frmThemTacGia = New Frm_ThemTacGia()
        frmThemTacGia.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_QuanLiTacGia_Click(sender As Object, e As EventArgs) Handles Tile_QuanLiTacGia.Click
        Hide()
        Dim frmQLTacGia = New Frm_QLTacGia()
        frmQLTacGia.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_QuyDinh_Click(sender As Object, e As EventArgs) Handles Tile_QuyDinh.Click
        Hide()
        Dim frmQuyDinh = New Frm_QuyDinh()
        frmQuyDinh.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_ThemTheLoaiSach_Click(sender As Object, e As EventArgs) Handles Tile_ThemTheLoaiSach.Click
        Hide()
        Dim frmThemTheLoaiSach = New Frm_ThemTheLoaiSach()
        frmThemTheLoaiSach.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_QuanLiSach_Click(sender As Object, e As EventArgs) Handles Tile_QuanLiSach.Click
        Hide()
        Dim frmQLSach = New Frm_QLSach()
        frmQLSach.Location = New Point(10, 10)
        frmQLSach.Size = New Size(810, 550)
        frmQLSach.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_ThemDocGia_Click(sender As Object, e As EventArgs) Handles Tile_ThemDocGia.Click
        Hide()
        Dim frmThemDocGia = New Frm_ThemDocGia()
        frmThemDocGia.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_QuanLiTheLoaiSach_Click(sender As Object, e As EventArgs) Handles Tile_QuanLiTheLoaiSach.Click
        Hide()
        Dim frmQLTheLoaiSach = New Frm_QLTheLoaiSach()
        frmQLTheLoaiSach.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_QuanLiDocGia_Click(sender As Object, e As EventArgs) Handles Tile_QuanLiDocGia.Click
        Hide()
        Dim frmQLDocGia = New Frm_QLDocGia()
        frmQLDocGia.Location = New Point(10, 10)
        frmQLDocGia.Size = New Size(810, 590)
        frmQLDocGia.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_LapPhieuMuonSach_Click(sender As Object, e As EventArgs) Handles Tile_LapPhieuMuonSach.Click
        Hide()
        Dim frmLapPhieuMuonSach = New Frm_LapPhieuMuonSach()
        frmLapPhieuMuonSach.Size = New Size(810, 656)
        frmLapPhieuMuonSach.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_NhanTraSach_Click(sender As Object, e As EventArgs) Handles Tile_NhanTraSach.Click
        Hide()
        Dim frmNhanTraSach = New Frm_NhanTraSach()
        frmNhanTraSach.Size = New Size(810, 656)
        frmNhanTraSach.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_BaoCaoTheoTheLoai_Click(sender As Object, e As EventArgs) Handles Tile_BaoCaoTheoTheLoai.Click
        Hide()
        Dim frmBaoCaoThongKeTheoTheLoai = New Frm_LapBaoCaoThongKeMuonSachTheoTheLoai()
        frmBaoCaoThongKeTheoTheLoai.Size = New Size(1110, 540)
        frmBaoCaoThongKeTheoTheLoai.ShowDialog()
        Show()
    End Sub

    Private Sub Tile_BaoCaoSachTraTre_Click(sender As Object, e As EventArgs) Handles Tile_BaoCaoSachTraTre.Click
        Hide()
        Dim frmBaoCaoThongKeSachTraTre = New Frm_LapBaoCaoThongKeSachTraTre()
        frmBaoCaoThongKeSachTraTre.Size = New Size(1110, 540)
        frmBaoCaoThongKeSachTraTre.ShowDialog()
        Show()
    End Sub



    Private Sub Tile_TraCuuSach_Click(sender As Object, e As EventArgs) Handles Tile_TraCuuSach.Click
        Hide()
        Dim frmTraCuuSach = New Frm_TraCuuSach()
        frmTraCuuSach.ShowDialog()
        Show()
    End Sub


End Class
