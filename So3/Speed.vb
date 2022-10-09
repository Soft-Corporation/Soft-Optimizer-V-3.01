Imports System.IO
Imports MaterialSkin
Public Class Speed

    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If


    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        Task.Timer1.Interval = 200
        Task.Timer2.Interval = 200

        Directory.CreateDirectory(Application.StartupPath & "\1")
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\2")
        Directory.Delete(Application.StartupPath & "\3")
        MsgBox("Operazione completata con sucesso")
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        Task.Timer1.Interval = 100
        Task.Timer2.Interval = 100

        Directory.CreateDirectory(Application.StartupPath & "\2")
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\1")
        Directory.Delete(Application.StartupPath & "\3")
        MsgBox("Operazione completata con sucesso")
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        Task.Timer1.Interval = 50
        Task.Timer2.Interval = 50

        Directory.CreateDirectory(Application.StartupPath & "\3")
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\1")
        Directory.Delete(Application.StartupPath & "\2")
        MsgBox("Operazione completata con sucesso")
    End Sub

    Private Sub Speed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()



        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer2.Start()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()


        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer2.Stop()
            Timer3.Start()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Start()
            Timer5.Stop()
            Timer6.Stop()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Start()
            Timer6.Stop()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Start()


        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Gold") Then
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Start()


        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If Task.Visible Then
        'Me.Show()
        'Else
        'Me.Close()
        'End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        Task.Timer3.Interval = 200

        Directory.CreateDirectory(Application.StartupPath & "\1")
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\2")
        Directory.Delete(Application.StartupPath & "\3")
        MsgBox("Operazione completata con sucesso")
    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Task.Timer3.Interval = 100


        Directory.CreateDirectory(Application.StartupPath & "\2")
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\1")
        Directory.Delete(Application.StartupPath & "\3")
        MsgBox("Operazione completata con sucesso")
    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Task.Timer3.Interval = 50


        Directory.CreateDirectory(Application.StartupPath & "\3")
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\1")
        Directory.Delete(Application.StartupPath & "\2")
        MsgBox("Operazione completata con sucesso")
    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Timer2.Interval = 200
        Directory.CreateDirectory(Application.StartupPath & "\11")
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\22")
        Directory.Delete(Application.StartupPath & "\33")
        MsgBox("Operazione completata con sucesso")
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Timer2.Interval = 100
        Directory.CreateDirectory(Application.StartupPath & "\22")
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\11")
        Directory.Delete(Application.StartupPath & "\33")
        MsgBox("Operazione completata con sucesso")
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Timer2.Interval = 50
        Directory.CreateDirectory(Application.StartupPath & "\33")
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\22")
        Directory.Delete(Application.StartupPath & "\11")
        MsgBox("Operazione completata con sucesso")
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class