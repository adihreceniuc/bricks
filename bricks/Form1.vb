Public Class Form1
    Dim Vspeed As Single = 4
    Dim Ospeed As Single = -4
    Dim linii As Integer = 9
    Dim coloane As Integer = 8
    Dim pozitiecaramida As Single = 0.15
    Dim inaltimecaramida As Single = 0.05
    Dim scor As Single = 0
    Dim check As Boolean = False
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Verificare partea de sus a ecranului

        If minge.Top < 0 Then
            Vspeed = -Vspeed
            My.Computer.Audio.Play(My.Resources.misc124, AudioPlayMode.Background)
        End If
        'Verificare stanga ecranului

        If minge.Left < 0 Then
            Ospeed = -Ospeed
            My.Computer.Audio.Play(My.Resources.misc124, AudioPlayMode.Background)
        End If
        'Verificare partea de jos a ecranului
        If minge.Bottom > Me.ClientRectangle.Height Then
            minge.Visible = False
            Timer1.Enabled = False
            My.Computer.Audio.Play(My.Resources.gameover, AudioPlayMode.Background)
            MsgBox("Ai pierdut!!!")
        End If
        'Verificare partea dreapta a ecranului
        If minge.Right > Me.ClientRectangle.Width Then
            Ospeed = -Ospeed
            My.Computer.Audio.Play(My.Resources.misc124, AudioPlayMode.Background)
        End If

        Dim c As Single = minge.Left + minge.Width / 2
        'Verificare lovitura bara
        If c > bara.Left And c < bara.Right And Vspeed > 0 And minge.Bottom > bara.Top And minge.Top < bara.Top Then
            Vspeed = -Vspeed
            My.Computer.Audio.Play(My.Resources.misc124, AudioPlayMode.Background)
        End If
        'Verificare lovitura caramida
        Dim cnt As Control
        For Each cnt In Me.Controls
            If cnt.Name = "caramida" Then
                Checkcaramida(cnt, minge)
            End If
        Next
        minge.Left += Ospeed
        minge.Top += Vspeed

    End Sub
    'functia de verificare lovitura caramida
    Private Sub Checkcaramida(ByVal caramida As Button, ByVal minge As Button)
        If caramida.Visible Then
            Dim lovit As Boolean = False
            Dim c As Single = minge.Left + minge.Width / 2
            'Verificare partea de jos a caramizii
            If Vspeed < 0 And c > caramida.Left And c < caramida.Right And minge.Top < caramida.Bottom And minge.Bottom > caramida.Bottom Then
                Vspeed = -Vspeed
                lovit = True
            End If
            'Verificare partea de sus a caramizii
            If Vspeed > 0 And c > caramida.Left And c < caramida.Right And minge.Bottom > caramida.Top And minge.Top < caramida.Top Then
                Vspeed = -Vspeed
                lovit = True
            End If
            c = minge.Top + minge.Height / 2
            'Verificarea partea stanga a caramizii
            If Ospeed > 0 And c > caramida.Top And c < caramida.Bottom And minge.Right > caramida.Left And minge.Left < caramida.Left Then
                Ospeed = -Ospeed
                lovit = True
            End If
            'Verificarea partea dreapta a caramizii
            If Ospeed < 0 And c > caramida.Top And c < caramida.Bottom And minge.Left < caramida.Right And minge.Right > caramida.Right Then
                Ospeed = -Ospeed
                lovit = True
            End If
            If lovit Then If caramida.BackColor = Color.DarkBlue Then caramida.BackColor = Color.Purple Else If caramida.BackColor = Color.Purple Then caramida.BackColor = Color.Red Else If caramida.BackColor = Color.Red Then caramida.Visible = False
            If lovit Then My.Computer.Audio.Play(My.Resources.hit, AudioPlayMode.Background)
            If caramida.Visible = False Then scor = scor + 1
            scr.Text = scor
            scr.Visible = True
        End If

    End Sub
    'Functia de creare caramizi
    Private Sub caramizi()
        For Each item As Control In Me.Controls
            If TypeOf item Is Button Then
                item.Hide()
            End If
        Next

        For i As Integer = 0 To linii - 1
            For z As Integer = 0 To coloane - 1
                Dim b As New Button
                Me.Controls.Add(b)
                b.Visible = True
                b.Name = "caramida"
                b.Width = Me.ClientRectangle.Width / coloane
                b.Height = Me.ClientRectangle.Height * inaltimecaramida
                b.Left = z * b.Width
                b.Top = Me.ClientRectangle.Height * (pozitiecaramida + i * inaltimecaramida)
                b.BackColor = Color.Purple
                b.Enabled = False
                If (i > linii - 4) Then
                    b.BackColor = Color.DarkBlue
                End If
                If (i < linii - 6) Then
                    b.BackColor = Color.Red
                End If
            Next
        Next
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        minge.Visible = False
        bara.Visible = False

    End Sub
    'bara de jos
    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        bara.Width = 0.3 * Me.ClientRectangle.Width
        bara.Height = 0.05 * Me.ClientRectangle.Height
        bara.Top = 0.95 * Me.ClientRectangle.Height
        bara.Left = e.X - (0.15 * Me.ClientRectangle.Width)
        If scor = linii * coloane And check = False Then
            minge.Hide()
            minge.Enabled = False
            Timer1.Enabled = False
            check = True
            My.Computer.Audio.Play(My.Resources.applause3, AudioPlayMode.Background)
            MsgBox("Felicitari!!!")
            bara.Hide()
        End If
    End Sub

    Private Sub IesireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IesireToolStripMenuItem.Click
        If MsgBox("Sigur doriti sa inchideti programul", vbOKCancel, "iesire") = MsgBoxResult.Cancel Then
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub

    Private Sub AutorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutorToolStripMenuItem.Click
        MsgBox("Hreceniuc Adi,grupa 3122A,Proiect PAG,Bricks")
    End Sub

    Private Sub StartToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem1.Click

        BackgroundImage = Nothing
        RestartToolStripMenuItem.Enabled = True
        'incarcare caramizi
        caramizi()
        Timer1.Enabled = True
        minge.Visible = True
        bara.Visible = True
        StartToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        scor = 0
        caramizi()
        Timer1.Enabled = True
        minge.Visible = True
        bara.Visible = True
        minge.Location = New Point(243, 243)

    End Sub

    Private Sub InfoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem1.Click
        MsgBox("Se joaca cu ajutorul mouseului.Distruge toate caramizile!!!")
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
    End Sub
End Class
