
'Author: Jaylan McGowan
'Since: March 6, 2018
'Description: Program used to calculate the average of units shipped for 3 employees and the average of the average units
'Project Name: AverageUnitsShippedByEmployee.vb


Option Strict On

Public Class frmAverageUnitsShippedByEmployee

    'Constants Declarations
    Private Const rangeMinimum As Integer = 0
    Private Const rangeMaximum As Integer = 1000
    Private Const daysOfAWeek As Integer = 7
    Private Const lastRowArrayIndex As Integer = 6
    Private Const lastColumnArrayIndex As Integer = 2

    'Integer and Double Declarations
    Private employeeUnits(lastColumnArrayIndex, lastRowArrayIndex) As Integer
    Private dayCounter As Integer = 0
    Private employeeCounter As Integer = 0
    Private employeeAverageOne As Double = 0.0
    Private employeeAverageTwo As Double = 0.0
    Private employeeAverageThree As Double = 0.0
    Private companyAverage As Double = 0.0
    Private totalUnits As Double = 0.0
    Private validInput As Integer = 0

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click



        'String Declarations
        Dim employeeOneString As String = String.Empty
        Dim employeeTwoString As String = String.Empty
        Dim employeeThreeString As String = String.Empty




        If InputValidation(tbUnitEntry.Text, validInput) Then  'if the input is valid, then the program continues


            employeeUnits(employeeCounter, dayCounter) = validInput 'Sets the indexes to the validated input each time


            lbDayNumber.Text = "Day 1"
            dayCounter += 1
            tbUnitEntry.Text = "" 'Sets focus and clears the input textbox everytime new data is entered
            tbUnitEntry.Focus()
            lbDayNumber.Text = "Day " & (dayCounter + 1) 'increases the day number by one each time


            If dayCounter = 7 AndAlso employeeCounter = 0 Then

                lbDayNumber.Text = "Day 1"

                For counter As Integer = 0 To 6

                    employeeAverageOne += employeeUnits(employeeCounter, counter) 'calculates the average 

                Next counter
                employeeAverageOne /= daysOfAWeek

                lbEmployeeAverageOne.Text = "Average: " & Math.Round(employeeAverageOne, 2) 'and displays it for employee 1

                totalUnits += employeeAverageOne 'adds the average to totalUnits

                dayCounter = 0     'sets dayCounter to 0 and adds 1 to employeeCounter for the next employee's data
                employeeCounter += 1
            End If





            If dayCounter = 7 AndAlso employeeCounter = 1 Then

                lbDayNumber.Text = "Day 1"

                For counter As Integer = 0 To 6

                    employeeAverageTwo += employeeUnits(employeeCounter, counter) 'calculates the average 

                Next counter
                employeeAverageTwo /= daysOfAWeek


                lbEmployeeAverageTwo.Text = "Average: " & Math.Round(employeeAverageTwo, 2) 'and displays it for employee 2

                totalUnits += employeeAverageTwo

                dayCounter = 0    'sets dayCounter to 0 and adds to employeeCounter for the next employee's data
                employeeCounter += 1
            End If




            If dayCounter = 7 AndAlso employeeCounter = 2 Then

                lbDayNumber.Text = "Day 1"

                For counter As Integer = 0 To 6

                    employeeAverageThree += employeeUnits(employeeCounter, counter) 'calculates the average 

                Next counter
                employeeAverageThree /= daysOfAWeek

                lbEmployeeAverageThree.Text = "Average: " & Math.Round(employeeAverageThree, 2) 'and displays it for employee 3

                totalUnits += employeeAverageThree

                dayCounter = 0      'sets dayCounter to 0 and adds to employeeCounter for the next employee's data
                employeeCounter += 1
            End If


        End If

        If employeeCounter = 3 Then 'Once this counter reaches 3, the enter button and input textbox are disabled and the overall average is calculated
            btnEnter.Enabled = False
            tbUnitEntry.ReadOnly = True
            companyAverage = totalUnits / 3
            lbEmployeeTotalAverage.Text = "Average per day: " & Math.Round(companyAverage, 2)
        End If

        If employeeCounter = 0 Then
            employeeOneString += validInput & vbCrLf 'Skips the line for separate viewable input each time for the first display textbox

        End If
        tbEmployeeOneDisplay.Text += validInput & vbCrLf

        If employeeCounter = 1 Then

            employeeTwoString += validInput & vbCrLf        'Skips the line for separate viewable input each time for the second display textbox
            tbEmployeeTwoDisplay.Text += validInput & vbCrLf
        End If


        If employeeCounter = 2 Then

            employeeThreeString += validInput & vbCrLf         'Skips the line for separate viewable input each time for the third display textbox
            tbEmployeeThreeDisplay.Text += validInput & vbCrLf
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        btnEnter.Enabled = True
        tbUnitEntry.ReadOnly = False

        tbUnitEntry.Focus()              'Empties all labels and textboxes, sets lbDayNumber's text to Day 1
        lbDayNumber.Text = "Day 1"
        lbEmployeeAverageOne.Text = ""
        lbEmployeeAverageTwo.Text = ""
        lbEmployeeAverageThree.Text = ""
        tbEmployeeOneDisplay.Text = ""
        tbEmployeeTwoDisplay.Text = ""
        tbEmployeeThreeDisplay.Text = ""
        lbEmployeeTotalAverage.Text = ""

        Array.Clear(employeeUnits, lastColumnArrayIndex, lastRowArrayIndex) 'clears all indexes of this array

        dayCounter = 0              'sets the value of these counters and averages to 0 for new data
        employeeCounter = 0
        employeeAverageOne = 0.0
        employeeAverageTwo = 0.0
        employeeAverageThree = 0.0
        companyAverage = 0.0
        totalUnits = 0.0
        validInput = 0



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Function InputValidation(ByVal userInput As String, ByRef validUserInput As Integer) As Boolean

        Dim returnValue As Boolean = True

        Dim inputInteger As Integer = 0

        If Integer.TryParse(userInput, inputInteger) AndAlso
            (inputInteger >= rangeMinimum And inputInteger <= rangeMaximum) Then  'checks if the input value is within range and is an actual number

            returnValue = True


            validUserInput = inputInteger 'if user input is valid the number may be used and is set to the inputted string

        Else

            returnValue = False

            validUserInput = 0   'displays an error message if the input failed to validate

            MessageBox.Show("Input must be a valid number between " & rangeMinimum.ToString("n2") & " and " & rangeMaximum.ToString("n2") & "!")

        End If

        Return returnValue 'returns valid input to calling code

    End Function
End Class
