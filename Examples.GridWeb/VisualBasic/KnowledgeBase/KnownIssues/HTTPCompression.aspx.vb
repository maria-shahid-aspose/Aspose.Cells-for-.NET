﻿Imports System.IO

Namespace KnowledgeBase.KnownIssues
    Public Class HTTPCompression
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        End Sub

        Protected Sub btnDownload_Click(sender As Object, e As EventArgs)
            Dim path As String = TryCast(Me.Master, Site).GetDataDir()

            ' ExStart:HTTPCompression
            Dim fs1 As FileStream = New FileStream(path & "\KnowledgeBase\SampleData.xlsx", FileMode.Open, FileAccess.Read)
            Dim data1() As Byte = New Byte(fs1.Length) {}
            fs1.Read(data1, 0, data1.Length)

            Me.Response.ContentType = "application/xls"
            Response.AddHeader("content-disposition", "inline;  filename=book1.xls")
            Response.BinaryWrite(data1)
            Response.End()
            ' ExEnd:HTTPCompression
        End Sub
    End Class
End Namespace