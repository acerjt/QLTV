Public Class Frm_Main


    Private Sub ThêmĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmĐộcGiảToolStripMenuItem.Click
        Dim frmdg As Frm_ThemDocGia = New Frm_ThemDocGia()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub ThêmLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiĐộcGiảToolStripMenuItem.Click
        Dim frmdg As Frm_ThemLoaiDocGia = New Frm_ThemLoaiDocGia()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLíĐộcGiảToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuảnLíĐộcGiảToolStripMenuItem1.Click
        Dim frmdg As Frm_QLDocGia = New Frm_QLDocGia()
        frmdg.MdiParent = Me
        frmdg.Show()
    End Sub

    Private Sub QuảnLíLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíLoạiĐộcGiảToolStripMenuItem.Click
        Dim frmldg As Frm_QLLoaiDocGia = New Frm_QLLoaiDocGia()
        frmldg.MdiParent = Me
        frmldg.Show()
    End Sub

    Private Sub QuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuyĐịnhToolStripMenuItem.Click
        Dim frmquydinh As Frm_QuyDinh = New Frm_QuyDinh()
        frmquydinh.MdiParent = Me
        frmquydinh.Show()
    End Sub

    Private Sub ThêmSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSáchToolStripMenuItem.Click
        Dim frmSach As Frm_ThemSach = New Frm_ThemSach()
        frmSach.MdiParent = Me
        frmSach.Show()
    End Sub

    Private Sub ThêmThểLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmThểLoạiSáchToolStripMenuItem.Click
        Dim frmTheLoaiSach As Frm_ThemTheLoaiSach = New Frm_ThemTheLoaiSach()
        frmTheLoaiSach.MdiParent = Me
        frmTheLoaiSach.Show()
    End Sub

    Private Sub ThêmTácGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmTácGiảToolStripMenuItem.Click
        Dim frmTacGia As Frm_ThemTacGia = New Frm_ThemTacGia()
        frmTacGia.MdiParent = Me
        frmTacGia.Show()
    End Sub

    Private Sub QuảnLíSáchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuảnLíSáchToolStripMenuItem1.Click
        Dim frmQlSach As Frm_QlSach = New Frm_QlSach()
        frmQlSach.MdiParent = Me
        frmQlSach.Show()
    End Sub

    Private Sub LậpPhiếuMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuMượnSáchToolStripMenuItem.Click
        Dim frmLapPhieuMuonSach As Frm_LapPhieuMuonSach = New Frm_LapPhieuMuonSach()
        frmLapPhieuMuonSach.MdiParent = Me
        frmLapPhieuMuonSach.Show()
    End Sub

    Private Sub NhậnTrảSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậnTrảSáchToolStripMenuItem.Click
        Dim frmLapPhieuTraSach As Frm_NhanTraSach = New Frm_NhanTraSach()
        frmLapPhieuTraSach.MdiParent = Me
        frmLapPhieuTraSach.Show()
    End Sub
End Class