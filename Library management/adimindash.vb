Imports System.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class adimindash
    Dim Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub Displayuser()
        Con.Open()
        Dim query = "select * from [user]"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        dguser.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Dim key = 0
    Private Sub dguser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dguser.CellContentClick
        Dim row As DataGridViewRow = dguser.Rows(e.RowIndex)
        txtusnm.Text = row.Cells(0).Value.ToString
        txtpass.Text = row.Cells(1).Value.ToString
        txtName.Text = row.Cells(2).Value.ToString
        txtaddress.Text = row.Cells(3).Value.ToString
        txtContact.Text = row.Cells(4).Value.ToString
        txtEmail.Text = row.Cells(5).Value.ToString

        key = Convert.ToInt32(row.Cells(1).Value.ToString)
    End Sub
    Private Sub Reset()
        txtusnm.Text = ""
        txtpass.Text = ""
        txtName.Text = ""
        txtaddress.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub adimindash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Displayuser()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtusnm.Text = "" Or txtpass.Text = "" Or txtName.Text = "" Or txtaddress.Text = "" Or txtContact.Text = "" Or txtEmail.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query = "insert into [user] (usnm,password,Name,Address,Contact,Email) values('" & txtusnm.Text & "','" & txtpass.Text & "','" & txtName.Text & "','" & txtaddress.Text & "','" & txtContact.Text & "','" & txtEmail.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved")

            Con.Close()
            Reset()
            Displayuser()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Key = 0 Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query = "Delete from [user] where password=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("user Deleted")
            Con.Close()
            Displayuser()
            Reset()

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        loging.Show()
    End Sub
End Class