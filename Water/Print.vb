﻿Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class Print

    Private Sub Print_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Print_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub

    Private Sub Print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            Dim ds As New DataSet1
            Dim dateselected As New ReportParameter("Date", Form_Home.UserControl11.DateTimePicker1.Value.ToString("YYYY-MM-dd"))
            Dim prepared As New ReportParameter("PreparedBy", LoggedInName)

            Dim adapter As New MySqlDataAdapter
            adapter.SelectCommand = comm


            adapter.Fill(ds.Tables(0))
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Report1.rdlc"
            ReportViewer1.LocalReport.SetParameters(dateselected)
            ReportViewer1.LocalReport.SetParameters(prepared)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            ReportViewer1.DocumentMapCollapsed = True
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 25
    End Sub
End Class