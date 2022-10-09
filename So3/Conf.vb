Imports System.IO
Imports MaterialSkin
Public Class Conf
    Private Sub Conf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
        Timer2.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick




        Directory.CreateDirectory(Application.StartupPath & "\Blue")
        Directory.CreateDirectory(Application.StartupPath & "\Conf")
        Directory.CreateDirectory(Application.StartupPath & "\3")
        Directory.CreateDirectory(Application.StartupPath & "\Up")
        Directory.CreateDirectory(Application.StartupPath & "\33")




        Form1.Close()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Conf") Then
            Form1.Show()
            Me.Close()
        End If

    End Sub
End Class