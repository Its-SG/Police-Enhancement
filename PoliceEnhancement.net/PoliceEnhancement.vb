
Imports System.Windows.Forms
Imports GTA
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports Un4seen.Bass

Namespace SG_MODS

    Public Class Ped_Car_Manager
        Inherits Script

        Private a, b, c, d, f, g, h, arm, arm1, prop As Integer
        Private v, v2, v3, v4 As Vehicle
        Private pedmodel, vehmodel As Model
        Private sit2, weap, am As Integer
        Private heavystuff, prop2, armslot As String

        Public Sub New()
            Me.Interval = 10
        End Sub

        Public Shadows Sub KeyDown(ByVal sender As Object, ByVal e As GTA.KeyEventArgs) Handles MyBase.KeyDown

        End Sub

        Public Shadows Sub KeyUp(ByVal sender As Object, ByVal e As GTA.KeyEventArgs) Handles MyBase.KeyUp

        End Sub

        Public Sub SetPropIndex()

        End Sub

        Private taser As Integer

        Public Sub Ped()

            Try

                If Settings.GetValueString("Props", "Settings ON/OFF", "") = "" Then Settings.SetValue("Props", "Settings ON/OFF", "False")

                prop2 = Settings.GetValueString("Props", "Settings ON/OFF", "")

                If Settings.GetValueString("Armour", "Settings ON/OFF", "") = "" Then Settings.SetValue("Armour", "Settings ON/OFF", "False")

                armslot = Settings.GetValueString("Armour", "Settings ON/OFF", "")

                Dim wname As String = ""
                Dim wpid As Integer = 0

                Dim random10 As New Random

                If Settings.GetValueInteger("Stun Gun", "Settings ON/OFF", -1) = -1 Then Settings.SetValue("Stun Gun", "Settings ON/OFF", 4)

                taser = Settings.GetValueInteger("Stun Gun", "Settings ON/OFF", -1)
                Dim weap, weapp, weap1, weap2, weap3, weap4, weap5, weap6, weap7, weap8, weap9, weap10, weap11, weap12, weap13, weap14, weap15, weap16, weap17, weap18 As Integer

                If Settings.GetValueString("Weapons Spawn", "Settings ON/OFF", "NONE") = "NONE" Then Settings.SetValue("Weapons Spawn", "Settings ON/OFF", "False")

                Dim st As String = Settings.GetValueString("Weapons Spawn", "Settings ON/OFF", "NONE")
                Settings.Save()

                If st = "True" Then

                    'COPS
                    a += 1
                    If a = 10 Then a = 0

                    If a = 1 Then
                        If Settings.GetValueInteger("Weapon 1", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 1", "COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon Handgun 1", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 1", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 1", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 1", "COPS WEAPON SLOT", -1)
                    ElseIf a = 2 Then
                        If Settings.GetValueInteger("Weapon Handgun 2", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 2", "COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon 2", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 2", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 2", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 2", "COPS WEAPON SLOT", -1)
                    ElseIf a = 3 Then
                        If Settings.GetValueInteger("Weapon Handgun 3", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 3", "COPS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Weapon 3", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 3", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 3", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 3", "COPS WEAPON SLOT", -1)
                    ElseIf a = 4 Then
                        If Settings.GetValueInteger("Weapon 4", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 4", "COPS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Weapon Handgun 4", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 4", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 4", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 4", "COPS WEAPON SLOT", -1)
                    ElseIf a = 5 Then
                        If Settings.GetValueInteger("Weapon Handgun 5", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 5", "COPS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Weapon 5", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 5", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 5", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 5", "COPS WEAPON SLOT", -1)
                    ElseIf a = 6 Then
                        If Settings.GetValueInteger("Weapon 6", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 6", "COPS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Weapon Handgun 6", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 6", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 6", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 6", "COPS WEAPON SLOT", -1)
                    ElseIf a = 7 Then
                        If Settings.GetValueInteger("Weapon 7", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 7", "COPS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Weapon Handgun 7", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 7", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 7", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 7", "COPS WEAPON SLOT", -1)
                    ElseIf a = 8 Then
                        If Settings.GetValueInteger("Weapon 8", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 8", "COPS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Weapon Handgun 8", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 8", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 8", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 8", "COPS WEAPON SLOT", -1)
                    ElseIf a = 9 Then
                        If Settings.GetValueInteger("Weapon 9", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 9", "COPS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Weapon Handgun 9", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 9", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 9", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 9", "COPS WEAPON SLOT", -1)
                    ElseIf a = 0 Then
                        If Settings.GetValueInteger("Weapon 10", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 10", "COPS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Weapon Handgun 10", "COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 10", "COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weap1 = Settings.GetValueInteger("Weapon 10", "COPS WEAPON SLOT", -1)
                        weap = Settings.GetValueInteger("Weapon Handgun 10", "COPS WEAPON SLOT", -1)
                    End If

                    'NOOSE

                    c += 1
                    If c = 5 Then c = 0

                    If c = 1 Then
                        If Settings.GetValueInteger("Sub-Machine Gun 1", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 1", "NOOSE WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Assault Rifle 1", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 1", "NOOSE WEAPON SLOT", 0)

                        If Settings.GetValueInteger("ShotGun 1", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 1", "NOOSE WEAPON SLOT", 0)

                        If Settings.GetValueInteger("HandGun 1", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 1", "NOOSE WEAPON SLOT", 0)
                        Settings.Save()
                        weap3 = Settings.GetValueInteger("Assault Rifle 1", "NOOSE WEAPON SLOT", -1)
                        weap4 = Settings.GetValueInteger("ShotGun 1", "NOOSE WEAPON SLOT", -1)
                        weap5 = Settings.GetValueInteger("Sub-Machine Gun 1", "NOOSE WEAPON SLOT", -1)
                        weap6 = Settings.GetValueInteger("HandGun 1", "NOOSE WEAPON SLOT", -1)
                    ElseIf c = 2 Then
                        If Settings.GetValueInteger("Assault Rifle 2", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 2", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 2", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 2", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("HandGun 2", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 2", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 2", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 2", "NOOSE WEAPON SLOT", 0)
                        Settings.Save()
                        weap3 = Settings.GetValueInteger("Assault Rifle 2", "NOOSE WEAPON SLOT", -1)
                        weap4 = Settings.GetValueInteger("ShotGun 2", "NOOSE WEAPON SLOT", -1)
                        weap5 = Settings.GetValueInteger("Sub-Machine Gun 2", "NOOSE WEAPON SLOT", -1)
                        weap6 = Settings.GetValueInteger("HandGun 2", "NOOSE WEAPON SLOT", -1)
                    ElseIf c = 3 Then
                        If Settings.GetValueInteger("HandGun 3", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 3", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 3", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 3", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 3", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 3", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 3", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 3", "NOOSE WEAPON SLOT", 0)
                        Settings.Save()
                        weap3 = Settings.GetValueInteger("Assault Rifle 3", "NOOSE WEAPON SLOT", -1)
                        weap4 = Settings.GetValueInteger("ShotGun 3", "NOOSE WEAPON SLOT", -1)
                        weap5 = Settings.GetValueInteger("Sub-Machine Gun 3", "NOOSE WEAPON SLOT", -1)
                        weap6 = Settings.GetValueInteger("HandGun 3", "NOOSE WEAPON SLOT", -1)
                    ElseIf c = 4 Then
                        If Settings.GetValueInteger("HandGun 4", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 4", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 4", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 4", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 4", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 4", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 4", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 4", "NOOSE WEAPON SLOT", 0)
                        Settings.Save()
                        weap3 = Settings.GetValueInteger("Assault Rifle 4", "NOOSE WEAPON SLOT", -1)
                        weap4 = Settings.GetValueInteger("ShotGun 4", "NOOSE WEAPON SLOT", -1)
                        weap5 = Settings.GetValueInteger("Sub-Machine Gun 4", "NOOSE WEAPON SLOT", -1)
                        weap6 = Settings.GetValueInteger("HandGun 4", "NOOSE WEAPON SLOT", -1)
                    ElseIf c = 0 Then
                        If Settings.GetValueInteger("HandGun 5", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 5", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 5", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 5", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 5", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 5", "NOOSE WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 5", "NOOSE WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 5", "NOOSE WEAPON SLOT", 0)
                        Settings.Save()
                        weap3 = Settings.GetValueInteger("Assault Rifle 5", "NOOSE WEAPON SLOT", -1)
                        weap4 = Settings.GetValueInteger("ShotGun 5", "NOOSE WEAPON SLOT", -1)
                        weap5 = Settings.GetValueInteger("Sub-Machine Gun 5", "NOOSE WEAPON SLOT", -1)
                        weap6 = Settings.GetValueInteger("HandGun 5", "NOOSE WEAPON SLOT", -1)
                    End If

                    'ARMY
                    d += 1
                    If d = 5 Then d = 0

                    If d = 1 Then
                        If Settings.GetValueInteger("Sub-Machine Gun 1", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 1", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 1", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 1", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 1", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 1", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("HandGun 1", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 1", "ARMY WEAPON SLOT", 0)
                        Settings.Save()
                        weap7 = Settings.GetValueInteger("Assault Rifle 1", "ARMY WEAPON SLOT", -1)
                        weap8 = Settings.GetValueInteger("ShotGun 1", "ARMY WEAPON SLOT", -1)
                        weap9 = Settings.GetValueInteger("Sub-Machine Gun 1", "ARMY WEAPON SLOT", -1)
                        weap10 = Settings.GetValueInteger("HandGun 1", "ARMY WEAPON SLOT", -1)
                    ElseIf d = 2 Then
                        If Settings.GetValueInteger("Assault Rifle 2", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 2", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 2", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 2", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("HandGun 2", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 2", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 2", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 2", "ARMY WEAPON SLOT", 0)
                        Settings.Save()
                        weap7 = Settings.GetValueInteger("Assault Rifle 2", "ARMY WEAPON SLOT", -1)
                        weap8 = Settings.GetValueInteger("ShotGun 2", "ARMY WEAPON SLOT", -1)
                        weap9 = Settings.GetValueInteger("Sub-Machine Gun 2", "ARMY WEAPON SLOT", -1)
                        weap10 = Settings.GetValueInteger("HandGun 2", "ARMY WEAPON SLOT", -1)
                    ElseIf d = 3 Then
                        If Settings.GetValueInteger("HandGun 3", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 3", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 3", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 3", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 3", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 3", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 3", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 3", "ARMY WEAPON SLOT", 0)
                        Settings.Save()
                        weap7 = Settings.GetValueInteger("Assault Rifle 3", "ARMY WEAPON SLOT", -1)
                        weap8 = Settings.GetValueInteger("ShotGun 3", "ARMY WEAPON SLOT", -1)
                        weap9 = Settings.GetValueInteger("Sub-Machine Gun 3", "ARMY WEAPON SLOT", -1)
                        weap10 = Settings.GetValueInteger("HandGun 3", "ARMY WEAPON SLOT", -1)
                    ElseIf d = 4 Then
                        If Settings.GetValueInteger("HandGun 4", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 4", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 4", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 4", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 4", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 4", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 4", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 4", "ARMY WEAPON SLOT", 0)
                        Settings.Save()
                        weap7 = Settings.GetValueInteger("Assault Rifle 4", "ARMY WEAPON SLOT", -1)
                        weap8 = Settings.GetValueInteger("ShotGun 4", "ARMY WEAPON SLOT", -1)
                        weap9 = Settings.GetValueInteger("Sub-Machine Gun 4", "ARMY WEAPON SLOT", -1)
                        weap10 = Settings.GetValueInteger("HandGun 4", "ARMY WEAPON SLOT", -1)
                    ElseIf d = 0 Then
                        If Settings.GetValueInteger("HandGun 5", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 5", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 5", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 5", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 5", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 5", "ARMY WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 5", "ARMY WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 5", "ARMY WEAPON SLOT", 0)
                        Settings.Save()
                        weap7 = Settings.GetValueInteger("Assault Rifle 5", "ARMY WEAPON SLOT", -1)
                        weap8 = Settings.GetValueInteger("ShotGun 5", "ARMY WEAPON SLOT", -1)
                        weap9 = Settings.GetValueInteger("Sub-Machine Gun 5", "ARMY WEAPON SLOT", -1)
                        weap10 = Settings.GetValueInteger("HandGun 5", "ARMY WEAPON SLOT", -1)
                    End If

                    'FIB 
                    f += 1
                    If f = 5 Then f = 0

                    If f = 1 Then
                        If Settings.GetValueInteger("Sub-Machine Gun 1", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 1", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 1", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 1", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 1", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 1", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("HandGun 1", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 1", "FIB WEAPON SLOT", 0)
                        Settings.Save()
                        weap11 = Settings.GetValueInteger("Assault Rifle 1", "FIB WEAPON SLOT", -1)
                        weap12 = Settings.GetValueInteger("ShotGun 1", "FIB WEAPON SLOT", -1)
                        weap13 = Settings.GetValueInteger("Sub-Machine Gun 1", "FIB WEAPON SLOT", -1)
                        weap14 = Settings.GetValueInteger("HandGun 1", "FIB WEAPON SLOT", -1)
                    ElseIf f = 2 Then
                        If Settings.GetValueInteger("Assault Rifle 2", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 2", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 2", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 2", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("HandGun 2", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 2", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 2", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 2", "FIB WEAPON SLOT", 0)
                        Settings.Save()
                        weap11 = Settings.GetValueInteger("Assault Rifle 2", "FIB WEAPON SLOT", -1)
                        weap12 = Settings.GetValueInteger("ShotGun 2", "FIB WEAPON SLOT", -1)
                        weap13 = Settings.GetValueInteger("Sub-Machine Gun 2", "FIB WEAPON SLOT", -1)
                        weap14 = Settings.GetValueInteger("HandGun 2", "FIB WEAPON SLOT", -1)
                    ElseIf f = 3 Then
                        If Settings.GetValueInteger("HandGun 3", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 3", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 3", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 3", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 3", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 3", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 3", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 3", "FIB WEAPON SLOT", 0)
                        Settings.Save()
                        weap11 = Settings.GetValueInteger("Assault Rifle 3", "FIB WEAPON SLOT", -1)
                        weap12 = Settings.GetValueInteger("ShotGun 3", "FIB WEAPON SLOT", -1)
                        weap13 = Settings.GetValueInteger("Sub-Machine Gun 3", "FIB WEAPON SLOT", -1)
                        weap14 = Settings.GetValueInteger("HandGun 3", "FIB WEAPON SLOT", -1)
                    ElseIf f = 4 Then
                        If Settings.GetValueInteger("HandGun 4", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 4", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 4", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 4", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 4", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 4", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 4", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 4", "FIB WEAPON SLOT", 0)
                        Settings.Save()
                        weap11 = Settings.GetValueInteger("Assault Rifle 4", "FIB WEAPON SLOT", -1)
                        weap12 = Settings.GetValueInteger("ShotGun 4", "FIB WEAPON SLOT", -1)
                        weap13 = Settings.GetValueInteger("Sub-Machine Gun 4", "FIB WEAPON SLOT", -1)
                        weap14 = Settings.GetValueInteger("HandGun 4", "FIB WEAPON SLOT", -1)
                    ElseIf f = 0 Then
                        If Settings.GetValueInteger("HandGun 5", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 5", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 5", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 5", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Assault Rifle 5", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 5", "FIB WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 5", "FIB WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 5", "FIB WEAPON SLOT", 0)
                        Settings.Save()
                        weap11 = Settings.GetValueInteger("Assault Rifle 5", "FIB WEAPON SLOT", -1)
                        weap12 = Settings.GetValueInteger("ShotGun 5", "FIB WEAPON SLOT", -1)
                        weap13 = Settings.GetValueInteger("Sub-Machine Gun 5", "FIB WEAPON SLOT", -1)
                        weap14 = Settings.GetValueInteger("HandGun 5", "FIB WEAPON SLOT", -1)
                    End If

                    'FEMALE COP

                    b += 1
                    If b = 10 Then b = 0

                    If b = 1 Then
                        If Settings.GetValueInteger("Weapon 1", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 1", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon Handgun 1", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 1", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 1", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 1", "FEMALE COPS WEAPON SLOT", -1)
                    ElseIf b = 2 Then
                        If Settings.GetValueInteger("Weapon Handgun 2", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 2", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon 2", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 2", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 2", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 2", "FEMALE COPS WEAPON SLOT", -1)
                    ElseIf b = 3 Then
                        If Settings.GetValueInteger("Weapon Handgun 3", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 3", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon 3", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 3", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 3", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 3", "FEMALE COPS WEAPON SLOT", -1)
                    ElseIf b = 4 Then
                        If Settings.GetValueInteger("Weapon 4", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 4", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon Handgun 4", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 4", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 4", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 4", "FEMALE COPS WEAPON SLOT", -1)
                    ElseIf b = 5 Then
                        If Settings.GetValueInteger("Weapon Handgun 5", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 5", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon 5", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 5", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 5", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 5", "FEMALE COPS WEAPON SLOT", -1)
                    ElseIf b = 6 Then
                        If Settings.GetValueInteger("Weapon 6", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 6", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon Handgun 6", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 6", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 6", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 6", "FEMALE COPS WEAPON SLOT", -1)
                    ElseIf b = 7 Then
                        If Settings.GetValueInteger("Weapon 7", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 7", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon Handgun 7", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 7", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 7", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 7", "FEMALE COPS WEAPON SLOT", -1)
                    ElseIf b = 8 Then
                        If Settings.GetValueInteger("Weapon 8", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 8", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon Handgun 8", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 8", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 8", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 8", "FEMALE COPS WEAPON SLOT", -1)
                    ElseIf b = 9 Then
                        If Settings.GetValueInteger("Weapon 9", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 9", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon Handgun 9", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 9", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 9", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 9", "FEMALE COPS WEAPON SLOT", -1)
                    ElseIf b = 0 Then
                        If Settings.GetValueInteger("Weapon 10", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon 10", "FEMALE COPS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Weapon Handgun 10", "FEMALE COPS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Weapon Handgun 10", "FEMALE COPS WEAPON SLOT", 0)
                        Settings.Save()
                        weapp = Settings.GetValueInteger("Weapon 10", "FEMALE COPS WEAPON SLOT", -1)
                        weap2 = Settings.GetValueInteger("Weapon Handgun 10", "FEMALE COPS WEAPON SLOT", -1)
                    End If

                    'LC GUARDS

                    g += 1
                    If g = 5 Then g = 0

                    If g = 1 Then
                        If Settings.GetValueInteger("Sub-Machine Gun 1", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 1", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Assault Rifle 1", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 1", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("ShotGun 1", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 1", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("HandGun 1", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 1", "LC GUARDS WEAPON SLOT", 0)
                        Settings.Save()
                        weap15 = Settings.GetValueInteger("Assault Rifle 1", "LC GUARDS WEAPON SLOT", -1)
                        weap16 = Settings.GetValueInteger("ShotGun 1", "LC GUARDS WEAPON SLOT", -1)
                        weap17 = Settings.GetValueInteger("Sub-Machine Gun 1", "LC GUARDS WEAPON SLOT", -1)
                        weap18 = Settings.GetValueInteger("HandGun 1", "LC GUARDS WEAPON SLOT", -1)
                    ElseIf g = 2 Then
                        If Settings.GetValueInteger("Assault Rifle 2", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 2", "LC GUARDS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("Sub-Machine Gun 2", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 2", "LC GUARDS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("HandGun 2", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 2", "LC GUARDS WEAPON SLOT", 0)
                        If Settings.GetValueInteger("ShotGun 2", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 2", "LC GUARDS WEAPON SLOT", 0)
                        Settings.Save()
                        weap15 = Settings.GetValueInteger("Assault Rifle 2", "LC GUARDS WEAPON SLOT", -1)
                        weap16 = Settings.GetValueInteger("ShotGun 2", "LC GUARDS WEAPON SLOT", -1)
                        weap17 = Settings.GetValueInteger("Sub-Machine Gun 2", "LC GUARDS WEAPON SLOT", -1)
                        weap18 = Settings.GetValueInteger("HandGun 2", "LC GUARDS WEAPON SLOT", -1)
                    ElseIf g = 3 Then
                        If Settings.GetValueInteger("HandGun 3", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 3", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("ShotGun 3", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 3", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Assault Rifle 3", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 3", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Sub-Machine Gun 3", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 3", "LC GUARDS WEAPON SLOT", 0)
                        Settings.Save()
                        weap15 = Settings.GetValueInteger("Assault Rifle 3", "LC GUARDS WEAPON SLOT", -1)
                        weap16 = Settings.GetValueInteger("ShotGun 3", "LC GUARDS WEAPON SLOT", -1)
                        weap17 = Settings.GetValueInteger("Sub-Machine Gun 3", "LC GUARDS WEAPON SLOT", -1)
                        weap18 = Settings.GetValueInteger("HandGun 3", "LC GUARDS WEAPON SLOT", -1)
                    ElseIf g = 4 Then
                        If Settings.GetValueInteger("HandGun 4", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 4", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("ShotGun 4", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 4", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Assault Rifle 4", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 4", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Sub-Machine Gun 4", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 4", "LC GUARDS WEAPON SLOT", 0)
                        Settings.Save()
                        weap15 = Settings.GetValueInteger("Assault Rifle 4", "LC GUARDS WEAPON SLOT", -1)
                        weap16 = Settings.GetValueInteger("ShotGun 4", "LC GUARDS WEAPON SLOT", -1)
                        weap17 = Settings.GetValueInteger("Sub-Machine Gun 4", "LC GUARDS WEAPON SLOT", -1)
                        weap18 = Settings.GetValueInteger("HandGun 4", "LC GUARDS WEAPON SLOT", -1)
                    ElseIf g = 0 Then
                        If Settings.GetValueInteger("HandGun 5", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("HandGun 5", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Sub-Machine Gun 5", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Sub-Machine Gun 5", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("Assault Rifle 5", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("Assault Rifle 5", "LC GUARDS WEAPON SLOT", 0)

                        If Settings.GetValueInteger("ShotGun 5", "LC GUARDS WEAPON SLOT", -1) = -1 Then Settings.SetValue("ShotGun 5", "LC GUARDS WEAPON SLOT", 0)
                        Settings.Save()
                        weap15 = Settings.GetValueInteger("Assault Rifle 5", "LC GUARDS WEAPON SLOT", -1)
                        weap16 = Settings.GetValueInteger("ShotGun 5", "LC GUARDS WEAPON SLOT", -1)
                        weap17 = Settings.GetValueInteger("Sub-Machine Gun 5", "LC GUARDS WEAPON SLOT", -1)
                        weap18 = Settings.GetValueInteger("HandGun 5", "LC GUARDS WEAPON SLOT", -1)
                    End If

                    'LIST OF COPS/ARMY/NOOSE/FIB

                    Dim mod1, mod2, mod3, mod4, mod5, mod6, mod7, mod8, mod9, mod10, mod11, mod12, mod13, mod14, mod15, mod16, mod17, mod18, mod19, mod20, mod21, mod22, mod23, mod24, mod25, mod26, mod27, mod28, mod29, mod30, mod31, mod32, mod33, mod34, mod35 As Model

                    If Settings.GetValueModel("Model 1", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 1", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 2", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 2", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 3", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 3", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 4", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 4", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 5", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 5", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 6", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 6", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 7", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 7", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 8", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 8", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 9", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 9", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 10", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 10", "LCPD COPS", "")

                    If Settings.GetValueModel("Model 1", "NOOSE", "a") = "a" Then Settings.SetValue("Model 1", "NOOSE", "")

                    If Settings.GetValueModel("Model 2", "NOOSE", "a") = "a" Then Settings.SetValue("Model 2", "NOOSE", "")

                    If Settings.GetValueModel("Model 3", "NOOSE", "a") = "a" Then Settings.SetValue("Model 3", "NOOSE", "")

                    If Settings.GetValueModel("Model 4", "NOOSE", "a") = "a" Then Settings.SetValue("Model 4", "NOOSE", "")

                    If Settings.GetValueModel("Model 5", "NOOSE", "a") = "a" Then Settings.SetValue("Model 5", "NOOSE", "")

                    If Settings.GetValueModel("Model 1", "ARMY", "a") = "a" Then Settings.SetValue("Model 1", "ARMY", "")

                    If Settings.GetValueModel("Model 2", "ARMY", "a") = "a" Then Settings.SetValue("Model 2", "ARMY", "")

                    If Settings.GetValueModel("Model 3", "ARMY", "a") = "a" Then Settings.SetValue("Model 3", "ARMY", "")

                    If Settings.GetValueModel("Model 4", "ARMY", "a") = "a" Then Settings.SetValue("Model 4", "ARMY", "")

                    If Settings.GetValueModel("Model 5", "ARMY", "a") = "a" Then Settings.SetValue("Model 5", "ARMY", "")

                    If Settings.GetValueModel("Model 1", "FIB", "a") = "a" Then Settings.SetValue("Model 1", "FIB", "")

                    If Settings.GetValueModel("Model 2", "FIB", "a") = "a" Then Settings.SetValue("Model 2", "FIB", "")

                    If Settings.GetValueModel("Model 3", "FIB", "a") = "a" Then Settings.SetValue("Model 3", "FIB", "")

                    If Settings.GetValueModel("Model 4", "FIB", "a") = "a" Then Settings.SetValue("Model 4", "FIB", "")

                    If Settings.GetValueModel("Model 5", "FIB", "a") = "a" Then Settings.SetValue("Model 5", "FIB", "")

                    If Settings.GetValueModel("Model 1", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 1", "LCPD COPS FEMALE", "")

                    If Settings.GetValueModel("Model 2", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 2", "LCPD COPS FEMALE", "")

                    If Settings.GetValueModel("Model 3", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 3", "LCPD COPS FEMALE", "")

                    If Settings.GetValueModel("Model 4", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 4", "LCPD COPS FEMALE", "")

                    If Settings.GetValueModel("Model 5", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 5", "LCPD COPS FEMALE", "")

                    If Settings.GetValueModel("Model 1", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 1", "LC GUARDS", "")

                    If Settings.GetValueModel("Model 2", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 2", "LC GUARDS", "")

                    If Settings.GetValueModel("Model 3", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 3", "LC GUARDS", "")

                    If Settings.GetValueModel("Model 4", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 4", "LC GUARDS", "")

                    If Settings.GetValueModel("Model 5", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 5", "LC GUARDS", "")
                    Settings.Save()
                    mod1 = Settings.GetValueModel("Model 1", "LCPD COPS", "a")
                    mod2 = Settings.GetValueModel("Model 2", "LCPD COPS", "a")
                    mod3 = Settings.GetValueModel("Model 3", "LCPD COPS", "a")
                    mod4 = Settings.GetValueModel("Model 4", "LCPD COPS", "a")
                    mod5 = Settings.GetValueModel("Model 5", "LCPD COPS", "a")
                    mod6 = Settings.GetValueModel("Model 6", "LCPD COPS", "a")
                    mod7 = Settings.GetValueModel("Model 7", "LCPD COPS", "a")
                    mod8 = Settings.GetValueModel("Model 8", "LCPD COPS", "a")
                    mod9 = Settings.GetValueModel("Model 9", "LCPD COPS", "a")
                    mod10 = Settings.GetValueModel("Model 10", "LCPD COPS", "a")
                    mod11 = Settings.GetValueModel("Model 1", "NOOSE", "a")
                    mod12 = Settings.GetValueModel("Model 2", "NOOSE", "a")
                    mod13 = Settings.GetValueModel("Model 3", "NOOSE", "a")
                    mod14 = Settings.GetValueModel("Model 4", "NOOSE", "a")
                    mod15 = Settings.GetValueModel("Model 5", "NOOSE", "a")
                    mod16 = Settings.GetValueModel("Model 1", "ARMY", "a")
                    mod17 = Settings.GetValueModel("Model 2", "ARMY", "a")
                    mod18 = Settings.GetValueModel("Model 3", "ARMY", "a")
                    mod19 = Settings.GetValueModel("Model 4", "ARMY", "a")
                    mod20 = Settings.GetValueModel("Model 5", "ARMY", "a")
                    mod21 = Settings.GetValueModel("Model 1", "FIB", "a")
                    mod22 = Settings.GetValueModel("Model 2", "FIB", "a")
                    mod23 = Settings.GetValueModel("Model 3", "FIB", "a")
                    mod24 = Settings.GetValueModel("Model 4", "FIB", "a")
                    mod25 = Settings.GetValueModel("Model 5", "FIB", "a")
                    mod26 = Settings.GetValueModel("Model 1", "LCPD COPS FEMALE", "a")
                    mod27 = Settings.GetValueModel("Model 2", "LCPD COPS FEMALE", "a")
                    mod28 = Settings.GetValueModel("Model 3", "LCPD COPS FEMALE", "a")
                    mod29 = Settings.GetValueModel("Model 4", "LCPD COPS FEMALE", "a")
                    mod30 = Settings.GetValueModel("Model 5", "LCPD COPS FEMALE", "a")
                    mod31 = Settings.GetValueModel("Model 1", "LC GUARDS", "a")
                    mod32 = Settings.GetValueModel("Model 2", "LC GUARDS", "a")
                    mod33 = Settings.GetValueModel("Model 3", "LC GUARDS", "a")
                    mod34 = Settings.GetValueModel("Model 4", "LC GUARDS", "a")
                    mod35 = Settings.GetValueModel("Model 5", "LC GUARDS", "a")


                    If armslot = "True" Then
                        arm = 50
                        arm1 = 100
                    Else
                        arm = 0
                        arm1 = 0
                    End If

                    If prop2 = "True" Then
                        prop = random10.Next(0, 5)
                    Else
                        prop = 0

                    End If

                    Cops(mod1, weap, weap1, prop)
                    Cops(mod2, weap, weap1, prop)
                    Cops(mod3, weap, weap1, prop)
                    Cops(mod4, weap, weap1, prop)
                    Cops(mod5, weap, weap1, prop)
                    Cops(mod6, weap, weap1, prop)
                    Cops(mod7, weap, weap1, prop)
                    Cops(mod8, weap, weap1, prop)
                    Cops(mod9, weap, weap1, prop)
                    Cops(mod10, weap, weap1, prop)
                    Cops(mod26, weap, weap1, prop)
                    Cops(mod27, weap, weap1, prop)
                    Cops(mod28, weap, weap1, prop)
                    Cops(mod29, weap, weap1, prop)
                    Cops(mod30, weap, weap1, prop)
                    Tactical(mod11, weap3, weap4, weap5, weap6, prop)
                    Tactical(mod12, weap3, weap4, weap5, weap6, prop)
                    Tactical(mod13, weap3, weap4, weap5, weap6, prop)
                    Tactical(mod14, weap3, weap4, weap5, weap6, prop)
                    Tactical(mod15, weap3, weap4, weap5, weap6, prop)
                    Tactical1(mod16, weap7, weap8, weap9, weap10, prop)
                    Tactical1(mod17, weap7, weap8, weap9, weap10, prop)
                    Tactical1(mod18, weap7, weap8, weap9, weap10, prop)
                    Tactical1(mod19, weap7, weap8, weap9, weap10, prop)
                    Tactical1(mod20, weap7, weap8, weap9, weap10, prop)
                    Tactical2(mod21, weap11, weap12, weap13, weap14, prop)
                    Tactical2(mod22, weap11, weap12, weap13, weap14, prop)
                    Tactical2(mod23, weap11, weap12, weap13, weap14, prop)
                    Tactical2(mod24, weap11, weap12, weap13, weap14, prop)
                    Tactical2(mod25, weap11, weap12, weap13, weap14, prop)
                    Tactical3(mod30, weap15, weap16, weap17, weap18, prop)
                    Tactical3(mod31, weap15, weap16, weap17, weap18, prop)
                    Tactical3(mod32, weap15, weap16, weap17, weap18, prop)
                    Tactical3(mod33, weap15, weap16, weap17, weap18, prop)
                    Tactical3(mod34, weap15, weap16, weap17, weap18, prop)
                    Tactical3(mod35, weap15, weap16, weap17, weap18, prop)
                    'COPS

                    Dim fatass As Ped(), fatasss As Ped
                    fatass = World.GetAllPeds("m_m_fatcop_01")
                    For Each fatasss In fatass
                        If Exists(fatass) And fatasss.Money <> 5 AndAlso fatasss.isRequiredForMission = False Then
                            fatasss.Money = 5
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", fatasss, weap, 300, 0)
                            fatasss.Skin.SetPropIndex(PedProp.UNKNOWN_0, prop)
                            fatasss.Skin.SetPropIndex(PedProp.UNKNOWN_1, prop)
                        End If
                    Next

                    Dim fatass2 As Ped(), fatasss2 As Ped
                    fatass2 = World.GetAllPeds("f_m_fatcop_01")
                    For Each fatasss2 In fatass2
                        If Exists(fatass2) And fatasss2.Money <> 5 AndAlso fatasss2.isRequiredForMission = False Then
                            fatasss2.Money = 5
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", fatasss2, weap, 300, 0)
                            fatasss2.Skin.SetPropIndex(PedProp.UNKNOWN_0, prop)
                            fatasss2.Skin.SetPropIndex(PedProp.UNKNOWN_1, prop)
                        End If
                    Next

                    Dim nooses As Ped(), noose As Ped
                    nooses = World.GetAllPeds("m_y_swat")
                    For Each noose In nooses
                        If Exists(nooses) And noose.Money <> 5 AndAlso noose.isRequiredForMission = False Then
                            noose.Money = 5
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", noose, weap3, 250, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", noose, weap4, 50, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", noose, weap5, 150, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", noose, weap6, 50, 0)
                            noose.Skin.SetPropIndex(PedProp.UNKNOWN_0, prop)
                            noose.Skin.SetPropIndex(PedProp.UNKNOWN_1, prop)
                        End If
                    Next


                    Dim fibS As Ped(), fib As Ped
                    fibS = World.GetAllPeds("m_m_fbi")
                    For Each fib In fibS
                        If Exists(fibS) And fib.Money <> 5 AndAlso fib.isRequiredForMission = False Then
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", fib, weap11, 250, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", fib, weap12, 100, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", fib, weap13, 150, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", fib, weap14, 50, 0)
                            fib.Skin.SetPropIndex(PedProp.UNKNOWN_0, prop)
                            fib.Skin.SetPropIndex(PedProp.UNKNOWN_1, prop)
                            fib.Money = 5
                        End If
                    Next

                End If

                ' End If
            Catch NonExistingObjectException As GTA.NonExistingObjectException

            Catch AccessViolationException As System.AccessViolationException

            Catch NullReferenceException As System.NullReferenceException

            End Try



        End Sub

        Public Sub Cops(mod1 As Model, weap As Integer, weap1 As Integer, prop As Integer)

            Dim cops1 As Ped(), cop1 As Ped
            cops1 = World.GetAllPeds(mod1)
            For Each cop1 In cops1
                If Exists(cops1) Then
                    If cop1.Weapons.Current.Type = Weapon.Melee_BaseballBat Then If (Player.WantedLevel <= 6 And Player.WantedLevel >= 1) Then cop1.Task.FightAgainst(Player.Character)
                    If cop1.Money <> 5 AndAlso cop1.isRequiredForMission = False Then
                        cop1.Armor = 25
                        Dim pl As Integer = Player.WantedLevel
                        If pl = (0 Or 1 Or 2 Or 3) Then
                            cop1.Weapons.RemoveAll()
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop1, taser, 200, 0)
                        End If
                        cop1.Skin.SetPropIndex(PedProp.UNKNOWN_0, prop)
                        cop1.Skin.SetPropIndex(PedProp.UNKNOWN_1, prop)
                        heavystuff = Settings.GetValueString("Type")
                        If pl = (3 Or 4 Or 5 Or 6) AndAlso heavystuff = "Firearms" Then
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop1, weap, 200, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop1, weap1, 100, 0)
                            cop1.Money = 5
                        End If
                    End If
                End If
            Next
        End Sub

        Public Sub Tactical(mod11 As Model, weap3 As Integer, weap4 As Integer, weap5 As Integer, weap6 As Integer, prop As Integer)

            Dim cops11 As Ped(), cop11 As Ped
            cops11 = World.GetAllPeds(mod11)
            For Each cop11 In cops11
                If Exists(cops11) Then
                    If cop11.Weapons.Current.Type = Weapon.Melee_Knife Then If (Player.WantedLevel <= 6 And Player.WantedLevel >= 1) Then cop11.Task.FightAgainst(Player.Character)
                    If cop11.Money <> 5 AndAlso cop11.isRequiredForMission = False Then
                        cop11.Armor = 100
                        Dim pl As Integer = Player.WantedLevel
                        cop11.Skin.SetPropIndex(PedProp.UNKNOWN_0, prop)
                        cop11.Skin.SetPropIndex(PedProp.UNKNOWN_1, prop)
                        heavystuff = Settings.GetValueString("Type")
                        If pl = (3 Or 4 Or 5 Or 6) AndAlso heavystuff = "Firearms" Then
                            cop11.Weapons.Knife.Ammo = 1
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap3, 250, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap4, 50, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap5, 150, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap6, 30, 0)
                            cop11.Money = 5
                        End If
                    End If
                End If
            Next
        End Sub

        Public Sub Tactical1(mod11 As Model, weap3 As Integer, weap4 As Integer, weap5 As Integer, weap6 As Integer, prop As Integer)

            Dim cops11 As Ped(), cop11 As Ped
            cops11 = World.GetAllPeds(mod11)
            For Each cop11 In cops11
                If Exists(cops11) Then
                    If cop11.Weapons.Current.Type = Weapon.Melee_Knife Then If (Player.WantedLevel <= 6 And Player.WantedLevel >= 1) Then cop11.Task.FightAgainst(Player.Character)
                    If cop11.Money <> 5 AndAlso cop11.isRequiredForMission = False Then
                        cop11.Armor = 100
                        Dim pl As Integer = Player.WantedLevel
                        cop11.Skin.SetPropIndex(PedProp.UNKNOWN_0, prop)
                        heavystuff = Settings.GetValueString("Type")
                        cop11.Skin.SetPropIndex(PedProp.UNKNOWN_1, prop)
                        If pl = (3 Or 4 Or 5 Or 6) AndAlso heavystuff = "Firearms" Then
                            cop11.Weapons.Knife.Ammo = 1
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap3, 250, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap4, 50, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap5, 150, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap6, 30, 0)
                            cop11.Money = 5
                        End If
                    End If
                End If
            Next
        End Sub

        Public Sub Tactical2(mod11 As Model, weap3 As Integer, weap4 As Integer, weap5 As Integer, weap6 As Integer, prop As Integer)

            Dim cops11 As Ped(), cop11 As Ped
            cops11 = World.GetAllPeds(mod11)
            For Each cop11 In cops11
                If Exists(cops11) Then
                    If cop11.Weapons.Current.Type = Weapon.Melee_Knife Then If (Player.WantedLevel <= 6 And Player.WantedLevel >= 1) Then cop11.Task.FightAgainst(Player.Character)
                    If cop11.Money <> 5 AndAlso cop11.isRequiredForMission = False Then
                        cop11.Armor = 100
                        Dim pl As Integer = Player.WantedLevel
                        cop11.Skin.SetPropIndex(PedProp.UNKNOWN_0, prop)
                        heavystuff = Settings.GetValueString("Type")
                        cop11.Skin.SetPropIndex(PedProp.UNKNOWN_1, prop)
                        If pl = (3 Or 4 Or 5 Or 6) AndAlso heavystuff = "Firearms" Then
                            cop11.Weapons.Knife.Ammo = 1
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap3, 250, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap4, 50, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap5, 150, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap6, 30, 0)
                            cop11.Money = 5
                        End If
                    End If
                End If
            Next
        End Sub

        Public Sub Tactical3(mod11 As Model, weap3 As Integer, weap4 As Integer, weap5 As Integer, weap6 As Integer, prop As Integer)

            Dim cops11 As Ped(), cop11 As Ped
            cops11 = World.GetAllPeds(mod11)
            For Each cop11 In cops11
                If Exists(cops11) Then
                    If cop11.Weapons.Current.Type = Weapon.Melee_Knife Then If (Player.WantedLevel <= 6 And Player.WantedLevel >= 1) Then cop11.Task.FightAgainst(Player.Character)
                    If cop11.Money <> 5 AndAlso cop11.isRequiredForMission = False Then
                        cop11.Armor = 100
                        Dim pl As Integer = Player.WantedLevel
                        cop11.Skin.SetPropIndex(PedProp.UNKNOWN_0, prop)
                        heavystuff = Settings.GetValueString("Type")
                        cop11.Skin.SetPropIndex(PedProp.UNKNOWN_1, prop)
                        If pl = (3 Or 4 Or 5 Or 6) AndAlso heavystuff = "Firearms" Then
                            cop11.Weapons.Knife.Ammo = 1
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap3, 250, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap4, 50, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap5, 150, 0)
                            Native.Function.Call("GIVE_WEAPON_TO_CHAR", cop11, weap6, 30, 0)
                            cop11.Money = 5
                        End If
                    End If
                End If
            Next
        End Sub

        Public Sub Vehicles()
            Try
                'LIST OF COPS/ARMY/NOOSE/FIB

                Dim mod1, mod2, mod3, mod4, mod5, mod6, mod7, mod8, mod9, mod10, mod11, mod12, mod13, mod14, mod15, mod16, mod17, mod18, mod19, mod20, mod21, mod22, mod23, mod24, mod25, mod26, mod27, mod28, mod29, mod30, mod31, mod32, mod33, mod34, mod35 As Model

                If Settings.GetValueModel("Model 1", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 1", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 2", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 2", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 3", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 3", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 4", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 4", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 5", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 5", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 6", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 6", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 7", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 7", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 8", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 8", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 9", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 9", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 10", "LCPD COPS", "a") = "a" Then Settings.SetValue("Model 10", "LCPD COPS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 1", "NOOSE", "a") = "a" Then Settings.SetValue("Model 1", "NOOSE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 2", "NOOSE", "a") = "a" Then Settings.SetValue("Model 2", "NOOSE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 3", "NOOSE", "a") = "a" Then Settings.SetValue("Model 3", "NOOSE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 4", "NOOSE", "a") = "a" Then Settings.SetValue("Model 4", "NOOSE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 5", "NOOSE", "a") = "a" Then Settings.SetValue("Model 5", "NOOSE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 1", "ARMY", "a") = "a" Then Settings.SetValue("Model 1", "ARMY", "")
                Settings.Save()
                If Settings.GetValueModel("Model 2", "ARMY", "a") = "a" Then Settings.SetValue("Model 2", "ARMY", "")
                Settings.Save()
                If Settings.GetValueModel("Model 3", "ARMY", "a") = "a" Then Settings.SetValue("Model 3", "ARMY", "")
                Settings.Save()
                If Settings.GetValueModel("Model 4", "ARMY", "a") = "a" Then Settings.SetValue("Model 4", "ARMY", "")
                Settings.Save()
                If Settings.GetValueModel("Model 5", "ARMY", "a") = "a" Then Settings.SetValue("Model 5", "ARMY", "")
                Settings.Save()
                If Settings.GetValueModel("Model 1", "FIB", "a") = "a" Then Settings.SetValue("Model 1", "FIB", "")
                Settings.Save()
                If Settings.GetValueModel("Model 2", "FIB", "a") = "a" Then Settings.SetValue("Model 2", "FIB", "")
                Settings.Save()
                If Settings.GetValueModel("Model 3", "FIB", "a") = "a" Then Settings.SetValue("Model 3", "FIB", "")
                Settings.Save()
                If Settings.GetValueModel("Model 4", "FIB", "a") = "a" Then Settings.SetValue("Model 4", "FIB", "")
                Settings.Save()
                If Settings.GetValueModel("Model 5", "FIB", "a") = "a" Then Settings.SetValue("Model 5", "FIB", "")
                Settings.Save()
                If Settings.GetValueModel("Model 1", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 1", "LCPD COPS FEMALE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 2", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 2", "LCPD COPS FEMALE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 3", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 3", "LCPD COPS FEMALE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 4", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 4", "LCPD COPS FEMALE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 5", "LCPD COPS FEMALE", "a") = "a" Then Settings.SetValue("Model 5", "LCPD COPS FEMALE", "")
                Settings.Save()
                If Settings.GetValueModel("Model 1", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 1", "LC GUARDS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 2", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 2", "LC GUARDS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 3", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 3", "LC GUARDS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 4", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 4", "LC GUARDS", "")
                Settings.Save()
                If Settings.GetValueModel("Model 5", "LC GUARDS", "a") = "a" Then Settings.SetValue("Model 5", "LC GUARDS", "")
                Settings.Save()
                mod1 = Settings.GetValueModel("Model 1", "LCPD COPS", "a")
                mod2 = Settings.GetValueModel("Model 2", "LCPD COPS", "a")
                mod3 = Settings.GetValueModel("Model 3", "LCPD COPS", "a")
                mod4 = Settings.GetValueModel("Model 4", "LCPD COPS", "a")
                mod5 = Settings.GetValueModel("Model 5", "LCPD COPS", "a")
                mod6 = Settings.GetValueModel("Model 6", "LCPD COPS", "a")
                mod7 = Settings.GetValueModel("Model 7", "LCPD COPS", "a")
                mod8 = Settings.GetValueModel("Model 8", "LCPD COPS", "a")
                mod9 = Settings.GetValueModel("Model 9", "LCPD COPS", "a")
                mod10 = Settings.GetValueModel("Model 10", "LCPD COPS", "a")
                mod11 = Settings.GetValueModel("Model 1", "NOOSE", "a")
                mod12 = Settings.GetValueModel("Model 2", "NOOSE", "a")
                mod13 = Settings.GetValueModel("Model 3", "NOOSE", "a")
                mod14 = Settings.GetValueModel("Model 4", "NOOSE", "a")
                mod15 = Settings.GetValueModel("Model 5", "NOOSE", "a")
                mod16 = Settings.GetValueModel("Model 1", "ARMY", "a")
                mod17 = Settings.GetValueModel("Model 2", "ARMY", "a")
                mod18 = Settings.GetValueModel("Model 3", "ARMY", "a")
                mod19 = Settings.GetValueModel("Model 4", "ARMY", "a")
                mod20 = Settings.GetValueModel("Model 5", "ARMY", "a")
                mod21 = Settings.GetValueModel("Model 1", "FIB", "a")
                mod22 = Settings.GetValueModel("Model 2", "FIB", "a")
                mod23 = Settings.GetValueModel("Model 3", "FIB", "a")
                mod24 = Settings.GetValueModel("Model 4", "FIB", "a")
                mod25 = Settings.GetValueModel("Model 5", "FIB", "a")
                mod26 = Settings.GetValueModel("Model 1", "LCPD COPS FEMALE", "a")
                mod27 = Settings.GetValueModel("Model 2", "LCPD COPS FEMALE", "a")
                mod28 = Settings.GetValueModel("Model 3", "LCPD COPS FEMALE", "a")
                mod29 = Settings.GetValueModel("Model 4", "LCPD COPS FEMALE", "a")
                mod30 = Settings.GetValueModel("Model 5", "LCPD COPS FEMALE", "a")
                mod31 = Settings.GetValueModel("Model 1", "LC GUARDS", "a")
                mod32 = Settings.GetValueModel("Model 2", "LC GUARDS", "a")
                mod33 = Settings.GetValueModel("Model 3", "LC GUARDS", "a")
                mod34 = Settings.GetValueModel("Model 4", "LC GUARDS", "a")
                mod35 = Settings.GetValueModel("Model 5", "LC GUARDS", "a")

                Dim hg_ammo As Integer = 30
                Dim sg_ammo As Integer = 50
                Dim smg_ammo As Integer = 120
                Dim ar_ammo As Integer = 200
                Dim rand_ammo As Integer = 250 'ammo for random guns which are given to cops



                '   End If
                ' End If
            Catch NonExistingObjectException As GTA.NonExistingObjectException

            Catch AccessViolationException As System.AccessViolationException

            Catch NullReferenceException As System.NullReferenceException

            End Try




        End Sub

        Private Sub General_tick(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick
            Wait(10)
            Ped()
        End Sub

        'SCRAPPED STUFF (Basically i wanted to make a xml based script but i failed so fuck this)



        'right now no need
        'Dispatch.xml
        'Private dis As String = "./common/data/dispatch.xml"
        'Loadouts.xml
        'Private load As String = "./common/data/loadouts.xml"

        'Public Sub xml()
        'Dispatch.Xml

        'Dim dispatch = XDocument.Load(dis)
        'Dim base = dispatch.Element("CDispatchData")
        'Dim spawn = base.Element("LawSpawnDelay")
        'Dim distance = base.Element("DispatchOrderDistances")
        'Dim vehsets = base.Element("VehicleSets").Element("Vehicle")
        'Dim wanted = base.Element("WantedResponses")

        'Dim wlResponse1 = wanted.Element("WantedLevel1").Element("DispatchServices")
        'Dim wlResponse2 = wanted.Element("WantedLevel2").Element("DispatchServices")
        'Dim wlResponse3 = wanted.Element("WantedLevel3").Element("DispatchServices")
        'Dim wlResponse4 = wanted.Element("WantedLevel4").Element("DispatchServices")
        'Dim wlResponse5 = wanted.Element("WantedLevel5").Element("DispatchServices")
        'Dim wlResponse6 = wanted.Element("WantedLevel6").Element("DispatchServices")

        'For Each model As String In vehsets.Value

        'Next

    End Class


    'This Class makes helicopters to spawn when you are airborne 
    Public Class Police_With_Helicopters

        Inherits Script

        Public Sub New()


            If Settings.GetValueInteger("Spawn Heli", "INTERVAL", 0) = 0 Then Settings.SetValue("Spawn Heli", "INTERVAL", 40000)

            Me.Interval = Settings.GetValueInteger("Spawn Heli", "INTERVAL", 0)
            Settings.Save()
        End Sub

        Private x As Integer = 0
        Private pmodel As Model = Nothing
        Private vehmodel As Model = Nothing
        Private total As Integer

        Public Shadows Sub KeyDown(ByVal sender As Object, ByVal e As GTA.KeyEventArgs) Handles MyBase.KeyDown
        End Sub

        Public Shadows Sub KeyUp(ByVal sender As Object, ByVal e As GTA.KeyEventArgs) Handles MyBase.KeyUp
        End Sub



        Private Sub General_tick(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick


            If Settings.GetValueString("Spawn Heli", "SETTINGS ON/OFF", "NONE") = "NONE" Then Settings.SetValue("Spawn Heli", "SETTINGS ON/OFF", "False")

            Dim st = Settings.GetValueString("Spawn Heli", "SETTINGS ON/OFF", "NONE")
            Settings.Save()
            If st = "True" Then

                Dim v As Vehicle, a As Ped, b As Ped
                Try

                    If Player.Character.isInVehicle = True Then
                        If Player.WantedLevel = 6 Or Player.WantedLevel = 5 Or Player.WantedLevel = 4 Then

                            total = 10
                            x += 1

                            If x = total + 1 Then
                                x = 1
                            End If

                            If x = 1 Then
                                If Settings.GetValueModel("Ped 1", "Heli Spawm", "NONE") = "NONE" Then Settings.SetValue("Ped 1", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 1", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 1", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 1", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 1", "HELI PURSUIT", "NONE")
                            ElseIf x = 2 Then
                                If Settings.GetValueModel("Ped 2", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Ped 2", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 2", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 2", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 2", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 2", "HELI PURSUIT", "NONE")
                            ElseIf x = 3 Then
                                If Settings.GetValueModel("Ped 3", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Ped 3", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 3", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 3", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 3", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 3", "HELI PURSUIT", "NONE")
                            ElseIf x = 4 Then
                                If Settings.GetValueModel("Ped 4", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Ped 4", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 4", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 4", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 4", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 4", "HELI PURSUIT", "NONE")
                            ElseIf x = 5 Then
                                If Settings.GetValueModel("Ped 5", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Ped 5", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 5", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 5", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 5", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 5", "HELI PURSUIT", "NONE")
                            ElseIf x = 6 Then
                                If Settings.GetValueModel("Ped 6", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Ped 6", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 6", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 6", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 6", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 6", "HELI PURSUIT", "NONE")
                            ElseIf x = 7 Then
                                If Settings.GetValueModel("Ped 7", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Ped 7", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 7", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 7", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 7", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 7", "HELI PURSUIT", "NONE")
                            ElseIf x = 8 Then
                                If Settings.GetValueModel("Ped 8", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Ped 8", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 8", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 8", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 8", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 8", "HELI PURSUIT", "NONE")
                            ElseIf x = 9 Then
                                If Settings.GetValueModel("Ped 9", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Ped 9", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 9", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 9", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 9", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 9", "HELI PURSUIT", "NONE")
                            ElseIf x = 10 Then
                                If Settings.GetValueModel("Ped 10", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Ped 10", "HELI PURSUIT", "m_y_cop")
                                Settings.Save()
                                If Settings.GetValueModel("Helicopter 10", "HELI PURSUIT", "NONE") = "NONE" Then Settings.SetValue("Helicopter 10", "HELI PURSUIT", "annihilator")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 10", "HELI PURSUIT", "NONE")
                                vehmodel = Settings.GetValueModel("Helicopter 10", "HELI PURSUIT", "NONE")
                            End If



                            If Player.Character.CurrentVehicle.Model.isHelicopter = True Then
                                v = World.CreateVehicle(vehmodel, Player.Character.Position.Around(150.0F) + Vector3.WorldUp * 20)
                                If Exists(v) Then
                                    v.EngineRunning = True
                                    v.Speed = 20
                                    a = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F))
                                    If Exists(a) Then
                                        a.Task.WarpIntoVehicle(v, VehicleSeat.Driver)
                                        a.NoLongerNeeded()
                                    End If
                                    b = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F))
                                    If Exists(b) Then
                                        b.Task.WarpIntoVehicle(v, VehicleSeat.LeftRear)
                                        b.NoLongerNeeded()
                                    End If
                                    Dim c As Ped = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F))
                                    If Exists(c) Then
                                        c.Task.WarpIntoVehicle(v, VehicleSeat.RightFront)
                                        c.NoLongerNeeded()
                                    End If
                                    Dim d As Ped = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F))
                                    If Exists(d) Then
                                        d.Task.WarpIntoVehicle(v, VehicleSeat.RightRear)
                                        d.NoLongerNeeded()
                                    End If
                                    v.NoLongerNeeded()
                                End If
                            End If
                        End If
                    End If
                Catch NonExistingObjectException As GTA.NonExistingObjectException
                Catch AccessViolationException As System.AccessViolationException
                Catch NullReferenceException As System.NullReferenceException

                End Try

            End If
        End Sub

    End Class


    Public Class Police_Vehicle_Dispatcher
        Inherits Script

        Public Sub New()

            If Settings.GetValueInteger("Spawn Timer", "INTERVAL", 0) = 0 Then Settings.SetValue("Spawn Timer", "INTERVAL", 30000)
            Settings.Save()
            Me.Interval = 10

        End Sub

        Private x As Integer = 0
        Private z As Integer = 0
        Private pmodel As Model = Nothing
        Private vehmodel As Model = Nothing
        Private am As Integer = 0
        Private weapp As Integer = 0
        Private sit2 As Integer = 0
        Private v As Vehicle = Nothing
        Private b, a As Ped
        Private oldnew As String = ""
        Private heavystuff As String = ""

        Shadows Sub KeyDown(ByVal sender As Object, ByVal e As GTA.KeyEventArgs) Handles MyBase.KeyDown
        End Sub

        Shadows Sub KeyUp(ByVal sender As Object, ByVal e As GTA.KeyEventArgs) Handles MyBase.KeyUp
        End Sub

        Private Sub PoliceDispatcher_tick(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick

            Try

                If Settings.GetValueString("Dispatch Police", "Settings ON/OFF", "NONE") = "NONE" Then Settings.SetValue("Dispatch Police", "Settings ON/OFF", "False")

                If Settings.GetValueString("Spawn Method", "Settings ON/OFF", "NONE") = "NONE" Then Settings.SetValue("Spawn Method", "Settings ON/OFF", "New")
                Settings.Save()

                Dim st As String = Settings.GetValueString("Spawn Method", "Settings ON/OFF", "NONE")
                oldnew = Settings.GetValueString("Dispatch Police", "Settings ON/OFF", "NONE")

                If Player.WantedLevel >= 3 AndAlso Player.Character.isShooting = True Then heavystuff = "Tactical"

                If Player.WantedLevel >= 3 AndAlso Player.Character.isShooting = True AndAlso Player.Character.Weapons.inSlot(WeaponSlot.Heavy) = WeaponSlot.Heavy Then heavystuff = "Tactical"
                Dim smt As Integer, pe As Ped, ped As Ped() = Nothing
                Settings.Save()
                For Each pe In ped
                    If pe.isDead = True AndAlso Player.WantedLevel = 6 Then smt = +1
                Next
                If Player.WantedLevel = 6 AndAlso smt >= 100 Then heavystuff = "Heavy Tactical"

                Settings.Save()
                If st = "True" Then

                    If oldnew = "New" Then

                        If Player.WantedLevel <= 3 AndAlso heavystuff = "" Then

                            If v.isAlive = False Or v = Nothing Then
                                z += 1
                                If z = 31 Then z = 1

                            End If

                            If z = 0 Then
                                If Settings.GetValueModel("Ped 1", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 1", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 1", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 1", "Investigation Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Peds 1", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 1", "Investigation Mode", 2)
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 1", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 1", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 1", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 1", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 1", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 1", "Investigation Mode", -1)
                                pmodel = Settings.GetValueModel("Ped 1", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 1", "Investigation Mode", "NONE")
                                sit2 = Settings.GetValueInteger("No Of Peds 1", "Investigation Mode", -1)
                            ElseIf z = 1 Then
                                If Settings.GetValueModel("Ped 2", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 2", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 2", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 2", "Investigation Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Peds 2", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 2", "Investigation Mode", 2)
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 2", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 2", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 2", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 2", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 2", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 2", "Investigation Mode", -1)
                                pmodel = Settings.GetValueModel("Ped 2", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 2", "Investigation Mode", "NONE")
                                sit2 = Settings.GetValueInteger("No Of Peds 2", "Investigation Mode", -1)
                            ElseIf z = 2 Then
                                If Settings.GetValueModel("Ped 3", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 3", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 3", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 3", "Investigation Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 3", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 3", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 3", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 3", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 3", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 3", "Investigation Mode", -1)
                                pmodel = Settings.GetValueModel("Ped 3", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 3", "Investigation Mode", "NONE")
                                If Settings.GetValueInteger("No Of Peds 3", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 3", "Investigation Mode", 2)
                                Settings.Save()
                                sit2 = Settings.GetValueInteger("No Of Peds 3", "Investigation Mode", -1)
                            ElseIf z = 3 Then
                                If Settings.GetValueModel("Ped 4", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 4", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 4", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 4", "Investigation Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 4", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 4", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 4", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 4", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 4", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 4", "Investigation Mode", -1)
                                pmodel = Settings.GetValueModel("Ped 4", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 4", "Investigation Mode", "NONE")
                                If Settings.GetValueInteger("No Of Peds 4", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 4", "Investigation Mode", 2)
                                Settings.Save()
                                sit2 = Settings.GetValueInteger("No Of Peds 4", "Investigation Mode", -1)
                            ElseIf z = 4 Then
                                If Settings.GetValueModel("Ped 5", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 5", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 5", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 5", "Investigation Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 5", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 5", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 5", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 5", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 5", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 5", "Investigation Mode", -1)
                                pmodel = Settings.GetValueModel("Ped 5", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 5", "Investigation Mode", "NONE")
                                If Settings.GetValueInteger("No Of Peds 5", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 5", "Investigation Mode", 2)
                                Settings.Save()
                                sit2 = Settings.GetValueInteger("No Of Peds 5", "Investigation Mode", -1)
                            ElseIf z = 5 Then
                                If Settings.GetValueModel("Ped 6", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 6", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 6", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 6", "Investigation Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 6", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 6", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 6", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 6", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 6", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 6", "Investigation Mode", -1)
                                pmodel = Settings.GetValueModel("Ped 6", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 6", "Investigation Mode", "NONE")
                                If Settings.GetValueInteger("No Of Peds 6", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 6", "Investigation Mode", 2)
                                Settings.Save()
                                sit2 = Settings.GetValueInteger("No Of Peds 6", "Investigation Mode", -1)
                            ElseIf z = 6 Then
                                If Settings.GetValueModel("Ped 7", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 7", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 7", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 7", "Investigation Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 7", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 7", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 7", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 7", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 7", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 7", "Investigation Mode", -1)
                                pmodel = Settings.GetValueModel("Ped 7", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 7", "Investigation Mode", "NONE")
                                If Settings.GetValueInteger("No Of Peds 7", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 7", "Investigation Mode", 2)
                                Settings.Save()
                                sit2 = Settings.GetValueInteger("No Of Peds 7", "Investigation Mode", -1)
                            ElseIf z = 7 Then
                                If Settings.GetValueModel("Ped 8", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 8", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 8", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 8", "Investigation Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 8", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 8", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 8", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 8", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 8", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 8", "Investigation Mode", -1)
                                pmodel = Settings.GetValueModel("Ped 8", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 8", "Investigation Mode", "NONE")
                                If Settings.GetValueInteger("No Of Peds 8", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 8", "Investigation Mode", 2)
                                Settings.Save()
                                sit2 = Settings.GetValueInteger("No Of Peds 8", "Investigation Mode", -1)
                            ElseIf z = 8 Then
                                If Settings.GetValueModel("Ped 9", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 9", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 9", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 9", "Investigation Mode", "noose")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 9", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 9", "Investigation Mode", "NONE")
                                If Settings.GetValueInteger("No Of Peds 9", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 9", "Investigation Mode", 2)
                                Settings.Save()
                                sit2 = Settings.GetValueInteger("No Of Peds 9", "Investigation Mode", -1)
                                If Settings.GetValueInteger("Weapon 9", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 9", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 9", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 9", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 9", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 9", "Investigation Mode", -1)
                            ElseIf z = 9 Then
                                If Settings.GetValueModel("Ped 10", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 10", "Investigation Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 10", "Investigation Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 10", "Investigation Mode", "noose")
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 10", "Investigation Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 10", "Investigation Mode", "NONE")
                                If Settings.GetValueInteger("No Of Peds 10", "Investigation Mode", -1) = -1 Then Settings.SetValue("No Of Peds 10", "Investigation Mode", 2)
                                Settings.Save()
                                sit2 = Settings.GetValueInteger("No Of Peds 10", "Investigation Mode", -1)
                                If Settings.GetValueInteger("Weapon 10", "Investigation Mode", -1) = -1 Then Settings.SetValue("Weapon 10", "Investigation Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 10", "Investigation Mode", -1) = -1 Then Settings.SetValue("Ammo 10", "Investigation Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 10", "Investigation Mode", -1)
                                am = Settings.GetValueInteger("Ammo 10", "Investigation Mode", -1)
                            End If
                        End If

                        If Player.WantedLevel = 4 Or Player.WantedLevel = 5 Or Player.WantedLevel = 6 AndAlso heavystuff = "Tactical" Then

                            If v.isAlive = False Or v = Nothing Then
                                x += 1
                                If x = 41 Then x = 1
                            End If
                            If x = 1 Then
                                If Settings.GetValueModel("Ped 1", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 1", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 1", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 1", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 1", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 1", "CHASE MODE", 2)
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 1", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 1", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 1", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 1", "CHASE MODE", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 1", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 1", "CHASE MODE", -1)
                                pmodel = Settings.GetValueModel("Ped 1", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 1", "CHASE MODE", "NONE")
                                sit2 = Settings.GetValueInteger("No Of Ped 1", "CHASE MODE", -1)
                            ElseIf x = 2 Then
                                If Settings.GetValueModel("Ped 2", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 2", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 2", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 2", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 2", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 2", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 2", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 2", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 2", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 2", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 2", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 2", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 2", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 2", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 2", "CHASE MODE", -1)
                            ElseIf x = 3 Then
                                If Settings.GetValueModel("Ped 3", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 3", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 3", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 3", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 3", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 3", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 3", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 3", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 3", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 3", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 3", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 3", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 3", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 3", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 3", "CHASE MODE", -1)
                            ElseIf x = 4 Then
                                If Settings.GetValueModel("Ped 4", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 4", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 4", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 4", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 4", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 4", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 4", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 4", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 4", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 4", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 4", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 4", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 4", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 4", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 4", "CHASE MODE", -1)
                            ElseIf x = 5 Then
                                If Settings.GetValueModel("Ped 5", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 5", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 5", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 5", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 5", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 5", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 5", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 5", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 5", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 5", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 5", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 5", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 5", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 5", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 5", "CHASE MODE", -1)
                            ElseIf x = 6 Then
                                If Settings.GetValueModel("Ped 6", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 6", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 6", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 6", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 6", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 6", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 6", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 6", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 6", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 6", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 6", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 6", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 6", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 6", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 6", "CHASE MODE", -1)
                            ElseIf x = 7 Then
                                If Settings.GetValueModel("Ped 7", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 7", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 7", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 7", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 7", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 7", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 7", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 7", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 7", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 7", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 7", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 7", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 7", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 7", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 7", "CHASE MODE", -1)
                            ElseIf x = 8 Then
                                If Settings.GetValueModel("Ped 8", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 8", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 8", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 8", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 8", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 8", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 8", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 8", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 8", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 8", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 8", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 8", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 8", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 8", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 8", "CHASE MODE", -1)
                            ElseIf x = 9 Then
                                If Settings.GetValueModel("Ped 9", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 9", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 9", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 9", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 9", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 9", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 9", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 9", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 9", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 9", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 9", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 9", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 9", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 9", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 9", "CHASE MODE", -1)
                            ElseIf x = 10 Then
                                If Settings.GetValueModel("Ped 10", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 10", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 10", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 10", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 10", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 10", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 10", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 10", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 10", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 10", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 10", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 10", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 10", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 10", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 10", "CHASE MODE", -1)
                            ElseIf x = 11 Then
                                If Settings.GetValueModel("Ped 11", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 11", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 11", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 11", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 11", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 11", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 11", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 11", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 11", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 11", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 11", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 11", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 11", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 11", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 11", "CHASE MODE", -1)
                            ElseIf x = 12 Then
                                If Settings.GetValueModel("Ped 12", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 12", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 12", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 12", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 12", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 12", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 12", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 12", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 12", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 12", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 12", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 12", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 12", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 12", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 12", "CHASE MODE", -1)
                            ElseIf x = 13 Then
                                If Settings.GetValueModel("Ped 13", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 13", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 13", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 13", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 13", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 13", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 13", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 13", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 13", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 13", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 13", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 13", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 13", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 13", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 13", "CHASE MODE", -1)
                            ElseIf x = 14 Then
                                If Settings.GetValueModel("Ped 14", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 14", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 14", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 14", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 14", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 14", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 14", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 14", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 14", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 14", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 14", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 14", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 14", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 14", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 14", "CHASE MODE", -1)
                            ElseIf x = 15 Then
                                If Settings.GetValueModel("Ped 15", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 15", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 15", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 15", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 15", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 15", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 15", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 15", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 15", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 15", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 15", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 15", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 15", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 15", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 15", "CHASE MODE", -1)
                            ElseIf x = 16 Then
                                If Settings.GetValueModel("Ped 16", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 16", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 16", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 16", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 16", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 16", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 16", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 16", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 16", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 16", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 16", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 16", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 16", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 16", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 16", "CHASE MODE", -1)
                            ElseIf x = 17 Then
                                If Settings.GetValueModel("Ped 17", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 17", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 17", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 17", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 17", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 17", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 17", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 17", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 17", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 17", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 17", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 17", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 17", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 17", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 17", "CHASE MODE", -1)
                            ElseIf x = 18 Then
                                If Settings.GetValueModel("Ped 18", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 18", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 18", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 18", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 18", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 18", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 18", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 18", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 18", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 18", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 18", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 18", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 18", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 18", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 18", "CHASE MODE", -1)
                            ElseIf x = 19 Then
                                If Settings.GetValueModel("Ped 19", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 19", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 19", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 19", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 19", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 19", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 19", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 19", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 19", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 19", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 19", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 19", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 19", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 19", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 19", "CHASE MODE", -1)
                            ElseIf x = 20 Then
                                If Settings.GetValueModel("Ped 20", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 20", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 20", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 20", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 20", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 20", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 20", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 20", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 20", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 20", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 20", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 20", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 20", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 20", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 20", "CHASE MODE", -1)
                            ElseIf x = 21 Then
                                If Settings.GetValueModel("Ped 21", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 21", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 21", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 21", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 21", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 21", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 21", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 21", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 21", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 21", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 21", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 21", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 21", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 21", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 21", "CHASE MODE", -1)
                            ElseIf x = 22 Then
                                If Settings.GetValueModel("Ped 22", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 22", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 22", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 22", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 22", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 22", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 22", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 22", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 22", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 22", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 22", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 22", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 22", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 22", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 22", "CHASE MODE", -1)
                            ElseIf x = 23 Then
                                If Settings.GetValueModel("Ped 23", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 23", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 23", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 23", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 23", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 23", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 23", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 23", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 23", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 23", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 23", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 23", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 23", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 23", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 23", "CHASE MODE", -1)
                            ElseIf x = 24 Then
                                If Settings.GetValueModel("Ped 24", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 24", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 24", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 24", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 24", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 24", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 24", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 24", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 24", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 24", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 24", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 24", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 24", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 24", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 24", "CHASE MODE", -1)
                            ElseIf x = 25 Then
                                If Settings.GetValueModel("Ped 25", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 25", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 25", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 25", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 25", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 25", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 25", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 25", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 25", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 25", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 25", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 25", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 25", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 25", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 25", "CHASE MODE", -1)
                            ElseIf x = 26 Then
                                If Settings.GetValueModel("Ped 26", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 26", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 26", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 26", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 26", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 26", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 26", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 26", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 26", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 26", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 26", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 26", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 26", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 26", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 26", "CHASE MODE", -1)
                            ElseIf x = 27 Then
                                If Settings.GetValueModel("Ped 27", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 27", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 27", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 27", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 27", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 27", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 27", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 27", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 27", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 27", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 27", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 27", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 27", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 27", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 27", "CHASE MODE", -1)
                            ElseIf x = 28 Then
                                If Settings.GetValueModel("Ped 28", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 28", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 28", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 28", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 28", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 28", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 28", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 28", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 28", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 28", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 28", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 28", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 28", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 28", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 28", "CHASE MODE", -1)
                            ElseIf x = 29 Then
                                If Settings.GetValueModel("Ped 29", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 29", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 29", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 29", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 29", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 29", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 29", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 29", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 29", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 29", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 29", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 29", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 29", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 29", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 29", "CHASE MODE", -1)
                            ElseIf x = 30 Then
                                If Settings.GetValueModel("Ped 30", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 30", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 30", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 30", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 30", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 30", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 30", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 30", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 30", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 30", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 30", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 30", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 30", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 30", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 30", "CHASE MODE", -1)
                            ElseIf x = 31 Then
                                If Settings.GetValueModel("Ped 31", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 31", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 31", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 31", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 31", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 31", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 31", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 31", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 31", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 31", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 31", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 31", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 31", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 31", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 31", "CHASE MODE", -1)
                            ElseIf x = 32 Then
                                If Settings.GetValueModel("Ped 32", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 32", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 32", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 32", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 32", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 32", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 32", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 32", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 32", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 32", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 32", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 32", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 32", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 32", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 32", "CHASE MODE", -1)
                            ElseIf x = 33 Then
                                If Settings.GetValueModel("Ped 33", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 33", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 33", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 33", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 33", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 33", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 33", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 33", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 33", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 33", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 33", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 33", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 33", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 33", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 33", "CHASE MODE", -1)
                            ElseIf x = 34 Then
                                If Settings.GetValueModel("Ped 34", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 34", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 34", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 34", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 34", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 34", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 34", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 34", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 34", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 34", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 34", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 34", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 34", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 34", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 34", "CHASE MODE", -1)
                            ElseIf x = 35 Then
                                If Settings.GetValueModel("Ped 35", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 35", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 35", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 35", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 35", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 35", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 35", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 35", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 35", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 35", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 35", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 35", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 35", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 35", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 35", "CHASE MODE", -1)
                            ElseIf x = 36 Then
                                If Settings.GetValueModel("Ped 36", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 36", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 36", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 36", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 36", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 36", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 36", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 36", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 36", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 36", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 36", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 36", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 36", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 36", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 36", "CHASE MODE", -1)
                            ElseIf x = 37 Then
                                If Settings.GetValueModel("Ped 37", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 37", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 37", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 37", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 37", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 37", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 37", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 37", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 37", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 37", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 37", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 37", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 37", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 37", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 37", "CHASE MODE", -1)
                            ElseIf x = 38 Then
                                If Settings.GetValueModel("Ped 38", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 38", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 38", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 38", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 38", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 38", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 38", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 38", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 38", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 38", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 38", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 38", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 38", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 38", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 38", "CHASE MODE", -1)
                            ElseIf x = 39 Then
                                If Settings.GetValueModel("Ped 39", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 39", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 39", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 39", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 39", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 39", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 39", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 39", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 39", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 39", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 39", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 39", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 39", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 39", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 39", "CHASE MODE", -1)
                            ElseIf x = 40 Then
                                If Settings.GetValueModel("Ped 40", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 40", "CHASE MODE", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 40", "CHASE MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 40", "CHASE MODE", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 40", "CHASE MODE", -1) = -1 Then Settings.SetValue("Weapon 40", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 40", "CHASE MODE", -1) = -1 Then Settings.SetValue("Ammo 40", "CHASE MODE", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 40", "CHASE MODE", -1) = -1 Then Settings.SetValue("No Of Ped 40", "CHASE MODE", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 40", "CHASE MODE", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 40", "CHASE MODE", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 40", "CHASE MODE", -1)
                                am = Settings.GetValueInteger("Ammo 40", "CHASE MODE", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 40", "CHASE MODE", -1)
                            End If
                        End If

                        If Player.WantedLevel = 6 AndAlso heavystuff = "Heavy Tactical" Then
                            If v.isAlive = False Or v = Nothing Then
                                x += 1
                                If x = 31 Then x = 1
                            End If
                            If x = 1 Then
                                If Settings.GetValueModel("Ped 1", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 1", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 1", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 1", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 1", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 1", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 1", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 1", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 1", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 1", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                weapp = Settings.GetValueInteger("Weapon 1", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 1", "Heavy Tactical Mode", -1)
                                pmodel = Settings.GetValueModel("Ped 1", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 1", "Heavy Tactical Mode", "NONE")
                                sit2 = Settings.GetValueInteger("No Of Ped 1", "Heavy Tactical Mode", -1)
                            ElseIf x = 2 Then
                                If Settings.GetValueModel("Ped 2", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 2", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 2", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 2", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 2", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 2", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 2", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 2", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 2", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 2", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 2", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 2", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 2", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 2", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 2", "Heavy Tactical Mode", -1)
                            ElseIf x = 3 Then
                                If Settings.GetValueModel("Ped 3", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 3", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 3", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 3", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 3", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 3", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 3", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 3", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 3", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 3", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 3", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 3", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 3", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 3", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 3", "Heavy Tactical Mode", -1)
                            ElseIf x = 4 Then
                                If Settings.GetValueModel("Ped 4", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 4", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 4", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 4", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 4", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 4", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 4", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 4", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 4", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 4", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 4", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 4", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 4", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 4", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 4", "Heavy Tactical Mode", -1)
                            ElseIf x = 5 Then
                                If Settings.GetValueModel("Ped 5", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 5", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 5", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 5", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 5", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 5", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 5", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 5", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 5", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 5", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 5", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 5", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 5", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 5", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 5", "Heavy Tactical Mode", -1)
                            ElseIf x = 6 Then
                                If Settings.GetValueModel("Ped 6", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 6", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 6", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 6", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 6", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 6", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 6", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 6", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 6", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 6", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 6", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 6", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 6", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 6", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 6", "Heavy Tactical Mode", -1)
                            ElseIf x = 7 Then
                                If Settings.GetValueModel("Ped 7", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 7", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 7", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 7", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 7", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 7", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 7", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 7", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 7", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 7", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 7", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 7", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 7", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 7", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 7", "Heavy Tactical Mode", -1)
                            ElseIf x = 8 Then
                                If Settings.GetValueModel("Ped 8", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 8", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 8", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 8", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 8", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 8", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 8", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 8", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 8", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 8", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 8", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 8", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 8", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 8", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 8", "Heavy Tactical Mode", -1)
                            ElseIf x = 9 Then
                                If Settings.GetValueModel("Ped 9", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 9", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 9", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 9", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 9", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 9", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 9", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 9", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 9", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 9", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 9", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 9", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 9", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 9", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 9", "Heavy Tactical Mode", -1)
                            ElseIf x = 10 Then
                                If Settings.GetValueModel("Ped 10", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 10", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 10", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 10", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 10", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 10", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 10", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 10", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 10", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 10", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 10", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 10", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 10", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 10", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 10", "Heavy Tactical Mode", -1)
                            ElseIf x = 11 Then
                                If Settings.GetValueModel("Ped 11", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 11", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 11", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 11", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 11", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 11", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 11", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 11", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 11", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 11", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 11", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 11", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 11", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 11", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 11", "Heavy Tactical Mode", -1)
                            ElseIf x = 12 Then
                                If Settings.GetValueModel("Ped 12", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 12", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 12", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 12", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 12", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 12", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 12", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 12", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 12", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 12", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 12", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 12", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 12", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 12", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 12", "Heavy Tactical Mode", -1)
                            ElseIf x = 13 Then
                                If Settings.GetValueModel("Ped 13", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 13", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 13", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 13", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 13", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 13", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 13", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 13", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 13", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 13", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 13", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 13", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 13", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 13", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 13", "Heavy Tactical Mode", -1)
                            ElseIf x = 14 Then
                                If Settings.GetValueModel("Ped 14", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 14", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 14", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 14", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 14", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 14", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 14", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 14", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 14", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 14", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 14", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 14", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 14", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 14", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 14", "Heavy Tactical Mode", -1)
                            ElseIf x = 15 Then
                                If Settings.GetValueModel("Ped 15", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 15", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 15", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 15", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 15", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 15", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 15", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 15", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 15", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 15", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 15", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 15", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 15", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 15", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 15", "Heavy Tactical Mode", -1)
                            ElseIf x = 16 Then
                                If Settings.GetValueModel("Ped 16", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 16", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 16", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 16", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 16", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 16", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 16", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 16", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 16", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 16", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 16", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 16", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 16", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 16", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 16", "Heavy Tactical Mode", -1)
                            ElseIf x = 17 Then
                                If Settings.GetValueModel("Ped 17", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 17", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 17", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 17", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 17", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 17", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 17", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 17", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 17", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 17", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 17", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 17", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 17", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 17", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 17", "Heavy Tactical Mode", -1)
                            ElseIf x = 18 Then
                                If Settings.GetValueModel("Ped 18", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 18", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 18", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 18", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 18", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 18", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 18", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 18", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 18", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 18", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 18", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 18", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 18", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 18", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 18", "Heavy Tactical Mode", -1)
                            ElseIf x = 19 Then
                                If Settings.GetValueModel("Ped 19", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 19", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 19", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 19", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 19", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 19", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 19", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 19", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 19", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 19", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 19", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 19", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 19", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 19", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 19", "Heavy Tactical Mode", -1)
                            ElseIf x = 20 Then
                                If Settings.GetValueModel("Ped 20", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 20", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 20", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 20", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 20", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 20", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 20", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 20", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 20", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 20", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 20", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 20", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 20", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 20", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 20", "Heavy Tactical Mode", -1)
                            ElseIf x = 21 Then
                                If Settings.GetValueModel("Ped 21", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 21", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 21", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 21", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 21", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 21", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 21", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 21", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 21", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 21", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 21", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 21", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 21", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 21", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 21", "Heavy Tactical Mode", -1)
                            ElseIf x = 22 Then
                                If Settings.GetValueModel("Ped 22", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 22", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 22", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 22", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 22", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 22", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 22", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 22", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 22", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 22", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 22", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 22", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 22", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 22", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 22", "Heavy Tactical Mode", -1)
                            ElseIf x = 23 Then
                                If Settings.GetValueModel("Ped 23", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 23", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 23", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 23", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 23", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 23", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 23", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 23", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 23", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 23", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 23", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 23", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 23", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 23", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 23", "Heavy Tactical Mode", -1)
                            ElseIf x = 24 Then
                                If Settings.GetValueModel("Ped 24", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 24", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 24", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 24", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 24", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 24", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 24", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 24", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 24", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 24", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 24", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 24", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 24", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 24", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 24", "Heavy Tactical Mode", -1)
                            ElseIf x = 25 Then
                                If Settings.GetValueModel("Ped 25", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 25", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 25", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 25", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 25", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 25", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 25", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 25", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 25", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 25", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 25", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 25", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 25", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 25", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 25", "Heavy Tactical Mode", -1)
                            ElseIf x = 26 Then
                                If Settings.GetValueModel("Ped 26", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 26", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 26", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 26", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 26", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 26", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 26", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 26", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 26", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 26", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 26", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 26", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 26", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 26", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 26", "Heavy Tactical Mode", -1)
                            ElseIf x = 27 Then
                                If Settings.GetValueModel("Ped 27", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 27", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 27", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 27", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 27", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 27", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 27", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 27", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 27", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 27", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 27", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 27", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 27", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 27", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 27", "Heavy Tactical Mode", -1)
                            ElseIf x = 28 Then
                                If Settings.GetValueModel("Ped 28", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 28", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 28", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 28", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 28", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 28", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 28", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 28", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 28", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 28", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 28", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 28", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 28", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 28", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 28", "Heavy Tactical Mode", -1)
                            ElseIf x = 29 Then
                                If Settings.GetValueModel("Ped 29", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 29", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 29", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 29", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 29", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 29", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 29", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 29", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 29", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 29", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 29", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 29", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 29", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 29", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 29", "Heavy Tactical Mode", -1)
                            ElseIf x = 30 Then
                                If Settings.GetValueModel("Ped 30", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Ped 30", "Heavy Tactical Mode", "m_y_swat")
                                Settings.Save()
                                If Settings.GetValueModel("Vehicle 30", "Heavy Tactical Mode", "NONE") = "NONE" Then Settings.SetValue("Vehicle 30", "Heavy Tactical Mode", "noose")
                                Settings.Save()
                                If Settings.GetValueInteger("Weapon 30", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Weapon 30", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("Ammo 30", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("Ammo 30", "Heavy Tactical Mode", 0)
                                Settings.Save()
                                If Settings.GetValueInteger("No Of Ped 30", "Heavy Tactical Mode", -1) = -1 Then Settings.SetValue("No Of Ped 30", "Heavy Tactical Mode", 2)
                                Settings.Save()
                                pmodel = Settings.GetValueModel("Ped 30", "Heavy Tactical Mode", "NONE")
                                vehmodel = Settings.GetValueModel("Vehicle 30", "Heavy Tactical Mode", "NONE")
                                weapp = Settings.GetValueInteger("Weapon 30", "Heavy Tactical Mode", -1)
                                am = Settings.GetValueInteger("Ammo 30", "Heavy Tactical Mode", -1)
                                sit2 = Settings.GetValueInteger("No Of Ped 30", "Heavy Tactical Mode", -1)
                            End If
                        End If
                    End If

                    If oldnew = "Old" AndAlso Player.WantedLevel = (3 Or 4 Or 5 Or 6) Then

                        If v.isAlive = False Or v = Nothing Then
                            x += 1
                            If x = 41 Then x = 1
                        End If

                        If x = 1 Then
                            If Settings.GetValueModel("Ped 1", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 1", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 1", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 1", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 1", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 1", "PURSUIT MODE", 2)
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 1", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 1", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 1", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 1", "PURSUIT MODE", 0)
                            Settings.Save()
                            weapp = Settings.GetValueInteger("Weapon 1", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 1", "PURSUIT MODE", -1)
                            pmodel = Settings.GetValueModel("Ped 1", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 1", "PURSUIT MODE", "NONE")
                            sit2 = Settings.GetValueInteger("No Of Ped 1", "PURSUIT MODE", -1)
                        ElseIf x = 2 Then
                            If Settings.GetValueModel("Ped 2", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 2", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 2", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 2", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 2", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 2", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 2", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 2", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 2", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 2", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 2", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 2", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 2", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 2", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 2", "PURSUIT MODE", -1)
                        ElseIf x = 3 Then
                            If Settings.GetValueModel("Ped 3", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 3", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 3", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 3", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 3", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 3", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 3", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 3", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 3", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 3", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 3", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 3", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 3", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 3", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 3", "PURSUIT MODE", -1)
                        ElseIf x = 4 Then
                            If Settings.GetValueModel("Ped 4", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 4", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 4", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 4", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 4", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 4", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 4", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 4", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 4", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 4", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 4", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 4", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 4", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 4", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 4", "PURSUIT MODE", -1)
                        ElseIf x = 5 Then
                            If Settings.GetValueModel("Ped 5", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 5", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 5", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 5", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 5", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 5", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 5", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 5", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 5", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 5", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 5", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 5", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 5", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 5", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 5", "PURSUIT MODE", -1)
                        ElseIf x = 6 Then
                            If Settings.GetValueModel("Ped 6", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 6", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 6", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 6", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 6", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 6", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 6", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 6", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 6", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 6", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 6", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 6", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 6", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 6", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 6", "PURSUIT MODE", -1)
                        ElseIf x = 7 Then
                            If Settings.GetValueModel("Ped 7", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 7", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 7", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 7", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 7", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 7", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 7", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 7", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 7", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 7", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 7", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 7", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 7", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 7", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 7", "PURSUIT MODE", -1)
                        ElseIf x = 8 Then
                            If Settings.GetValueModel("Ped 8", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 8", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 8", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 8", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 8", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 8", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 8", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 8", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 8", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 8", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 8", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 8", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 8", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 8", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 8", "PURSUIT MODE", -1)
                        ElseIf x = 9 Then
                            If Settings.GetValueModel("Ped 9", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 9", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 9", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 9", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 9", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 9", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 9", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 9", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 9", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 9", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 9", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 9", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 9", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 9", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 9", "PURSUIT MODE", -1)
                        ElseIf x = 10 Then
                            If Settings.GetValueModel("Ped 10", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 10", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 10", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 10", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 10", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 10", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 10", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 10", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 10", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 10", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 10", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 10", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 10", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 10", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 10", "PURSUIT MODE", -1)
                        ElseIf x = 11 Then
                            If Settings.GetValueModel("Ped 11", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 11", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 11", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 11", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 11", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 11", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 11", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 11", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 11", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 11", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 11", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 11", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 11", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 11", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 11", "PURSUIT MODE", -1)
                        ElseIf x = 12 Then
                            If Settings.GetValueModel("Ped 12", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 12", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 12", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 12", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 12", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 12", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 12", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 12", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 12", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 12", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 12", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 12", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 12", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 12", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 12", "PURSUIT MODE", -1)
                        ElseIf x = 13 Then
                            If Settings.GetValueModel("Ped 13", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 13", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 13", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 13", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 13", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 13", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 13", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 13", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 13", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 13", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 13", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 13", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 13", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 13", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 13", "PURSUIT MODE", -1)
                        ElseIf x = 14 Then
                            If Settings.GetValueModel("Ped 14", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 14", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 14", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 14", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 14", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 14", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 14", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 14", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 14", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 14", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 14", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 14", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 14", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 14", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 14", "PURSUIT MODE", -1)
                        ElseIf x = 15 Then
                            If Settings.GetValueModel("Ped 15", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 15", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 15", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 15", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 15", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 15", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 15", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 15", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 15", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 15", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 15", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 15", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 15", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 15", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 15", "PURSUIT MODE", -1)
                        ElseIf x = 16 Then
                            If Settings.GetValueModel("Ped 16", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 16", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 16", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 16", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 16", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 16", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 16", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 16", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 16", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 16", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 16", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 16", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 16", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 16", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 16", "PURSUIT MODE", -1)
                        ElseIf x = 17 Then
                            If Settings.GetValueModel("Ped 17", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 17", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 17", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 17", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 17", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 17", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 17", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 17", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 17", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 17", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 17", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 17", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 17", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 17", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 17", "PURSUIT MODE", -1)
                        ElseIf x = 18 Then
                            If Settings.GetValueModel("Ped 18", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 18", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 18", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 18", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 18", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 18", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 18", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 18", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 18", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 18", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 18", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 18", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 18", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 18", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 18", "PURSUIT MODE", -1)
                        ElseIf x = 19 Then
                            If Settings.GetValueModel("Ped 19", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 19", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 19", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 19", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 19", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 19", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 19", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 19", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 19", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 19", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 19", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 19", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 19", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 19", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 19", "PURSUIT MODE", -1)
                        ElseIf x = 20 Then
                            If Settings.GetValueModel("Ped 20", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 20", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 20", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 20", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 20", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 20", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 20", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 20", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 20", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 20", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 20", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 20", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 20", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 20", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 20", "PURSUIT MODE", -1)
                        ElseIf x = 21 Then
                            If Settings.GetValueModel("Ped 21", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 21", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 21", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 21", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 21", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 21", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 21", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 21", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 21", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 21", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 21", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 21", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 21", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 21", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 21", "PURSUIT MODE", -1)
                        ElseIf x = 22 Then
                            If Settings.GetValueModel("Ped 22", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 22", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 22", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 22", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 22", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 22", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 22", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 22", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 22", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 22", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 22", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 22", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 22", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 22", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 22", "PURSUIT MODE", -1)
                        ElseIf x = 23 Then
                            If Settings.GetValueModel("Ped 23", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 23", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 23", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 23", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 23", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 23", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 23", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 23", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 23", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 23", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 23", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 23", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 23", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 23", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 23", "PURSUIT MODE", -1)
                        ElseIf x = 24 Then
                            If Settings.GetValueModel("Ped 24", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 24", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 24", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 24", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 24", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 24", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 24", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 24", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 24", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 24", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 24", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 24", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 24", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 24", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 24", "PURSUIT MODE", -1)
                        ElseIf x = 25 Then
                            If Settings.GetValueModel("Ped 25", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 25", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 25", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 25", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 25", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 25", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 25", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 25", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 25", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 25", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 25", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 25", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 25", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 25", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 25", "PURSUIT MODE", -1)
                        ElseIf x = 26 Then
                            If Settings.GetValueModel("Ped 26", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 26", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 26", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 26", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 26", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 26", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 26", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 26", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 26", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 26", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 26", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 26", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 26", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 26", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 26", "PURSUIT MODE", -1)
                        ElseIf x = 27 Then
                            If Settings.GetValueModel("Ped 27", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 27", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 27", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 27", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 27", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 27", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 27", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 27", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 27", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 27", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 27", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 27", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 27", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 27", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 27", "PURSUIT MODE", -1)
                        ElseIf x = 28 Then
                            If Settings.GetValueModel("Ped 28", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 28", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 28", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 28", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 28", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 28", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 28", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 28", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 28", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 28", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 28", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 28", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 28", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 28", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 28", "PURSUIT MODE", -1)
                        ElseIf x = 29 Then
                            If Settings.GetValueModel("Ped 29", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 29", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 29", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 29", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 29", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 29", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 29", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 29", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 29", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 29", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 29", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 29", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 29", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 29", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 29", "PURSUIT MODE", -1)
                        ElseIf x = 30 Then
                            If Settings.GetValueModel("Ped 30", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 30", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 30", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 30", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 30", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 30", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 30", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 30", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 30", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 30", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 30", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 30", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 30", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 30", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 30", "PURSUIT MODE", -1)
                        ElseIf x = 31 Then
                            If Settings.GetValueModel("Ped 31", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 31", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 31", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 31", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 31", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 31", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 31", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 31", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 31", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 31", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 31", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 31", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 31", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 31", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 31", "PURSUIT MODE", -1)
                        ElseIf x = 32 Then
                            If Settings.GetValueModel("Ped 32", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 32", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 32", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 32", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 32", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 32", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 32", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 32", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 32", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 32", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 32", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 32", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 32", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 32", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 32", "PURSUIT MODE", -1)
                        ElseIf x = 33 Then
                            If Settings.GetValueModel("Ped 33", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 33", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 33", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 33", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 33", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 33", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 33", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 33", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 33", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 33", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 33", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 33", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 33", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 33", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 33", "PURSUIT MODE", -1)
                        ElseIf x = 34 Then
                            If Settings.GetValueModel("Ped 34", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 34", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 34", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 34", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 34", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 34", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 34", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 34", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 34", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 34", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 34", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 34", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 34", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 34", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 34", "PURSUIT MODE", -1)
                        ElseIf x = 35 Then
                            If Settings.GetValueModel("Ped 35", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 35", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 35", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 35", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 35", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 35", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 35", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 35", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 35", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 35", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 35", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 35", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 35", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 35", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 35", "PURSUIT MODE", -1)
                        ElseIf x = 36 Then
                            If Settings.GetValueModel("Ped 36", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 36", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 36", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 36", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 36", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 36", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 36", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 36", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 36", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 36", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 36", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 36", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 36", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 36", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 36", "PURSUIT MODE", -1)
                        ElseIf x = 37 Then
                            If Settings.GetValueModel("Ped 37", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 37", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 37", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 37", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 37", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 37", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 37", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 37", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 37", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 37", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 37", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 37", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 37", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 37", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 37", "PURSUIT MODE", -1)
                        ElseIf x = 38 Then
                            If Settings.GetValueModel("Ped 38", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 38", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 38", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 38", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 38", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 38", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 38", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 38", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 38", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 38", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 38", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 38", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 38", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 38", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 38", "PURSUIT MODE", -1)
                        ElseIf x = 39 Then
                            If Settings.GetValueModel("Ped 39", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 39", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 39", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 39", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 39", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 39", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 39", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 39", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 39", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 39", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 39", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 39", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 39", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 39", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 39", "PURSUIT MODE", -1)
                        ElseIf x = 40 Then
                            If Settings.GetValueModel("Ped 40", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Ped 40", "PURSUIT MODE", "m_y_swat")
                            Settings.Save()
                            If Settings.GetValueModel("Vehicle 40", "PURSUIT MODE", "NONE") = "NONE" Then Settings.SetValue("Vehicle 40", "PURSUIT MODE", "noose")
                            Settings.Save()
                            If Settings.GetValueInteger("Weapon 40", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Weapon 40", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("Ammo 40", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("Ammo 40", "PURSUIT MODE", 0)
                            Settings.Save()
                            If Settings.GetValueInteger("No Of Ped 40", "PURSUIT MODE", -1) = -1 Then Settings.SetValue("No Of Ped 40", "PURSUIT MODE", 2)
                            Settings.Save()
                            pmodel = Settings.GetValueModel("Ped 40", "PURSUIT MODE", "NONE")
                            vehmodel = Settings.GetValueModel("Vehicle 40", "PURSUIT MODE", "NONE")
                            weapp = Settings.GetValueInteger("Weapon 40", "PURSUIT MODE", -1)
                            am = Settings.GetValueInteger("Ammo 40", "PURSUIT MODE", -1)
                            sit2 = Settings.GetValueInteger("No Of Ped 40", "PURSUIT MODE", -1)
                        End If
                    End If

                    Dim inter As Integer = Settings.GetValueInteger("Spawn Timer", "INTERVAL", 0)

                    Wait(inter)

                    If Not Exists(v) Then
                        v = World.CreateVehicle(vehmodel, Player.Character.Position.Around(175))
                        v.PlaceOnNextStreetProperly()
                        a = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F) + Vector3.WorldUp * 20, RelationshipGroup.Cop)
                        If Exists(a) Then
                            a.Task.WarpIntoVehicle(v, VehicleSeat.Driver)
                            a.NoLongerNeeded()
                        End If
                        b = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(b) Then
                            b.Task.WarpIntoVehicle(v, VehicleSeat.LeftRear)
                            b.NoLongerNeeded()
                        End If
                        Dim c As Ped = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(c) Then
                            c.Task.WarpIntoVehicle(v, VehicleSeat.RightFront)
                            c.NoLongerNeeded()
                        End If
                        Dim d As Ped = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(d) Then
                            d.Task.WarpIntoVehicle(v, VehicleSeat.RightRear)
                            d.NoLongerNeeded()
                        End If

                    ElseIf v.isAlive = False Or v = Nothing Then

                        v = World.CreateVehicle(vehmodel, Player.Character.Position.Around(175))
                        v.PlaceOnNextStreetProperly()
                        a = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F) + Vector3.WorldUp * 20, RelationshipGroup.Cop)
                        If Exists(a) Then
                            a.Task.WarpIntoVehicle(v, VehicleSeat.Driver)
                            a.NoLongerNeeded()
                        End If
                        b = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(b) Then
                            b.Task.WarpIntoVehicle(v, VehicleSeat.LeftRear)
                            b.NoLongerNeeded()
                        End If
                        Dim c As Ped = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(c) Then
                            c.Task.WarpIntoVehicle(v, VehicleSeat.RightFront)
                            c.NoLongerNeeded()
                        End If
                        Dim d As Ped = World.CreatePed(pmodel, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(d) Then
                            d.Task.WarpIntoVehicle(v, VehicleSeat.RightRear)
                            d.NoLongerNeeded()
                        End If
                        v.NoLongerNeeded()
                    End If

                End If
            Catch NonExistingObjectException As GTA.NonExistingObjectException

            Catch AccessViolationException As System.AccessViolationException

            Catch NullReferenceException As System.NullReferenceException

            End Try

        End Sub
    End Class


    Public Class Helicopter

        Inherits Script
        Private str As String = "./scripts/AdditionalHeli.ini"
        Public Sub New()

            If Settings.GetValueInteger("Additional Helicopter", "INTERVAL", 0) = 0 Then Settings.SetValue("Additional Helicopter", "INTERVAL", 25000)
            Settings.Save()
            Me.Interval = Settings.GetValueInteger("Additional Helicopter", "INTERVAL", 0)

        End Sub

        Private bigass, ass As String
        Private v As Vehicle

        Public Shadows Sub KeyDown(ByVal sender As Object, ByVal e As GTA.KeyEventArgs) Handles MyBase.KeyDown
        End Sub

        Public Shadows Sub KeyUp(ByVal sender As Object, ByVal e As GTA.KeyEventArgs) Handles MyBase.KeyUp
        End Sub

        Private Sub General_tick(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick


            If Settings.GetValueString("Spawn Additional Heli", "SETTINGS ON/OFF", "NONE") = "NONE" Then Settings.SetValue("Spawn Additional Heli", "SETTINGS ON/OFF", "False")
            Settings.Save()
            Dim st = Settings.GetValueString("Spawn Additional Heli", "SETTINGS ON/OFF", "NONE")

            If Settings.GetValueString("Pack Insalled", "SETTINGS ON/OFF", "NONE") = "NONE" Then Settings.SetValue("Pack Insalled", "SETTINGS ON/OFF", "False")
            Settings.Save()
            Dim st2 = Settings.GetValueString("Pack Insalled", "SETTINGS ON/OFF", "NONE")

            If st = "True" Then
                Dim wl = Player.WantedLevel

                If (wl > 3 AndAlso wl <= 6) Then

                    Dim rand, rand2 As New Random()

                    Dim flag, flag2 As Integer

                    flag = rand.Next(1, 4)
                    flag2 = rand.Next(1, 7)

                    If flag = 3 Then
                        ass = "polmav"
                    End If
                    If flag = 2 Then
                        ass = "maverick"
                    End If
                    If flag = 1 Then
                        ass = "annihilator"
                    End If
                    If flag2 = 6 Then
                        bigass = "m_y_cop"
                    End If
                    If flag2 = 5 Then
                        bigass = "m_y_cop_traffic"
                    End If
                    If flag2 = 4 Then
                        bigass = "m_y_strooper"
                    End If
                    If flag2 = 3 Then
                        bigass = "m_y_swat"
                    End If
                    If flag2 = 2 Then
                        bigass = "m_m_fbi"
                    End If
                    If flag2 = 1 Then
                        bigass = "m_y_nhelipilot"
                    End If

                    Dim rands As New Random()
                    Dim awm, num As Integer
                    num = rands.Next(1, 3)
                    If st2 = "AddOn" Then
                        If num = 1 Then
                            awm = 43
                        End If
                        If num = 2 Then
                            awm = 34
                        End If
                    End If

                    If st2 = "Episodic" Then
                        awm = 34
                    End If

                    If Not Exists(v) Then
                        v = World.CreateVehicle(ass, Player.Character.Position.Around(175) + Vector3.WorldUp * 50)
                        If ass = "maverick" Then
                            v.Color = ColorIndex.Black
                        End If
                        Dim b, a As Ped
                        a = World.CreatePed(bigass, Player.Character.Position.Around(300.0F) + Vector3.WorldUp * 20, RelationshipGroup.Cop)
                        If Exists(a) Then
                            a.Task.WarpIntoVehicle(v, VehicleSeat.Driver)
                            a.NoLongerNeeded()
                        End If
                        b = World.CreatePed(bigass, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(b) Then
                            b.Task.WarpIntoVehicle(v, VehicleSeat.LeftRear)
                            b.Weapons(awm).Ammo = 500
                            b.NoLongerNeeded()
                        End If
                        Dim c As Ped = World.CreatePed(bigass, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(c) Then
                            c.Task.WarpIntoVehicle(v, VehicleSeat.RightFront)
                            c.NoLongerNeeded()
                            c.Weapons(awm).Ammo = 500
                        End If
                        Dim d As Ped = World.CreatePed(bigass, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(d) Then
                            d.Task.WarpIntoVehicle(v, VehicleSeat.RightRear)
                            d.NoLongerNeeded()
                            d.Weapons(awm).Ammo = 500
                        End If

                    ElseIf v.isAlive = False Or v = Nothing Then

                        v = World.CreateVehicle(ass, Player.Character.Position.Around(175) + Vector3.WorldUp * 50)
                        If ass = "maverick" Then
                            v.SpecularColor = ColorIndex.Black
                            v.Color = ColorIndex.Black
                            v.FeatureColor1 = ColorIndex.Black
                            v.FeatureColor2 = ColorIndex.Black
                        End If
                        Dim b, a As Ped
                        a = World.CreatePed(bigass, Player.Character.Position.Around(300.0F) + Vector3.WorldUp * 20, RelationshipGroup.Cop)
                        If Exists(a) Then
                            a.Task.WarpIntoVehicle(v, VehicleSeat.Driver)
                            a.NoLongerNeeded()
                        End If
                        b = World.CreatePed(bigass, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(b) Then
                            b.Task.WarpIntoVehicle(v, VehicleSeat.LeftRear)
                            b.NoLongerNeeded()
                            b.Weapons(awm).Ammo = 500
                        End If
                        Dim c As Ped = World.CreatePed(bigass, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(c) Then
                            c.Task.WarpIntoVehicle(v, VehicleSeat.RightFront)
                            c.NoLongerNeeded()
                            c.Weapons(awm).Ammo = 500
                        End If
                        Dim d As Ped = World.CreatePed(bigass, Player.Character.Position.Around(300.0F), RelationshipGroup.Cop)
                        If Exists(d) Then
                            d.Task.WarpIntoVehicle(v, VehicleSeat.RightRear)
                            d.NoLongerNeeded()
                            d.Weapons(awm).Ammo = 500
                        End If
                        v.NoLongerNeeded()
                    End If
                End If
            End If
        End Sub

    End Class



    Namespace VWantedMusic
        Public Class Main
            Inherits Script

            Private tempBool As Boolean
            Private isHandleCurrentlyFadingOut As Boolean
            Private [loop] As Boolean
            Private fadeOut As Boolean
            Private fadeIn As Boolean
            Private initalVolume As Integer
            Private musicHandle As Integer
            Private rndSeed As Integer
            Private fadingSpeed As Integer
            Private startAt As Integer
            Private rnd As Random
            Private musicFiles As String()
            Private ReadOnly DataDir As String = Game.InstallFolder & "\scripts\VWantedMusic"

            Private Enum AudioPlayMode
                Play
                Pause
                [Stop]
                None
            End Enum

            Private Function CreateFile(ByVal file As String, ByVal createWithZeroDecibels As Boolean, ByVal Optional dontDestroyOnStreamEnd As Boolean = False, ByVal Optional loopStream As Boolean = False) As Integer
                If Not String.IsNullOrWhiteSpace(file) Then

                    If createWithZeroDecibels Then

                        If dontDestroyOnStreamEnd Then
                            Dim handle As Integer

                            If loopStream Then
                                handle = Bass.BASS_StreamCreateFile(file, 0, 0, BASSFlag.BASS_STREAM_PRESCAN Or BASSFlag.BASS_MUSIC_LOOP)
                            Else
                                handle = Bass.BASS_StreamCreateFile(file, 0, 0, BASSFlag.BASS_STREAM_PRESCAN)
                            End If

                            SetStreamVolume(handle, 0F)
                            Return handle
                        Else
                            Dim handle As Integer = Bass.BASS_StreamCreateFile(file, 0, 0, BASSFlag.BASS_STREAM_AUTOFREE)
                            SetStreamVolume(handle, 0F)
                            Return handle
                        End If
                    Else

                        If dontDestroyOnStreamEnd Then
                            Return Bass.BASS_StreamCreateFile(file, 0, 0, BASSFlag.BASS_STREAM_PRESCAN)
                        Else
                            Return Bass.BASS_StreamCreateFile(file, 0, 0, BASSFlag.BASS_STREAM_AUTOFREE)
                        End If
                    End If
                Else
                    Return 0
                End If
            End Function

            Public Function SetStreamVolume(ByVal stream As Integer, ByVal volume As Single) As Boolean
                If stream <> 0 Then
                    Return Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume / 100.0F)
                Else
                    Return False
                End If
            End Function

            Private Function GetStreamPlayMode(ByVal stream As Integer) As AudioPlayMode
                If stream <> 0 Then

                    Select Case Bass.BASS_ChannelIsActive(stream)
                        Case BASSActive.BASS_ACTIVE_PLAYING
                            Return AudioPlayMode.Play
                        Case BASSActive.BASS_ACTIVE_PAUSED
                            Return AudioPlayMode.Pause
                        Case BASSActive.BASS_ACTIVE_STOPPED
                            Return AudioPlayMode.[Stop]
                        Case Else
                            Return AudioPlayMode.None
                    End Select
                Else
                    Return AudioPlayMode.None
                End If
            End Function

            Private Async Sub FadeStreamOut(ByVal stream As Integer, ByVal after As AudioPlayMode, ByVal Optional fadingSpeed As Integer = 1000)
                If Not isHandleCurrentlyFadingOut Then
                    isHandleCurrentlyFadingOut = True
                    Dim handleVolume As Single = 0F
                    Bass.BASS_ChannelSlideAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, 0F, fadingSpeed)

                    While Bass.BASS_ChannelIsActive(stream) = BASSActive.BASS_ACTIVE_PLAYING
                        Bass.BASS_ChannelGetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, handleVolume)

                        If handleVolume <= 0F Then

                            Select Case after
                                Case AudioPlayMode.[Stop]
                                    Bass.BASS_ChannelStop(stream)
                                    isHandleCurrentlyFadingOut = False
                                    musicHandle = 0
                                Case AudioPlayMode.Pause
                                    Bass.BASS_ChannelPause(stream)
                                    isHandleCurrentlyFadingOut = False
                                    musicHandle = 0
                            End Select

                            Exit While
                        End If

                        Await Task.Delay(5)
                    End While
                End If
            End Sub

            Private Sub FadeStreamIn(ByVal stream As Integer, ByVal fadeToVolumeLevel As Single, ByVal fadingSpeed As Integer)
                Bass.BASS_ChannelPlay(stream, False)
                Bass.BASS_ChannelSlideAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, fadeToVolumeLevel / 100.0F, fadingSpeed)
            End Sub

            Private Sub PlayRandomSoundtrack()
                Try

                    If [loop] Then
                        musicHandle = CreateFile(musicFiles(rnd.[Next](0, musicFiles.Length)), fadeIn, True, True)
                    Else
                        musicHandle = CreateFile(musicFiles(rnd.[Next](0, musicFiles.Length)), fadeIn)
                    End If

                    If musicHandle <> 0 Then

                        If fadeIn Then
                            FadeStreamIn(musicHandle, initalVolume, fadingSpeed)
                        Else
                            Bass.BASS_ChannelPlay(musicHandle, False)
                        End If
                    Else
                        Game.Console.Print("Wanted Music could not play file. musicHandle was zero.")
                    End If

                Catch ex As Exception
                    Game.Console.Print("Wanted Music error in Play method. Details: " & ex.ToString())
                End Try
            End Sub

            Private Sub StopSoundtrack(ByVal Optional instant As Boolean = False)
                If musicHandle <> 0 Then

                    If GetStreamPlayMode(musicHandle) = AudioPlayMode.Play Then

                        If instant Then
                            Bass.BASS_ChannelStop(musicHandle)
                            musicHandle = 0
                        Else

                            If fadeOut Then
                                FadeStreamOut(musicHandle, AudioPlayMode.[Stop], fadingSpeed)
                            Else
                                Bass.BASS_ChannelStop(musicHandle)
                                musicHandle = 0
                            End If
                        End If
                    Else
                        Bass.BASS_ChannelStop(musicHandle)
                        musicHandle = 0
                    End If
                End If
            End Sub

            Private lol As SettingsFile = SettingsFile.Open("./Scripts/WantedMusic.ini")

            Public Sub New()
                Try
                    Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)
                    rndSeed = lol.GetValueInteger("RndSeed", "General", DateTime.Now.Millisecond)
                    [loop] = lol.GetValueBool("Loop", "Music", False)
                    fadeOut = lol.GetValueBool("FadeOut", "Music", True)
                    fadeIn = lol.GetValueBool("FadeIn", "Music", True)
                    fadingSpeed = lol.GetValueInteger("FadingSpeed", "Music", 3000)
                    startAt = lol.GetValueInteger("StartAt", "Music", 3)

                    If startAt < 1 Or startAt > 6 Then
                        startAt = 3
                    End If

                    initalVolume = lol.GetValueInteger("Volume", "Music", 20)
                    rnd = New Random(rndSeed)
                    Me.Interval = 100

                Catch ex As Exception
                    Game.Console.Print("Wanted Music error: " & ex.ToString() & " - Please let the developer know about this problem.")
                End Try
            End Sub

            Private Sub VWantedMusic_ConsoleCommand(ByVal sender As Object, ByVal e As ConsoleEventArgs) Handles MyBase.ConsoleCommand
                Select Case e.Command.ToLower()
                    Case "wmusic:reloadsets"

                        Try
                            Game.Console.Print("WantedMusic: Reloading lol...")
                            [loop] = lol.GetValueBool("Loop", "Music", False)
                            fadeOut = lol.GetValueBool("FadeOut", "Music", True)
                            fadeIn = lol.GetValueBool("FadeIn", "Music", True)
                            fadingSpeed = lol.GetValueInteger("FadingSpeed", "Music", 3000)
                            startAt = lol.GetValueInteger("StartAt", "Music", 3)

                            If startAt < 1 Or startAt > 6 Then
                                startAt = 3
                            End If

                            initalVolume = lol.GetValueInteger("Volume", "Music", 20)
                            Game.Console.Print("WantedMusic: Ready.")
                        Catch ex As Exception
                            Game.Console.Print("WantedMusic error while reloading lol: " & ex.Message)
                        End Try
                End Select
            End Sub

            Private Sub VWantedMusic_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick
                If Directory.Exists(DataDir) Then
                    musicFiles = Directory.EnumerateFiles(DataDir).Where(Function(file) Path.GetExtension(file) = ".mp3" OrElse Path.GetExtension(file) = ".wav").ToArray()

                    If musicFiles.Length <> 0 Then

                        If Game.LocalPlayer.WantedLevel >= startAt Then

                            If Not isHandleCurrentlyFadingOut Then

                                If Not tempBool Then
                                    PlayRandomSoundtrack()
                                    tempBool = True
                                End If
                            End If
                        ElseIf Game.LocalPlayer.WantedLevel = 0 Then

                            If tempBool Then
                                StopSoundtrack()
                                tempBool = False
                            End If

                            If Not isHandleCurrentlyFadingOut Then

                                If GetStreamPlayMode(musicHandle) = AudioPlayMode.Play Then

                                    If fadeOut Then
                                        FadeStreamOut(musicHandle, AudioPlayMode.[Stop], fadingSpeed)
                                    Else
                                        Bass.BASS_ChannelStop(musicHandle)
                                        musicHandle = 0
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End Sub
        End Class
    End Namespace


End Namespace