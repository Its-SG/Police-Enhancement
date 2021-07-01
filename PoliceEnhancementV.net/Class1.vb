Imports System
Imports GTA

Public Class PoliceEnhancementV
    Inherits Script

    Public Sub New()

    End Sub


    Private Sub OnTick(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick

        Dim a, b, c, d, f, g As Ped
        Dim v As Vehicle

        If Game.Player.WantedLevel = 4 Then
            v = World.CreateVehicle("barracks", Game.Player.Character.Position.Around(50), 0)
            v.PlaceOnNextStreet()
            a = World.CreatePed("s_m_y_swat_01", Game.Player.Character.Position.Around(150), 0)
            b = World.CreatePed("s_m_y_swat_01", Game.Player.Character.Position.Around(150), 0)
            c = World.CreatePed("s_m_y_swat_01", Game.Player.Character.Position.Around(150), 0)
            d = World.CreatePed("s_m_y_swat_01", Game.Player.Character.Position.Around(150), 0)
            g = World.CreatePed("s_m_y_swat_01", Game.Player.Character.Position.Around(150), 0)
            f = World.CreatePed("s_m_y_swat_01", Game.Player.Character.Position.Around(150), 0)

            a.Task.WarpIntoVehicle(v, VehicleSeat.Driver)
            b.Task.WarpIntoVehicle(v, VehicleSeat.LeftRear)
            c.Task.WarpIntoVehicle(v, VehicleSeat.RightRear)
            d.Task.WarpIntoVehicle(v, VehicleSeat.RightFront)
            f.Task.WarpIntoVehicle(v, VehicleSeat.ExtraSeat1)
            g.Task.WarpIntoVehicle(v, VehicleSeat.ExtraSeat2)
            v.MarkAsNoLongerNeeded()
            g.Weapons.Give(WeaponHash.SpecialCarbineMk2, 400, True, True)
        End If



    End Sub

End Class
