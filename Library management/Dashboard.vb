Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm

Public Class Dashboard
    Dim rdr As SqlDataReader
    Dim Con = New SqlConnection("Data Source=MADHURA;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub BooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem.Click
        Dim obj = New Dashboard
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub AllStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Student.Show()
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        Panel1.Hide()
        Dim a As New Student
        Me.IsMdiContainer = True
        a.MdiParent = Me
        Panel1.Hide()
        PictureBox2.Hide()
        a.Show()

    End Sub

    Private Sub AllBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllBooksToolStripMenuItem.Click
        Panel1.Hide()
        Dim b As New Add_Book
        Me.IsMdiContainer = True
        b.MdiParent = Me
        Panel1.Hide()
        PictureBox2.Hide()
        b.Show()

    End Sub

    Private Sub AddBooksToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Add_Book.Show()
    End Sub

    Private Sub IssueBooksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IssueBooksToolStripMenuItem1.Click
        Panel1.Hide()
        Dim c As New Issue_Books
        Me.IsMdiContainer = True
        c.MdiParent = Me
        Panel1.Hide()
        PictureBox2.Hide()
        c.Show()
    End Sub

    Private Sub BorrowBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowBooksToolStripMenuItem.Click
        Panel1.Hide()
        Dim d As New Return_Books
        Me.IsMdiContainer = True
        d.MdiParent = Me
        Panel1.Hide()
        PictureBox2.Hide()
        d.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        loging.Show()
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        MsgBox("Contact : madhurapriyadarshana99@gmail.com")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This System Made for the HNDIT Second Year First Smester RAD Asignment.. Thank You for Watiching..")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        For Each aform As Form In Me.MdiChildren
            aform.Close()
            Panel1.Show()
            PictureBox2.Show()

        Next
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub
End Class