Option Strict On
Option Explicit On

'Author: Casey Bement
'Date: 09/29/2021
'Program: Calorie Calculator

Public Class frmCalorieCalculator

    Private Sub BMICalculator_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Populate combo boxes
        Me.cboSex.Items.Add("Male")
        Me.cboSex.Items.Add("Female")
        Me.cboSex.SelectedIndex = 0

        Me.cboAct.Items.Add("Sitting or Lying all day")
        Me.cboAct.Items.Add("Seated work, no exercise")
        Me.cboAct.Items.Add("Seated work, light exercise")
        Me.cboAct.Items.Add("Moderately physical work, no exercise")
        Me.cboAct.Items.Add("Moderately physical work, light exercise")
        Me.cboAct.Items.Add("Moderately physical work, heavy exercise")
        Me.cboAct.Items.Add("Heavy work or Heavy Exercise")
        Me.cboAct.SelectedIndex = 0


    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Declare Variables
        Dim decUserAge As Decimal
        Dim decUserHeight As Decimal
        Dim decUserWeight As Decimal

        Dim blnValidAge As Boolean
        Dim blnValidHeight As Boolean
        Dim blnValidWeight As Boolean

        Dim decRMRTotal As Decimal

        'Assign inputs
        blnValidAge = Decimal.TryParse(txtAge.Text, decUserAge)
        blnValidHeight = Decimal.TryParse(txtHeight.Text, decUserHeight)
        blnValidWeight = Decimal.TryParse(txtWeight.Text, decUserWeight)

        'Validate inputs

        If blnValidAge And blnValidHeight And blnValidWeight Then

            'RMR calculation by sex
            Dim strUserSex As String = cboSex.SelectedItem.ToString()

            If strUserSex = "Male" Then
                decRMRTotal = (88.4D + 13.4D * (decUserWeight * 0.453592D)) + (4.8D * (decUserHeight * 2.54D)) - (5.68D * decUserAge)
            Else strUserSex = "Female"
                decRMRTotal = (447.6D + 9.25D * (decUserWeight * 0.453592D)) + (3.1D * (decUserHeight * 2.54D)) - (4.33D * decUserAge)
            End If

            Me.lblResult.Text = "Base RMR is " & decRMRTotal.ToString

            'RMR calculation by Activity Level 
            Dim strUserActivity As String = cboAct.SelectedItem.ToString()

            If strUserActivity = "Sitting or Lying all day" Then
                decRMRTotal *= 1.2D
            ElseIf strUserActivity = "Seated work, no exercise" Then
                decRMRTotal *= 1.3D
            ElseIf strUserActivity = "Seated work, light exercise" Then
                decRMRTotal *= 1.4D
            ElseIf strUserActivity = "Moderately physical work, no exercise" Then
                decRMRTotal *= 1.5D
            ElseIf strUserActivity = "Moderately physical work, light exercise" Then
                decRMRTotal *= 1.6D
            ElseIf strUserActivity = "Moderately physical work, heavy exercise" Then
                decRMRTotal *= 1.7D
            ElseIf strUserActivity = "Heavy work or Heavy Exercise" Then
                decRMRTotal *= 1.8D
            End If

            Me.lblResult.Text = Me.lblResult.Text & " and with Activity " & decRMRTotal.ToString & "."

        Else
            Me.lblResult.Text = "Your Age, Height, or Weight is not numberic."
        End If


    End Sub

    'Clear Results
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear input and output fields

        Me.lblResult.Text = String.Empty
        Me.txtAge.Text = String.Empty
        Me.txtHeight.Text = String.Empty
        Me.txtWeight.Text = String.Empty
        Me.lblResult.Text = String.Empty
        Me.cboSex.SelectedIndex = 0
        Me.cboAct.SelectedIndex = 0

    End Sub


End Class
