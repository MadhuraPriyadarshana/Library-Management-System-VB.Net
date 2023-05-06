Imports System.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class Student
    Dim Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Reset()
        txtsnum.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        txtEmail.Text = ""
        txtContact.Text = ""
        txtAddress.Text = ""
    End Sub
    Private Sub Displaystudent()
        Con.Open()
        Dim query = "select * from Student"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        studentdg.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Dim key = 0
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentdg.CellContentClick
        Dim row As DataGridViewRow = studentdg.Rows(e.RowIndex)
        txtsnum.Text = row.Cells(0).Value.ToString
        txtFname.Text = row.Cells(1).Value.ToString
        txtLname.Text = row.Cells(2).Value.ToString
        txtEmail.Text = row.Cells(3).Value.ToString
        txtContact.Text = row.Cells(4).Value.ToString
        txtAddress.Text = row.Cells(5).Value.ToString


        key = Convert.ToInt32(row.Cells(0).Value.ToString)

        lblIndex.Text = row.Cells(0).Value.ToString
        lblFname.Text = row.Cells(1).Value.ToString
        lblLname.Text = row.Cells(2).Value.ToString
        lblEmail.Text = row.Cells(3).Value.ToString
        lblContact.Text = row.Cells(4).Value.ToString
        lblAddress.Text = row.Cells(5).Value.ToString
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Displaystudent()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtsnum.Text = "" Or txtLname.Text = "" Or txtFname.Text = "" Or txtEmail.Text = "" Or txtContact.Text = "" Or txtAddress.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query = "insert into Student values('" & txtsnum.Text & "','" & txtFname.Text & "','" & txtLname.Text & "','" & txtEmail.Text & "','" & txtContact.Text & "','" & txtAddress.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Saved")

            Con.Close()
            Reset()
            Displaystudent()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query = "Delete from Student where stid='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Deleted")
            Con.Close()
            Reset()
            Displaystudent()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtsnum.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtEmail.Text = "" Or txtContact.Text = "" Or txtAddress.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query = "Update Student set stid='" & txtsnum.Text & "',First_Name='" & txtFname.Text & "',Last_Name='" & txtLname.Text & "',Email='" & txtEmail.Text & "',Contact='" & txtContact.Text & "',Addrass='" & txtAddress.Text & "' where stid= '" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")

            Con.Close()
            Reset()
            Displaystudent()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Con.Open()
            Dim query = "SELECT * FROM Student WHERE stid = '" + txtsearch.Text + "'"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            studentdg.DataSource = ds.Tables(0)
            Con.Close()




        End Using
    End Sub

    Private Sub txtsnum_TextChanged(sender As Object, e As EventArgs) Handles txtsnum.TextChanged

    End Sub
End Class