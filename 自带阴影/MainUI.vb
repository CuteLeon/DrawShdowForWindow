Public Class MainUI

    '鼠标拖动窗体
    Private Declare Function ReleaseCapture Lib "user32" () As Integer
    Private Declare Function SendMessageA Lib "user32" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As VariantType) As Integer

    Private Sub MainUI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Public Sub MoveWindow(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Label1.MouseDown, Label2.MouseDown, Label3.MouseDown, Label4.MouseDown
        If Not (e.Button = Windows.Forms.MouseButtons.Left) Then Exit Sub
        ReleaseCapture()
        SendMessageA(Me.Handle, &HA1, 2, 0&)
    End Sub

    Private Sub MainUI_Move(sender As Object, e As EventArgs) Handles Me.Move
        '窗体移动，使阴影窗体跟随。
        ShadowWindow.Left = Me.Left - ShadowWindow.ShadowSize - Math.Cos(2 * Math.PI * ShadowWindow.ShadowAngle / 360) * ShadowWindow.ShadowDistance
        ShadowWindow.Top = Me.Top - ShadowWindow.ShadowSize + Math.Sin(2 * Math.PI * ShadowWindow.ShadowAngle / 360) * ShadowWindow.ShadowDistance
    End Sub

    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SizePro.Value = ShadowWindow.ShadowSize
        DistancePro.Value = ShadowWindow.ShadowDistance
        AnglePro.Value = ShadowWindow.ShadowAngle
        OpacityPro.Value = ShadowWindow.ShadowOpacity * 100
        RPro.Value = 0
        GPro.Value = 0
        BPro.Value = 0
    End Sub

    Private Sub MainUI_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Static ControlShown As Boolean = True
        ControlShown = Not ControlShown
        For Each MyControl In Me.Controls
            MyControl.Visible = ControlShown
        Next
    End Sub

    Private Sub ProgressBar1_MouseClick(sender As Object, e As MouseEventArgs) Handles SizePro.MouseClick
        SizePro.Value = e.X / SizePro.Width * SizePro.Maximum
    End Sub

    Private Sub SizePro_MouseClick(sender As Object, e As MouseEventArgs) Handles SizePro.MouseClick
        If Not (e.Button = Windows.Forms.MouseButtons.Left) Then Exit Sub
        '调整阴影SizePro
        SizePro.Value = e.X / SizePro.Width * SizePro.Maximum
        Label1.Text = "SizePro:" & SizePro.Value
        ShadowWindow.DrewShadow(Me, DistancePro.Value, SizePro.Value, AnglePro.Value, ShadowWindow.ShadowColor, OpacityPro.Value / 100)
        ShadowWindow.ShadowSize = SizePro.Value
    End Sub

    Private Sub DistancePro_MouseClick(sender As Object, e As MouseEventArgs) Handles DistancePro.MouseClick
        If Not (e.Button = Windows.Forms.MouseButtons.Left) Then Exit Sub
        '调整阴影DistancePro
        DistancePro.Value = e.X / DistancePro.Width * DistancePro.Maximum
        Label2.Text = "DistancePro:" & DistancePro.Value
        ShadowWindow.DrewShadow(Me, DistancePro.Value, SizePro.Value, AnglePro.Value, ShadowWindow.ShadowColor, OpacityPro.Value / 100)
        ShadowWindow.ShadowDistance = DistancePro.Value
    End Sub

    Private Sub AnglePro_MouseClick(sender As Object, e As MouseEventArgs) Handles AnglePro.MouseClick
        If Not (e.Button = Windows.Forms.MouseButtons.Left) Then Exit Sub
        '调整阴影AnglePro
        AnglePro.Value = e.X / AnglePro.Width * AnglePro.Maximum
        Label3.Text = "AnglePro:" & AnglePro.Value
        ShadowWindow.DrewShadow(Me, DistancePro.Value, SizePro.Value, AnglePro.Value, ShadowWindow.ShadowColor, OpacityPro.Value / 100)
        ShadowWindow.ShadowAngle = AnglePro.Value
    End Sub

    Private Sub OpacityPro_MouseClick(sender As Object, e As MouseEventArgs) Handles OpacityPro.MouseClick
        If Not (e.Button = Windows.Forms.MouseButtons.Left) Then Exit Sub
        '调整阴影OpacityPro
        OpacityPro.Value = e.X / OpacityPro.Width * OpacityPro.Maximum
        Label4.Text = "OpacityPro:" & OpacityPro.Value
        ShadowWindow.DrewShadow(Me, DistancePro.Value, SizePro.Value, AnglePro.Value, ShadowWindow.ShadowColor, OpacityPro.Value / 100)
        ShadowWindow.ShadowOpacity = OpacityPro.Value / 100
    End Sub

    Private Sub ColorPro(sender As Object, e As MouseEventArgs) Handles RPro.MouseClick, GPro.MouseClick, BPro.MouseClick
        Dim ColorPro As ProgressBar = CType(sender, ProgressBar)
        ColorPro.Value = e.X / ColorPro.Width * ColorPro.Maximum
        Label5.Text = "颜色.红：" & RPro.Value
        Label6.Text = "颜色.绿：" & GPro.Value
        Label7.Text = "颜色.蓝：" & BPro.Value

        ShadowWindow.ShadowColor = Color.FromArgb(RPro.Value, GPro.Value, BPro.Value)
        ShadowWindow.DrewShadow(Me, DistancePro.Value, SizePro.Value, AnglePro.Value, ShadowWindow.ShadowColor, OpacityPro.Value / 100)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub MainUI_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        ShadowWindow.DrewShadow(Me, DistancePro.Value, SizePro.Value, AnglePro.Value, ShadowWindow.ShadowColor, OpacityPro.Value / 100)
    End Sub
End Class