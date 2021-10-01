Option Strict On
Option Explicit On

'Author: Casey Bement
'Date: 09/29/2021
'Program: Calorie Calculator
Imports System.ComponentModel

Public Class frmCalorieCalculator

    Dim lstUser As New BindingList(Of User)
    Dim objSelectedUser As User
    Private Sub BMICalculator_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Create Variables
        Dim strName As String

        'Populate combo boxes
        Me.cboMetricImperial.Items.Add("Imperial")
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



        'Set User bindiing list to listbox
        lbxUsers.DataSource = lstUser
        lbxUsers.DisplayMember = "Name"

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Instatiate a new User
        Dim objUser As New User()



        'Declare Variables
        Dim decUserAge As Decimal
        Dim decUserHeight As Decimal
        Dim decUserWeight As Decimal
        Dim strName As String
        Dim strGender As String
        Dim strActivityLevel As String
        Dim decBMR As Decimal
        Dim decActivityMR As Decimal
        Dim decActivity As Decimal
        Dim decBodyFatPercent As Double
        Dim decWaist As Decimal
        Dim decWrist As Decimal
        Dim decHip As Decimal
        Dim decForearm As Decimal
        Dim lstStats As List(Of Integer)
        Dim factorOne As Decimal = (decUserWeight * 0.732D) + 9.987D
        Dim factorTwo As Decimal = decWrist / 3.14D
        Dim factorThree As Decimal = decWaist * 0.157D
        Dim factorFour As Decimal = decHip * 0.249D
        Dim factorFive As Decimal = decForearm * 0.434D
        Dim leanBodyMass As Decimal
        Dim bodyFatWeight As Decimal


        Dim blnValidAge As Boolean
        Dim blnValidHeight As Boolean
        Dim blnValidWeight As Boolean

        Dim decRMRTotal As Decimal

        'Populate new characters properties
        objUser.Name = txtName.Text
        objUser.Age = CType(txtAge.Text, Decimal)
        objUser.Height = CType(txtHeight.Text, Decimal)
        objUser.Weight = CType(txtWeight.Text, Decimal)
        objUser.Gender = cboSex.SelectedItem.ToString
        objUser.Activity = cboAct.SelectedItem.ToString
        objUser.Waist = CType(txtWaist.Text, Decimal)
        objUser.Hip = CType(txtHip.Text, Decimal)
        objUser.Forearm = CType(txtForearm.Text, Decimal)

        'Add new User to list of Users
        lstUser.Add(objUser)
        'Make new user the selected user
        objSelectedUser = objUser
        'Select the current user in the listbox
        lbxUsers.SelectedItem = objUser

        'Clear Stats
        objSelectedUser.Stats.Clear()

        'Assign inputs
        blnValidAge = Decimal.TryParse(txtAge.Text, decUserAge)
        blnValidHeight = Decimal.TryParse(txtHeight.Text, decUserHeight)
        blnValidWeight = Decimal.TryParse(txtWeight.Text, decUserWeight)




        'Validate inputs

        If blnValidAge And blnValidHeight And blnValidWeight Then

            'BMR calculation by sex
            Dim strUserSex As String = cboSex.SelectedItem.ToString()

            If strUserSex = "Male" Then
                objSelectedUser.BMR = (655D + (4.35D * decUserWeight) + (4.7D * decUserHeight) - (4.7D * objSelectedUser.Age))
                objSelectedUser.LeanBodyMass = factorOne - factorTwo
                objSelectedUser.BodyFatWeight = objSelectedUser.Weight - objSelectedUser.LeanBodyMass
                objSelectedUser.BodyFatPercent = (objSelectedUser.BodyFatWeight * 100) / objSelectedUser.Weight
            Else strUserSex = "Female"
                objSelectedUser.BMR = (655D + (4.35D * decUserWeight) + (4.7D * decUserHeight) - (4.7D * objSelectedUser.Age))
                objSelectedUser.LeanBodyMass = factorOne - factorTwo
                objSelectedUser.BodyFatWeight = objSelectedUser.Weight - objSelectedUser.LeanBodyMass
                objSelectedUser.BodyFatPercent = (objSelectedUser.BodyFatWeight * 100) / objSelectedUser.Weight
            End If



            'BMR calculation by Activity Level 
            Dim strUserActivity As String = cboAct.SelectedItem.ToString()

            If strUserActivity = "Sitting or Lying all day" Then
                objSelectedUser.ActivityMR = objSelectedUser.BMR * 1.2D
            ElseIf strUserActivity = "Seated work, no exercise" Then
                objSelectedUser.ActivityMR = objSelectedUser.BMR * 1.3D
            ElseIf strUserActivity = "Seated work, light exercise" Then
                objSelectedUser.ActivityMR = objSelectedUser.BMR * 1.4D
            ElseIf strUserActivity = "Moderately physical work, no exercise" Then
                objSelectedUser.ActivityMR = objSelectedUser.BMR * 1.5D
            ElseIf strUserActivity = "Moderately physical work, light exercise" Then
                objSelectedUser.ActivityMR = objSelectedUser.BMR * 1.6D
            ElseIf strUserActivity = "Moderately physical work, heavy exercise" Then
                objSelectedUser.ActivityMR = objSelectedUser.BMR * 1.7D
            ElseIf strUserActivity = "Heavy work or Heavy Exercise" Then
                objSelectedUser.ActivityMR = objSelectedUser.BMR * 1.8D
            End If

        End If

        Call DisplayStats()

    End Sub

    Private Sub DisplayStats()
        'Output Stat Results
        If Not objSelectedUser Is Nothing Then
            lblCURName.Text = objSelectedUser.Name.ToString
            lblCURHeight.Text = objSelectedUser.Height.ToString
            lblCURWeight.Text = objSelectedUser.Weight.ToString
            lblCURAge.Text = objSelectedUser.Age.ToString
            lblCURGender.Text = objSelectedUser.Gender.ToString
            lblCURBMR.Text = objSelectedUser.BMR.ToString
            lblCURActivityMR.Text = objSelectedUser.ActivityMR.ToString
            lblCURActivity.Text = objSelectedUser.Activity.ToString
            lblCURBodyFatPercent.Text = objSelectedUser.BodyFatPercent.ToString
        Else
            lblCURName.Text = "*"
            lblCURHeight.Text = "*"
            lblCURWeight.Text = "*"
            lblCURAge.Text = "*"
            lblCURGender.Text = "*"
            lblCURBMR.Text = "*"
            lblCURActivityMR.Text = "*"
            lblCURActivity.Text = "*"
            lblCURBodyFatPercent.Text = "*"
        End If
    End Sub




    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Remove the selected Character
        lstUser.Remove(objSelectedUser)
        objSelectedUser = CType(lbxUsers.SelectedItem, User)
        DisplayStats()

        ' Me.lblResult.Text = String.Empty
        Me.txtAge.Text = String.Empty
        Me.txtHeight.Text = String.Empty
        Me.txtWeight.Text = String.Empty
        '  Me.lblResult.Text = String.Empty
        Me.cboSex.SelectedIndex = 0
        Me.cboAct.SelectedIndex = 0
        Me.txtWaist.Text = String.Empty
        Me.txtWrist.Text = String.Empty
        Me.txtHip.Text = String.Empty
        Me.txtForearm.Text = String.Empty

    End Sub

    Private Sub lbxUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxUsers.SelectedIndexChanged
        If Not lbxUsers.SelectedItem Is Nothing Then
            objSelectedUser = CType(lbxUsers.SelectedItem, User)
            DisplayStats()
        Else
            objSelectedUser = Nothing
            DisplayStats()
        End If
    End Sub


End Class
