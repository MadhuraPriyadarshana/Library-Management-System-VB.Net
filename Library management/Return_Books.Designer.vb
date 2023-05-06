<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Return_Books
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtverify = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgissue = New System.Windows.Forms.DataGridView()
        Me.dgreturn = New System.Windows.Forms.DataGridView()
        Me.txtstnum = New System.Windows.Forms.TextBox()
        Me.txtbnum = New System.Windows.Forms.TextBox()
        Me.btnverify = New System.Windows.Forms.Button()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.txtreturn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtissue = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgissue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgreturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(1036, 167)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(197, 56)
        Me.btnDelete.TabIndex = 63
        Me.btnDelete.Text = "Reset"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(1036, 69)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(193, 60)
        Me.btnAdd.TabIndex = 62
        Me.btnAdd.Text = "Submit"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(18, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 32)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Issue Date"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(774, 129)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(183, 38)
        Me.txtName.TabIndex = 57
        '
        'txtBname
        '
        Me.txtBname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBname.Location = New System.Drawing.Point(258, 129)
        Me.txtBname.Name = "txtBname"
        Me.txtBname.Size = New System.Drawing.Size(220, 38)
        Me.txtBname.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(258, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 32)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Book Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(774, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 32)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Student Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(514, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 32)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Student Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(23, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 32)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Book Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(245, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 32)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Due Date"
        '
        'txtverify
        '
        Me.txtverify.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtverify.Location = New System.Drawing.Point(475, 217)
        Me.txtverify.Name = "txtverify"
        Me.txtverify.Size = New System.Drawing.Size(146, 38)
        Me.txtverify.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(475, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 32)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Verify"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(196, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 41)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Book Issued"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(856, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 41)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Book Reeturned"
        '
        'dgissue
        '
        Me.dgissue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgissue.Location = New System.Drawing.Point(2, 321)
        Me.dgissue.Name = "dgissue"
        Me.dgissue.RowHeadersWidth = 51
        Me.dgissue.RowTemplate.Height = 29
        Me.dgissue.Size = New System.Drawing.Size(619, 381)
        Me.dgissue.TabIndex = 73
        '
        'dgreturn
        '
        Me.dgreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgreturn.Location = New System.Drawing.Point(627, 321)
        Me.dgreturn.Name = "dgreturn"
        Me.dgreturn.RowHeadersWidth = 51
        Me.dgreturn.RowTemplate.Height = 29
        Me.dgreturn.Size = New System.Drawing.Size(701, 381)
        Me.dgreturn.TabIndex = 74
        '
        'txtstnum
        '
        Me.txtstnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtstnum.Location = New System.Drawing.Point(514, 129)
        Me.txtstnum.Name = "txtstnum"
        Me.txtstnum.Size = New System.Drawing.Size(220, 38)
        Me.txtstnum.TabIndex = 75
        '
        'txtbnum
        '
        Me.txtbnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbnum.Location = New System.Drawing.Point(23, 129)
        Me.txtbnum.Name = "txtbnum"
        Me.txtbnum.Size = New System.Drawing.Size(145, 38)
        Me.txtbnum.TabIndex = 76
        '
        'btnverify
        '
        Me.btnverify.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnverify.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnverify.Location = New System.Drawing.Point(627, 219)
        Me.btnverify.Name = "btnverify"
        Me.btnverify.Size = New System.Drawing.Size(108, 36)
        Me.btnverify.TabIndex = 78
        Me.btnverify.Text = "verify"
        Me.btnverify.UseVisualStyleBackColor = False
        '
        'date1
        '
        Me.date1.CustomFormat = "dd/MM/yyyy"
        Me.date1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date1.Location = New System.Drawing.Point(18, 214)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(191, 38)
        Me.date1.TabIndex = 79
        Me.date1.Value = New Date(2022, 12, 1, 0, 0, 0, 0)
        '
        'date2
        '
        Me.date2.CustomFormat = "dd/MM/yyyy"
        Me.date2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date2.Location = New System.Drawing.Point(245, 214)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(182, 38)
        Me.date2.TabIndex = 66
        Me.date2.Value = New Date(2022, 12, 2, 0, 0, 0, 0)
        '
        'txtreturn
        '
        Me.txtreturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtreturn.Location = New System.Drawing.Point(18, 50)
        Me.txtreturn.Name = "txtreturn"
        Me.txtreturn.Size = New System.Drawing.Size(146, 38)
        Me.txtreturn.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(18, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 32)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Return Number"
        '
        'txtissue
        '
        Me.txtissue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtissue.Location = New System.Drawing.Point(258, 50)
        Me.txtissue.Name = "txtissue"
        Me.txtissue.Size = New System.Drawing.Size(146, 38)
        Me.txtissue.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(258, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(188, 32)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Issue Number"
        '
        'Return_Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1332, 703)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtissue)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtreturn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.date1)
        Me.Controls.Add(Me.btnverify)
        Me.Controls.Add(Me.txtbnum)
        Me.Controls.Add(Me.txtstnum)
        Me.Controls.Add(Me.dgreturn)
        Me.Controls.Add(Me.dgissue)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtverify)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.date2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtBname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Return_Books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return_Books"
        CType(Me.dgissue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgreturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtverify As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgissue As DataGridView
    Friend WithEvents dgreturn As DataGridView
    Friend WithEvents txtstnum As TextBox
    Friend WithEvents txtbnum As TextBox
    Friend WithEvents btnverify As Button
    Friend WithEvents date1 As DateTimePicker
    Friend WithEvents date2 As DateTimePicker
    Friend WithEvents txtreturn As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtissue As TextBox
    Friend WithEvents Label10 As Label
End Class
