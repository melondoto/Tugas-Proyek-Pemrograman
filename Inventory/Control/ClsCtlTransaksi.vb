﻿Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports Inventory

Public Class ClsCtlTransaksi : Implements InfProses
    Function kodeBaru() As String
        'Dim baru As String
        'Dim kodeakhir As Integer
        'Try
        '    DTA = New OleDbDataAdapter("SELECT MAX(RIGHT(id_transaksi, 4)) FROM transaksi", BUKAKONEKSI)
        '    DTS = New DataSet()
        '    DTA.Fill(DTS, "max_kode")
        '    kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
        '    baru = "T" & Strings.Right("000" & kodeakhir + 1, 4)

        '    Return baru
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
        Throw New NotImplementedException()
    End Function

    Public Function InsertData(Ob As Object) As MySqlCommand Implements InfProses.InsertData
        'Dim data As New ClsEntTransaksi
        'data = Ob
        'CMD = New OleDbCommand("INSERT INTO transaksi VALUES('" & kodeBaru() & "', '" & data.id_personalDetail & "', 
        '                       '" & data.id_barangDetail & "', '" & data.tgl_pinjamDetail & "', '" & data.tgl_kembaliDetail & "', 
        '                       '" & data.jumlahDetail & "', '" & data.status_transaksiDetail & "')", BUKAKONEKSI)
        'CMD.CommandType = CommandType.Text
        'CMD.ExecuteNonQuery()
        'CMD = New OleDbCommand("", TUTUPKONEKSI)
        'Return CMD
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As MySqlCommand Implements InfProses.updateData
        'Dim data As New ClsEntTransaksi
        'data = Ob
        'CMD = New OleDbCommand("UPDATE transaksi SET status_transaksi = '" & data.status_transaksiDetail & "' WHERE id_transaksi = 
        '                       '" & data.id_transaksiDetail & "' AND id_barang = '" & data.id_barangDetail & "'", BUKAKONEKSI)
        'CMD.CommandType = CommandType.Text
        'CMD.ExecuteNonQuery()
        'CMD = New OleDbCommand("", TUTUPKONEKSI)
        'Return CMD
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As MySqlCommand Implements InfProses.deleteData
        'CMD = New OleDbCommand("DELETE FROM transaksi WHERE id_transaksi = '" & kunci & "'", BUKAKONEKSI)
        'CMD.CommandType = CommandType.Text
        'CMD.ExecuteNonQuery()
        'CMD = New OleDbCommand("", TUTUPKONEKSI)
        'Return CMD
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        'Try
        '    DTA = New OleDbDataAdapter("SELECT t.id_transaksi as 'ID Transaksi', m.NIM, b.id_barang, b.nama_barang as 'Nama Barang', t.tgl_pinjam as 'Tanggal Peminjaman', 
        '                                t.tgl_kembali as 'Tanggal Dikembalikan', t.jumlah as 'Jumlah Barang yang dipinjam', t.status_transaksi as 'Status Transaksi',
        '                                m.Denda FROM transaksi t JOIN member m ON t.id_personal = m.id_personal JOIN personal p ON t.id_personal = p.id_personal JOIN barang b 
        '                                ON b.id_barang = t.id_barang", BUKAKONEKSI)
        '    DTS = New DataSet()
        '    DTA.Fill(DTS, "Tabel_Transaksi")
        '    Dim grid As New DataView(DTS.Tables("Tabel_Transaksi"))

        '    Return grid
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
