<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Issue_Books
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgissue = New System.Windows.Forms.DataGridView()
        Me.txtstnum = New System.Windows.Forms.TextBox()
        Me.txtissue = New System.Windows.Forms.TextBox()
        Me.txtbnumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgissue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(545, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 32)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Issue Date"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(545, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(271, 38)
        Me.txtName.TabIndex = 44
        '
        'txtBname
        '
        Me.txtBname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBname.Location = New System.Drawing.Point(275, 197)
        Me.txtBname.Name = "txtBname"
        Me.txtBname.Size = New System.Drawing.Size(243, 38)
        Me.txtBname.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(275, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 32)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Book Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(545, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 32)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Student Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(275, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 32)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Student Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 32)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Issue Number"
        '
        'date1
        '
        Me.date1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.date1.Location = New System.Drawing.Point(545, 197)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(271, 38)
        Me.date1.TabIndex = 48
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnreset.Location = New System.Drawing.Point(972, 184)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(204, 52)
        Me.btnreset.TabIndex = 51
        Me.btnreset.Text = "reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(972, 87)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(204, 56)
        Me.btnAdd.TabIndex = 49
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dgissue
        '
        Me.dgissue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgissue.Location = New System.Drawing.Point(12, 335)
        Me.dgissue.Name = "dgissue"
        Me.dgissue.RowHeadersWidth = 51
        Me.dgissue.RowTemplate.Height = 29
        Me.dgissue.Size = New System.Drawing.Size(1308, 356)
        Me.dgissue.TabIndex = 53
        '
        'txtstnum
        '
        Me.txtstnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtstnum.Location = New System.Drawing.Point(275, 70)
        Me.txtstnum.Name = "txtstnum"
        Me.txtstnum.Size = New System.Drawing.Size(243, 38)
        Me.txtstnum.TabIndex = 54
        '
        'txtissue
        '
        Me.txtissue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtissue.Location = New System.Drawing.Point(12, 70)
        Me.txtissue.Name = "txtissue"
        Me.txtissue.Size = New System.Drawing.Size(243, 38)
        Me.txtissue.TabIndex = 55
        '
        'txtbnumber
        '
        Me.txtbnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbnumber.Location = New System.Drawing.Point(12, 198)
        Me.txtbnumber.Name = "txtbnumber"
        Me.txtbnumber.Size = New System.Drawing.Size(243, 38)
        Me.txtbnumber.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 32)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Book Number"
        '
        'Issue_Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1332, 703)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtbnumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtissue)
        Me.Controls.Add(Me.txtstnum)
        Me.Controls.Add(Me.dgissue)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.date1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtBname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Issue_Books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issue_Books"
        CType(Me.dgissue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents date1 As DateTimePicker
    Friend WithEvents btnreset As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgissue As DataGridView
    Friend WithEvents txtstnum As TextBox
    Friend WithEvents txtissue As TextBox
    Friend WithEvents txtbnumber As TextBox
    Friend WithEvents Label1 As Label
End Class
