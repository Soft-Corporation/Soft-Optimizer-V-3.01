Imports MaterialSkin


Imports System.Management
Imports System.Text


Public Class Task

    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer





    Private Sub Task_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Label7.Hide()


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\11") Then
            Timer2.Interval = 200

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\22") Then
            Timer2.Interval = 100

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\33") Then
            Timer2.Interval = 50

        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\1") Then
            Timer3.Interval = 200

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\2") Then
            Timer3.Interval = 100

        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\3") Then
            Timer3.Interval = 50

        End If



        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer4.Start()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()


        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer4.Stop()
            Timer5.Start()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Start()
            Timer7.Stop()
            Timer8.Stop()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Start()
            Timer8.Stop()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Start()


        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Gold") Then
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Start()
        End If




        Label7.Text = "Ram Totale: " & Math.Round(My.Computer.Info.TotalPhysicalMemory / 1000000000) & " Gb"



        Dim _namespace$ = "root\CIMV2"
        Dim wql = "SELECT * FROM WIN32_PROCESSOR"
        Dim _stBuilder As New StringBuilder

        Using _moSearcher As New ManagementObjectSearcher(_namespace, wql)

            For Each _moject As ManagementObject In _moSearcher.Get
                Label8.Text = $"Cpu : {_moject("Name")}"
            Next



        End Using

    End Sub
    Dim ram, cpu As Integer

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick



        If CircularProgressBar2.Value < ram Then
            CircularProgressBar2.Value += 1
            CircularProgressBar4.Value += 1
        ElseIf CircularProgressBar2.Value > ram Then
            CircularProgressBar2.Value -= 1
        CircularProgressBar4.Value -= 1


        End If



        CircularProgressBar2.Text = CircularProgressBar2.Value & "%"



    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        Speed.Show()

    End Sub

    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs)
        Panel1.Show()

        CircularProgressBar2.Hide()

    End Sub

    Private Sub CircularProgressBar3_Click(sender As Object, e As EventArgs) Handles CircularProgressBar3.Click
        Panel1.Show()
        Label8.Show()
        Label7.Hide()
        CircularProgressBar2.Hide()
    End Sub

    Private Sub CircularProgressBar4_Click(sender As Object, e As EventArgs) Handles CircularProgressBar4.Click
        Panel1.Hide()
        CircularProgressBar2.Show()
        Label7.Show()
        Label8.Hide()
    End Sub

    Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs)
        Panel1.Hide()
        CircularProgressBar2.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Speed.Show()
    End Sub





    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel3.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Panel1.Hide()
        CircularProgressBar2.Show()
        Label7.Show()
        Label8.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Panel1.Show()
        Label8.Show()
        Label7.Hide()
        CircularProgressBar2.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub



    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Panel3.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel3.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel3.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel3.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cpu = PerformanceCounter1.NextValue

        ram = PerformanceCounter2.NextValue

    End Sub

    Private Sub Timer3_Tick_1(sender As Object, e As EventArgs) Handles Timer3.Tick
        If CircularProgressBar1.Value < cpu Then
            CircularProgressBar1.Value += 1
            CircularProgressBar3.Value += 1
        ElseIf CircularProgressBar1.Value > cpu Then
            CircularProgressBar1.Value -= 1
            CircularProgressBar3.Value -= 1


        End If

        CircularProgressBar1.Text = CircularProgressBar1.Value & "%"



    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Panel3.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If
    End Sub

    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
End Class