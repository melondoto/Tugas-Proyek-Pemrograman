﻿Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports Inventory

Public Class ClsCtlMember : Implements InfProses
    Public Function LoginMember(NIM As String, password As String) As DataView
        'Try
        '    DTA = New OleDbDataAdapter("SELECT p.*, m.NIM FROM personal p JOIN member m ON p.id_personal = m.id_personal WHERE 
        '                                m.NIM = '" & NIM & "' AND p.password = '" & password & "'", BUKAKONEKSI)
        '    DTS = New DataSet()
        '    DTA.Fill(DTS, "cari_member")
        '    Dim grid As New DataView(DTS.Tables("cari_member"))

        '    Return grid
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
        Throw New NotImplementedException()
    End Function

    Public Function InsertData(Ob As Object) As MySqlCommand Implements InfProses.InsertData
        'Dim data As New ClsEntMember
        'data = Ob
        'CMD = New OleDbCommand("EXEC InsertPersonal 'M', '" & data.namaMember & "', '" & data.emailMember & "', 
        '                       '" & data.contactMember & "', '" & data.jurusanMember & "', '" & data.passwordMember & "', '', 
        '                       '" & data.NIMMember & "'", BUKAKONEKSI)
        'CMD.CommandType = CommandType.Text
        'CMD.ExecuteNonQuery()
        'CMD = New OleDbCommand("", TUTUPKONEKSI)
        'Return CMD
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As MySqlCommand Implements InfProses.updateData
        'Dim data As New ClsEntMember
        'data = Ob
        'CMD = New OleDbCommand("exec UpdateData '" & data.namaMember & "', '" & data.emailMember & "', '" & data.contactMember & "', '" & data.jurusanMember & "', 
        '                       '" & data.passwordMember & "', null, '" & data.NIMMember & "', 'M', '" & data.id_personalMember & "'", BUKAKONEKSI)
        'CMD.CommandType = CommandType.Text
        'CMD.ExecuteNonQuery()
        'CMD = New OleDbCommand("", TUTUPKONEKSI)
        'Return CMD
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As MySqlCommand Implements InfProses.deleteData
        'CMD = New OleDbCommand("DELETE FROM member WHERE NIM = '" & kunci & "'", BUKAKONEKSI)
        'CMD.CommandType = CommandType.Text
        'CMD.ExecuteNonQuery()
        'CMD = New OleDbCommand("", TUTUPKONEKSI)
        'Return CMD
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        'Try
        '    DTA = New OleDbDataAdapter("SELECT (m.id_personal - 1) as 'No', m.NIM, p.nama as 'Nama', p.password as 'Password', p.email as 'Email', p.contact as 'Kontak', 
        '                                p.company as 'Organisasi' FROM personal p JOIN member m ON p.id_personal = m.id_personal", BUKAKONEKSI)
        '    DTS = New DataSet()
        '    DTA.Fill(DTS, "data_member")
        '    Dim data As New DataView(DTS.Tables("data_member"))

        '    Return data
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
