﻿Public Class Peminjaman
    Private Sub Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Member
        RefreshGrid()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
        Else
            Panel1.Width = 540
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPeminjaman.tampilData.ToTable
        DGPinjam.DataSource = DTGrid
    End Sub
End Class