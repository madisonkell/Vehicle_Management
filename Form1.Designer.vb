<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.grpOwnerInfo = New System.Windows.Forms.GroupBox()
        Me.btnCancelAdd = New System.Windows.Forms.Button()
        Me.btnSaveAdd = New System.Windows.Forms.Button()
        Me.btnCancelUpdate = New System.Windows.Forms.Button()
        Me.btnSaveUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnLastRecord = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRightArrow = New System.Windows.Forms.Button()
        Me.btnLeftArrow = New System.Windows.Forms.Button()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOwnerInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Enabled = False
        Me.dgvResults.Location = New System.Drawing.Point(8, 262)
        Me.dgvResults.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.RowHeadersWidth = 51
        Me.dgvResults.RowTemplate.Height = 24
        Me.dgvResults.Size = New System.Drawing.Size(549, 227)
        Me.dgvResults.TabIndex = 0
        '
        'grpOwnerInfo
        '
        Me.grpOwnerInfo.Controls.Add(Me.btnCancelAdd)
        Me.grpOwnerInfo.Controls.Add(Me.btnSaveAdd)
        Me.grpOwnerInfo.Controls.Add(Me.btnCancelUpdate)
        Me.grpOwnerInfo.Controls.Add(Me.btnSaveUpdate)
        Me.grpOwnerInfo.Controls.Add(Me.btnDelete)
        Me.grpOwnerInfo.Controls.Add(Me.btnUpdate)
        Me.grpOwnerInfo.Controls.Add(Me.btnLastRecord)
        Me.grpOwnerInfo.Controls.Add(Me.btnAdd)
        Me.grpOwnerInfo.Controls.Add(Me.btnRightArrow)
        Me.grpOwnerInfo.Controls.Add(Me.btnLeftArrow)
        Me.grpOwnerInfo.Controls.Add(Me.btnFirstRecord)
        Me.grpOwnerInfo.Controls.Add(Me.txtIDNumber)
        Me.grpOwnerInfo.Controls.Add(Me.Label3)
        Me.grpOwnerInfo.Controls.Add(Me.Label2)
        Me.grpOwnerInfo.Controls.Add(Me.lblName)
        Me.grpOwnerInfo.Controls.Add(Me.txtZip)
        Me.grpOwnerInfo.Controls.Add(Me.txtState)
        Me.grpOwnerInfo.Controls.Add(Me.txtCity)
        Me.grpOwnerInfo.Controls.Add(Me.txtStreetAddress)
        Me.grpOwnerInfo.Controls.Add(Me.txtLastName)
        Me.grpOwnerInfo.Controls.Add(Me.txtFirstName)
        Me.grpOwnerInfo.Location = New System.Drawing.Point(8, 10)
        Me.grpOwnerInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.grpOwnerInfo.Name = "grpOwnerInfo"
        Me.grpOwnerInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.grpOwnerInfo.Size = New System.Drawing.Size(549, 248)
        Me.grpOwnerInfo.TabIndex = 3
        Me.grpOwnerInfo.TabStop = False
        Me.grpOwnerInfo.Text = "Owner Information:"
        '
        'btnCancelAdd
        '
        Me.btnCancelAdd.Location = New System.Drawing.Point(287, 183)
        Me.btnCancelAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelAdd.Name = "btnCancelAdd"
        Me.btnCancelAdd.Size = New System.Drawing.Size(121, 50)
        Me.btnCancelAdd.TabIndex = 21
        Me.btnCancelAdd.Text = "Cancel"
        Me.btnCancelAdd.UseVisualStyleBackColor = True
        '
        'btnSaveAdd
        '
        Me.btnSaveAdd.Location = New System.Drawing.Point(146, 183)
        Me.btnSaveAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveAdd.Name = "btnSaveAdd"
        Me.btnSaveAdd.Size = New System.Drawing.Size(121, 50)
        Me.btnSaveAdd.TabIndex = 20
        Me.btnSaveAdd.Text = "Save"
        Me.btnSaveAdd.UseVisualStyleBackColor = True
        '
        'btnCancelUpdate
        '
        Me.btnCancelUpdate.Location = New System.Drawing.Point(287, 183)
        Me.btnCancelUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelUpdate.Name = "btnCancelUpdate"
        Me.btnCancelUpdate.Size = New System.Drawing.Size(121, 50)
        Me.btnCancelUpdate.TabIndex = 18
        Me.btnCancelUpdate.Text = "Cancel"
        Me.btnCancelUpdate.UseVisualStyleBackColor = True
        '
        'btnSaveUpdate
        '
        Me.btnSaveUpdate.Location = New System.Drawing.Point(146, 183)
        Me.btnSaveUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveUpdate.Name = "btnSaveUpdate"
        Me.btnSaveUpdate.Size = New System.Drawing.Size(106, 50)
        Me.btnSaveUpdate.TabIndex = 17
        Me.btnSaveUpdate.Text = "Save"
        Me.btnSaveUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(218, 125)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 50)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(324, 125)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 50)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnLastRecord
        '
        Me.btnLastRecord.Location = New System.Drawing.Point(498, 125)
        Me.btnLastRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLastRecord.Name = "btnLastRecord"
        Me.btnLastRecord.Size = New System.Drawing.Size(41, 50)
        Me.btnLastRecord.TabIndex = 14
        Me.btnLastRecord.Text = "|>"
        Me.btnLastRecord.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(112, 125)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(102, 50)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRightArrow
        '
        Me.btnRightArrow.Location = New System.Drawing.Point(452, 125)
        Me.btnRightArrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRightArrow.Name = "btnRightArrow"
        Me.btnRightArrow.Size = New System.Drawing.Size(42, 50)
        Me.btnRightArrow.TabIndex = 12
        Me.btnRightArrow.Text = ">>"
        Me.btnRightArrow.UseVisualStyleBackColor = True
        '
        'btnLeftArrow
        '
        Me.btnLeftArrow.Location = New System.Drawing.Point(55, 125)
        Me.btnLeftArrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLeftArrow.Name = "btnLeftArrow"
        Me.btnLeftArrow.Size = New System.Drawing.Size(42, 50)
        Me.btnLeftArrow.TabIndex = 11
        Me.btnLeftArrow.Text = "<<"
        Me.btnLeftArrow.UseVisualStyleBackColor = True
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.Location = New System.Drawing.Point(9, 125)
        Me.btnFirstRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(42, 50)
        Me.btnFirstRecord.TabIndex = 10
        Me.btnFirstRecord.Text = "<|"
        Me.btnFirstRecord.UseVisualStyleBackColor = True
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(493, 24)
        Me.txtIDNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(45, 20)
        Me.txtIDNumber.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(428, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ID Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Address:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(4, 27)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(345, 89)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(194, 20)
        Me.txtZip.TabIndex = 5
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(271, 89)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(71, 20)
        Me.txtState.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(55, 89)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(212, 20)
        Me.txtCity.TabIndex = 3
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(55, 55)
        Me.txtStreetAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(483, 20)
        Me.txtStreetAddress.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(248, 24)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(176, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(55, 24)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(189, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 499)
        Me.Controls.Add(Me.grpOwnerInfo)
        Me.Controls.Add(Me.dgvResults)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Databases!"
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOwnerInfo.ResumeLayout(False)
        Me.grpOwnerInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents grpOwnerInfo As GroupBox
    Friend WithEvents btnFirstRecord As Button
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnLastRecord As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRightArrow As Button
    Friend WithEvents btnLeftArrow As Button
    Friend WithEvents btnCancelUpdate As Button
    Friend WithEvents btnSaveUpdate As Button
    Friend WithEvents btnSaveAdd As Button
    Friend WithEvents btnCancelAdd As Button
End Class
