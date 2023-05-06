Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class Issue_Books
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
    Dim getcust As String
    Dim checkk As Integer
    Dim getissue As String
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim str As String
    Private Sub fillstudent()
        Dim Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Con.Open()
        Try
            getcust = "select First_Name from Student where stid='" & txtstnum.Text & "'"
            com = New SqlCommand(getcust, Con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                txtName.Text = dr.GetValue(0).ToString()


            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub
    Private Sub fillbook()
        Dim Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Con.Open()
        Try
            getcust = "select Book_Name from Book where Book_Number='" & txtbnumber.Text & "'"
            com = New SqlCommand(getcust, Con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                txtBname.Text = dr.GetValue(0).ToString()


            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub
    Private Sub cmbStnum_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Issue_Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con.open()
        displayissue()
        getcust = "SELECT Inumber=MAX(Inumber)+1 FROM Issue"
        com = New SqlCommand(getcust, Con)
        dr = com.ExecuteReader()
        If dr.Read() Then

            txtissue.Text = dr.GetValue(0).ToString()

        End If
        Con.close()
    End Sub

    Private Sub txtstnum_TextChanged(sender As Object, e As EventArgs) Handles txtstnum.TextChanged
        fillstudent()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtissue.Text = "" Or txtstnum.Text = "" Or txtName.Text = "" Or txtbnumber.Text = "" Or txtBname.Text = "" Then
            MsgBox("Missing Information")
            checkk = 0
        Else
            Con.Open()

            Dim query = "insert into Issue (Inumber,stid,stName,bookId,BookName,issueDate) values('" & txtissue.Text & "','" & txtstnum.Text & "','" & txtName.Text & "','" & txtbnumber.Text & "','" & txtBname.Text & "','" & date1.Value.Date & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Issued")
            checkk = 1
            displayissue()
            Con.Close()
            Reset()

        End If
    End Sub
    Private Sub Reset()
        Con.Open()
        If checkk = 1 Then
            getissue = txtissue.Text
            txtissue.Text = getissue + 1
            checkk = 0
        End If
        txtstnum.Text = ""
        txtName.Text = ""
        txtbnumber.Text = ""
        txtBname.Text = ""
        date1.ResetText()
        Con.close()
    End Sub

    Private Sub txtbnumber_TextChanged(sender As Object, e As EventArgs) Handles txtbnumber.TextChanged
        fillbook()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Reset()
    End Sub


    Dim key = 0




    Private Sub dgissue_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgissue.CellContentClick
        Dim row As DataGridViewRow = dgissue.Rows(e.RowIndex)
        txtissue.Text = row.Cells(0).Value.ToString
        txtstnum.Text = row.Cells(1).Value.ToString
        txtName.Text = row.Cells(2).Value.ToString
        txtbnumber.Text = row.Cells(3).Value.ToString
        txtBname.Text = row.Cells(4).Value.ToString
        date1.MinDate = row.Cells(5).Value.ToString

        key = Convert.ToInt32(row.Cells(0).Value.ToString)
    End Sub

    Private Sub txtissue_TextChanged(sender As Object, e As EventArgs) Handles txtissue.TextChanged

    End Sub
End Class