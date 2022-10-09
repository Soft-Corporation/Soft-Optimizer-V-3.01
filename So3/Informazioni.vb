Imports MaterialSkin
Imports System.IO
Imports System.Net

Public Class Informazioni

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
    Private Sub Informazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    End Sub
    Public WithEvents download As New WebClient

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        download.DownloadFileAsync(New Uri("Server Fpt Url"), Application.StartupPath & "\Updater.txt")


        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/soft-usb-passwords-beta-1-01")
        Else
            MsgBox("Aggiornato")

        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        On Error Resume Next
        Timer2.Stop()
        Directory.Delete(Application.StartupPath & "\Updater.txt")

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            Directory.Delete(Application.StartupPath & "\Up ")
            MsgBox("Aggiornato automatico all'avvio disattivato")
        Else
            Directory.CreateDirectory(Application.StartupPath & "\Up")
            MsgBox("Aggiornamento automatico all'avvio attivato")
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Soft%20Optimizer%203.01/Ver.txt"), Application.StartupPath & "\Updater.txt")


        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            Directory.Delete(Application.StartupPath & "\Up ")
            MsgBox("Aggiornato automatico all'avvio disattivato")
        Else
            Directory.CreateDirectory(Application.StartupPath & "\Up")
            MsgBox("Aggiornamento automatico all'avvio attivato")
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class