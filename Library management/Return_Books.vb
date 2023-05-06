Imports System.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.Metadata.Internal
Imports Shashlik.Utils.Extensions

Public Class Return_Books
    Dim Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub displayissue()

        Dim query = "select * from Issue"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        dgissue.DataSource = ds.Tables(0)

    End Sub

    Private Sub displayreturn()

        Dim query = "select * from [return]"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        dgreturn.DataSource = ds.Tables(0)

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Return_Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayissue()
        displayreturn()
    End Sub
    Dim key = 0
    Private Sub dgissue_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgissue.CellContentClick
        Dim row As DataGridViewRow = dgissue.Rows(e.RowIndex)
        load_issue()
        txtissue.Text = row.Cells(0).Value.ToString
        txtstnum.Text = row.Cells(1).Value.ToString
        txtName.Text = row.Cells(2).Value.ToString
        txtbnum.Text = row.Cells(3).Value.ToString
        txtBname.Text = row.Cells(4).Value.ToString
        date1.Value = row.Cells(5).Value.ToString
        key = Convert.ToInt32(row.Cells(0).Value.ToString)
    End Sub

    Private Sub btnverify_Click(sender As Object, e As EventArgs) Handles btnverify.Click
        Dim dif As TimeSpan
        Dim fine As Integer
        dif = date2.Value.Date - date1.Value.Date
        Dim days = dif.Days
        If days <= 5 Then
            fine = 0
            txtverify.Text = "Fine"
        Else
            fine = days - 5
            txtverify.Text = "Rs" + Convert.ToString(fine * 50)

        End If
    End Sub
    Dim getissue As String
    Dim checkk As Integer
    Private Sub Reset()
        If checkk = 1 Then
            getissue = txtreturn.Text
            txtreturn.Text = getissue + 1
            checkk = 0
        End If
        txtreturn.Text = ""
        txtissue.Text = ""
        txtstnum.Text = ""
        txtName.Text = ""
        txtbnum.Text = ""
        txtBname.Text = ""
        date1.ResetText()
        txtverify.Text = ""

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Reset()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            Con.open()

            Dim query = "Delete from Issue where Inumber=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Returned")
            checkk = 1
            Con.Close()
            addreturn()
            Reset()
            displayissue()
            displayreturn()

        End If
    End Sub
    Dim getcust As String
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Private Sub load_issue()
        Con.open()
        getcust = "SELECT Rid=MAX(Rid)+1 FROM [return]"
        com = New SqlCommand(getcust, Con)
        dr = com.ExecuteReader()
        If dr.Read() Then

            txtreturn.Text = dr.GetValue(0).ToString()

        End If
        Con.close()
    End Sub
    Private Sub addreturn()

        Con.Open()

        Dim query = "insert into [return] (Rid,stid,stName,bookId,bookName,issueDate,returnDate,fine) values('" & txtreturn.Text & "','" & txtstnum.Text & "','" & txtName.Text & "','" & txtbnum.Text & "','" & txtBname.Text & "','" & date1.Value.Date & " ','" & date2.Value.Date & "','" & txtverify.Text & "')"
        Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()


        Con.Close()


    End Sub

    Private Sub date1_ValueChanged(sender As Object, e As EventArgs) Handles date1.ValueChanged

    End Sub
End Class