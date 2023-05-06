Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Add_Book
    Dim Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub DisplayBook()
        Con.Open()
        Dim query = "select * from Book"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        addbookDG.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtbnum.Text = "" Or txtbname.Text = "" Or txtAuthor.Text = "" Or txtQuantity.Text = "" Or txtyear.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query = "insert into Book (Book_Number,Book_Name,Author,Released_Year,Quantity) values('" & txtbnum.Text & "','" & txtbname.Text & "','" & txtAuthor.Text & "','" & txtQuantity.Text & "','" & txtyear.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved")

            Con.Close()
            Reset()
            DisplayBook()
        End If
    End Sub
    Private Sub Reset()
        txtbname.Text = ""
        txtbnum.Text = ""
        txtAuthor.Text = ""
        txtyear.Text = ""
        txtQuantity.Text = ""
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub bookDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles addbookDG.CellContentClick
        DisplayBook()
    End Sub

    Private Sub Add_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub

    Dim key = 0
    Private Sub addbookDG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles addbookDG.CellMouseClick
        Dim row As DataGridViewRow = addbookDG.Rows(e.RowIndex)
        txtbnum.Text = row.Cells(0).Value.ToString
        txtbname.Text = row.Cells(1).Value.ToString
        txtAuthor.Text = row.Cells(2).Value.ToString
        txtyear.Text = row.Cells(3).Value.ToString
        txtQuantity.Text = row.Cells(4).Value.ToString


        key = Convert.ToInt32(row.Cells(0).Value.ToString)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query = "Delete from Book where Book_Number=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted")
            Con.Close()
            Reset()
            DisplayBook()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtbnum.Text = "" Or txtbname.Text = "" Or txtAuthor.Text = "" Or txtQuantity.Text = "" Or txtyear.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()

            Dim query = "Update Book set Book_Number='" & txtbnum.Text & "',Book_Name='" & txtbname.Text & "',Author='" & txtAuthor.Text & "',Quantity='" & txtQuantity.Text & "',Released_Year='" & txtyear.Text & "' where Book_Number='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")

            Con.Close()
            Reset()
            DisplayBook()
        End If
    End Sub
    Dim str As String
    Dim com As SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Con.Open()
            Dim query = "SELECT * FROM Book WHERE Book_Number = '" + txtsearch.Text + "'"
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, Con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            addbookDG.DataSource = ds.Tables(0)
            Con.Close()


        End Using
    End Sub
End Class