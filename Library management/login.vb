
Imports System.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.Storage

Public Class loging
    Dim rdr As SqlDataReader
    Dim Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub btnloging_Click(sender As Object, e As EventArgs) Handles btnLoging.Click
        Con.open()
        Dim cmd = New SqlCommand("select * from [user] where usnm='" + txtUserName.Text + "' and password='" + txtPassword.Text + "'")
        cmd.Connection = Con
        rdr = cmd.ExecuteReader()
        If (rdr.read()) Then
            MsgBox("Loggin Success..")
            txtPassword.Text = ""
            Dashboard.Show()
            Me.Hide()

        Else
            MsgBox("Error")
        End If
        Con.close()
    End Sub

    Private Sub loging_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUserName.Text = "admin" And txtPassword.Text = "1234" Then
            MsgBox("Login Sucesess")
            txtPassword.Text = ""
            Me.Hide()
            adimindash.Show()
        End If
    End Sub
End Class