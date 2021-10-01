'Author: Casey Bement
'Purpose: Manage a User
'Date: 09/29/2021

Option Strict On
Option Explicit On

Public Class User
    Private mstrName As String
    Private mdecHeight As Decimal
    Private mdecWeight As Decimal
    Private mdecAge As Decimal
    Private mstrGender As String
    Private mdecActivityLevel As Decimal
    Private mdecBMR As Decimal
    Private mdecActivityMR As Decimal
    Private mstrActivity As String
    Private mdecBodyFatPercent As Decimal
    Private mdecBodyFatWeight As Decimal
    Private mdecLeanBodyMass As Decimal
    Private mdecWaist As Decimal
    Private mdecWrist As Decimal
    Private mdecHip As Decimal
    Private mdecForearm As Decimal
    Private mlstStats As List(Of Integer)


    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)
            mstrName = value
        End Set
    End Property

    Public Property Height As Decimal
        Get
            Return mdecHeight
        End Get
        Set(value As Decimal)
            mdecHeight = value
        End Set
    End Property

    Public Property Weight As Decimal
        Get
            Return mdecWeight
        End Get
        Set(value As Decimal)
            mdecWeight = value
        End Set
    End Property

    Public Property Age As Decimal
        Get
            Return mdecAge
        End Get
        Set(value As Decimal)
            mdecAge = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return mstrGender
        End Get
        Set(value As String)
            mstrGender = value
        End Set
    End Property

    Public Property ActivityLevel As Decimal
        Get
            Return mdecActivityLevel
        End Get
        Set(value As Decimal)
            mdecActivityLevel = value
        End Set
    End Property

    Public Property BMR As Decimal
        Get
            Return mdecBMR
        End Get
        Set(value As Decimal)
            mdecBMR = value
        End Set
    End Property

    Public Property ActivityMR As Decimal
        Get
            Return mdecActivityMR
        End Get
        Set(value As Decimal)
            mdecActivityMR = value
        End Set
    End Property

    Public Property Activity As String
        Get
            Return mstrActivity
        End Get
        Set(value As String)
            mstrActivity = value
        End Set
    End Property

    Public Property BodyFatPercent As Decimal
        Get
            Return mdecBodyFatPercent
        End Get
        Set(value As Decimal)
            mdecBodyFatPercent = value
        End Set
    End Property

    Public Property BodyFatWeight As Decimal
        Get
            Return mdecBodyFatWeight
        End Get
        Set(value As Decimal)
            mdecBodyFatWeight = value
        End Set
    End Property

    Public Property LeanBodyMass As Decimal
        Get
            Return mdecLeanBodyMass
        End Get
        Set(value As Decimal)
            mdecLeanBodyMass = value
        End Set
    End Property

    Public Property Waist As Decimal
        Get
            Return mdecWaist
        End Get
        Set(value As Decimal)
            mdecWaist = value
        End Set
    End Property

    Public Property Wrist As Decimal
        Get
            Return mdecWrist
        End Get
        Set(value As Decimal)
            mdecWrist = value
        End Set
    End Property

    Public Property Hip As Decimal
        Get
            Return mdecHip
        End Get
        Set(value As Decimal)
            mdecHip = value
        End Set
    End Property

    Public Property Forearm As Decimal
        Get
            Return mdecForearm
        End Get
        Set(value As Decimal)
            mdecForearm = value
        End Set
    End Property

    Public Property Stats As List(Of Integer)
        Get
            Return mlstStats
        End Get
        Set(value As List(Of Integer))
            mlstStats = value
        End Set
    End Property

    Public Sub New()
        mstrName = String.Empty
        mdecHeight = 0
        mdecWeight = 0
        mdecAge = 0
        mstrGender = String.Empty
        mdecBMR = 0
        mdecActivityMR = 0
        mstrActivity = ""
        mdecBodyFatPercent = 0
        mdecForearm = 0
        mlstStats = New List(Of Integer)
    End Sub

    Public Function NameAndGender() As String
        Return Name & " " & Gender
    End Function
End Class
