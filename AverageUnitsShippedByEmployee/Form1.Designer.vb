<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.lbDayNumber = New System.Windows.Forms.Label()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.tbUnitEntry = New System.Windows.Forms.TextBox()
        Me.lbEmployeeOne = New System.Windows.Forms.Label()
        Me.lbEmployeeTwo = New System.Windows.Forms.Label()
        Me.lbEmployeeThree = New System.Windows.Forms.Label()
        Me.tbEmployeeOneDisplay = New System.Windows.Forms.TextBox()
        Me.tbEmployeeTwoDisplay = New System.Windows.Forms.TextBox()
        Me.tbEmployeeThreeDisplay = New System.Windows.Forms.TextBox()
        Me.lbEmployeeAverageOne = New System.Windows.Forms.Label()
        Me.lbEmployeeAverageTwo = New System.Windows.Forms.Label()
        Me.lbEmployeeAverageThree = New System.Windows.Forms.Label()
        Me.lbEmployeeTotalAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedByEmployeeTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbDayNumber
        '
        Me.lbDayNumber.Location = New System.Drawing.Point(11, 9)
        Me.lbDayNumber.Name = "lbDayNumber"
        Me.lbDayNumber.Size = New System.Drawing.Size(39, 13)
        Me.lbDayNumber.TabIndex = 0
        Me.lbDayNumber.Text = "Day 1"
        Me.lbDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(11, 34)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(34, 13)
        Me.lbUnits.TabIndex = 1
        Me.lbUnits.Text = "&Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbUnitEntry
        '
        Me.tbUnitEntry.Location = New System.Drawing.Point(51, 31)
        Me.tbUnitEntry.Name = "tbUnitEntry"
        Me.tbUnitEntry.Size = New System.Drawing.Size(100, 20)
        Me.tbUnitEntry.TabIndex = 2
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.tbUnitEntry, "Enter units of each day for each employee")
        '
        'lbEmployeeOne
        '
        Me.lbEmployeeOne.Location = New System.Drawing.Point(42, 67)
        Me.lbEmployeeOne.Name = "lbEmployeeOne"
        Me.lbEmployeeOne.Size = New System.Drawing.Size(62, 13)
        Me.lbEmployeeOne.TabIndex = 3
        Me.lbEmployeeOne.Text = "Employee 1"
        Me.lbEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployeeTwo
        '
        Me.lbEmployeeTwo.Location = New System.Drawing.Point(140, 67)
        Me.lbEmployeeTwo.Name = "lbEmployeeTwo"
        Me.lbEmployeeTwo.Size = New System.Drawing.Size(62, 13)
        Me.lbEmployeeTwo.TabIndex = 4
        Me.lbEmployeeTwo.Text = "Employee 2"
        Me.lbEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployeeThree
        '
        Me.lbEmployeeThree.Location = New System.Drawing.Point(246, 67)
        Me.lbEmployeeThree.Name = "lbEmployeeThree"
        Me.lbEmployeeThree.Size = New System.Drawing.Size(62, 13)
        Me.lbEmployeeThree.TabIndex = 5
        Me.lbEmployeeThree.Text = "Employee 3"
        Me.lbEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbEmployeeOneDisplay
        '
        Me.tbEmployeeOneDisplay.Location = New System.Drawing.Point(19, 83)
        Me.tbEmployeeOneDisplay.Multiline = True
        Me.tbEmployeeOneDisplay.Name = "tbEmployeeOneDisplay"
        Me.tbEmployeeOneDisplay.Size = New System.Drawing.Size(100, 103)
        Me.tbEmployeeOneDisplay.TabIndex = 6
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.tbEmployeeOneDisplay, "Displays all the units for each day for employee one")
        '
        'tbEmployeeTwoDisplay
        '
        Me.tbEmployeeTwoDisplay.Location = New System.Drawing.Point(124, 83)
        Me.tbEmployeeTwoDisplay.Multiline = True
        Me.tbEmployeeTwoDisplay.Name = "tbEmployeeTwoDisplay"
        Me.tbEmployeeTwoDisplay.Size = New System.Drawing.Size(100, 103)
        Me.tbEmployeeTwoDisplay.TabIndex = 7
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.tbEmployeeTwoDisplay, "Displays all the units for each day for employee two")
        '
        'tbEmployeeThreeDisplay
        '
        Me.tbEmployeeThreeDisplay.Location = New System.Drawing.Point(231, 83)
        Me.tbEmployeeThreeDisplay.Multiline = True
        Me.tbEmployeeThreeDisplay.Name = "tbEmployeeThreeDisplay"
        Me.tbEmployeeThreeDisplay.Size = New System.Drawing.Size(100, 103)
        Me.tbEmployeeThreeDisplay.TabIndex = 8
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.tbEmployeeThreeDisplay, "Displays all the units for each day for employee three")
        '
        'lbEmployeeAverageOne
        '
        Me.lbEmployeeAverageOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeAverageOne.Location = New System.Drawing.Point(19, 189)
        Me.lbEmployeeAverageOne.Name = "lbEmployeeAverageOne"
        Me.lbEmployeeAverageOne.Size = New System.Drawing.Size(100, 16)
        Me.lbEmployeeAverageOne.TabIndex = 9
        Me.lbEmployeeAverageOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lbEmployeeAverageOne, "Output label for the average of employee one")
        '
        'lbEmployeeAverageTwo
        '
        Me.lbEmployeeAverageTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeAverageTwo.Location = New System.Drawing.Point(125, 189)
        Me.lbEmployeeAverageTwo.Name = "lbEmployeeAverageTwo"
        Me.lbEmployeeAverageTwo.Size = New System.Drawing.Size(100, 16)
        Me.lbEmployeeAverageTwo.TabIndex = 10
        Me.lbEmployeeAverageTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lbEmployeeAverageTwo, "Output label for the average of employee two")
        '
        'lbEmployeeAverageThree
        '
        Me.lbEmployeeAverageThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeAverageThree.Location = New System.Drawing.Point(232, 189)
        Me.lbEmployeeAverageThree.Name = "lbEmployeeAverageThree"
        Me.lbEmployeeAverageThree.Size = New System.Drawing.Size(100, 16)
        Me.lbEmployeeAverageThree.TabIndex = 11
        Me.lbEmployeeAverageThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lbEmployeeAverageThree, "Output label for the average of employee three")
        '
        'lbEmployeeTotalAverage
        '
        Me.lbEmployeeTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeTotalAverage.Location = New System.Drawing.Point(19, 211)
        Me.lbEmployeeTotalAverage.Name = "lbEmployeeTotalAverage"
        Me.lbEmployeeTotalAverage.Size = New System.Drawing.Size(315, 16)
        Me.lbEmployeeTotalAverage.TabIndex = 12
        Me.lbEmployeeTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lbEmployeeTotalAverage, "Ouput label for the overall company average")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(19, 234)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 30)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnEnter, "Click this button to calculate the total average")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(124, 234)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(101, 30)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnReset, "Click this button to reset all data on the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 234)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnExit, "Click this button to exit this program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(350, 267)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbEmployeeTotalAverage)
        Me.Controls.Add(Me.lbEmployeeAverageThree)
        Me.Controls.Add(Me.lbEmployeeAverageTwo)
        Me.Controls.Add(Me.lbEmployeeAverageOne)
        Me.Controls.Add(Me.tbEmployeeThreeDisplay)
        Me.Controls.Add(Me.tbEmployeeTwoDisplay)
        Me.Controls.Add(Me.tbEmployeeOneDisplay)
        Me.Controls.Add(Me.lbEmployeeThree)
        Me.Controls.Add(Me.lbEmployeeTwo)
        Me.Controls.Add(Me.lbEmployeeOne)
        Me.Controls.Add(Me.tbUnitEntry)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.lbDayNumber)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(366, 306)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(366, 306)
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDayNumber As Label
    Friend WithEvents lbUnits As Label
    Friend WithEvents tbUnitEntry As TextBox
    Friend WithEvents lbEmployeeOne As Label
    Friend WithEvents lbEmployeeTwo As Label
    Friend WithEvents lbEmployeeThree As Label
    Friend WithEvents tbEmployeeOneDisplay As TextBox
    Friend WithEvents tbEmployeeTwoDisplay As TextBox
    Friend WithEvents tbEmployeeThreeDisplay As TextBox
    Friend WithEvents lbEmployeeAverageOne As Label
    Friend WithEvents lbEmployeeAverageTwo As Label
    Friend WithEvents lbEmployeeAverageThree As Label
    Friend WithEvents lbEmployeeTotalAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AverageUnitsShippedByEmployeeTips As ToolTip
End Class
