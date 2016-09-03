Public Class ShadowWindow
    '初始的过程参数
    Public ShadowSize As Integer = 15                     '阴影大小
    Public ShadowDistance As Integer = 35             '阴影距离
    Public ShadowAngle As Integer = 135               '阴影角度
    Public ShadowColor As Color = Color.Black      '阴影颜色
    Public ShadowOpacity As Single = 0.75             '阴影不透明度

    '鼠标穿透阴影
    Private Declare Function GetWindowLong Lib "User32" Alias "GetWindowLongA" (ByVal hWnd As Integer, ByVal nIndex As Integer) As Integer
    Private Declare Function SetWindowLong Lib "User32" Alias "SetWindowLongA" (ByVal hWnd As Integer, ByVal nIndex As Integer, ByVal dwNewinteger As Integer) As Integer

    Private Sub ShadowWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '程序启动时调用
        DrewShadow(MainUI, ShadowDistance, ShadowSize, ShadowAngle, ShadowColor, ShadowOpacity)
        '窗体添加鼠标穿透功能，不会影响用户的鼠标操作
        SetWindowLong(Me.Handle, -20, GetWindowLong(Me.Handle, -20) Or &H80000 Or &H20&)
    End Sub

    Public Sub DrewShadow(ByVal UIWindow As Form, ByVal ShadowDistance As Integer, ByVal ShadowSize As Integer,
                          ByVal ShadowAngle As Integer, ByVal ShadowColor As Color, Optional ByVal ShadowOpacity As Single = 0.75)
        'MianUI显示在阴影窗体前
        If Not UIWindow.Visible Then UIWindow.Show(Me)

        Dim DoubleSize As Integer = ShadowSize * 2 '双倍阴影大小，后面用的次数较多，所以多分配四个字节的内存以减少运算次数

        With Me
            .Width = UIWindow.Width + DoubleSize
            .Height = UIWindow.Height + DoubleSize

            '阴影位置与角度和距离参数有关
            .Left = UIWindow.Left - ShadowSize - Math.Cos(2 * Math.PI * ShadowAngle / 360) * ShadowDistance
            .Top = UIWindow.Top - ShadowSize + Math.Sin(2 * Math.PI * ShadowAngle / 360) * ShadowDistance
        End With

        Dim ShadowBitmap As New Bitmap(Me.Width, Me.Height)   '绘制阴影的位图
        Dim ShadowX, ShadowY As Integer     '循环里当做循环变量并定位像素
        Dim Distance As Integer     '绘制圆角阴影时计算像素与圆心距离

        '阴影是中心对称图形，所以只需要循环到一半宽度和高度，提高50%工作效率
        Dim RightBorder = (ShadowBitmap.Width - 1) \ 2
        Dim DownBorder = (ShadowBitmap.Height - 1) \ 2 '

        '处理“阴影大小大于MainUI二分之一“的情况
        Dim ForX As Integer = DoubleSize, ForY As Integer = DoubleSize
        If DoubleSize > DownBorder Then ForY = DownBorder
        If DoubleSize > RightBorder Then ForX = RightBorder


        '绘制Alpha抛物线性渐变的上下边框阴影
        For ShadowX = DoubleSize To RightBorder
            For ShadowY = 0 To ForY
                ShadowBitmap.SetPixel(ShadowX, ShadowY, Color.FromArgb(255 * ShadowOpacity * ShadowY ^ 2 / DoubleSize ^ 2, ShadowColor))
                ShadowBitmap.SetPixel(ShadowBitmap.Width - ShadowX - 1, ShadowY, Color.FromArgb(255 * ShadowOpacity * ShadowY ^ 2 / DoubleSize ^ 2, ShadowColor))
                ShadowBitmap.SetPixel(ShadowX, ShadowBitmap.Height - ShadowY - 1, Color.FromArgb(255 * ShadowOpacity * ShadowY ^ 2 / DoubleSize ^ 2, ShadowColor))
                ShadowBitmap.SetPixel(ShadowBitmap.Width - ShadowX - 1, ShadowBitmap.Height - ShadowY - 1, Color.FromArgb(255 * ShadowOpacity * ShadowY ^ 2 / DoubleSize ^ 2, ShadowColor))
            Next
        Next
        '绘制Alpha抛物线性渐变的左右边框阴影
        For ShadowX = 0 To ForX
            For ShadowY = DoubleSize To DownBorder
                ShadowBitmap.SetPixel(ShadowX, ShadowY, Color.FromArgb(255 * ShadowOpacity * ShadowX ^ 2 / DoubleSize ^ 2, ShadowColor))
                ShadowBitmap.SetPixel(ShadowBitmap.Width - ShadowX - 1, ShadowY, Color.FromArgb(255 * ShadowOpacity * ShadowX ^ 2 / DoubleSize ^ 2, ShadowColor))
                ShadowBitmap.SetPixel(ShadowX, ShadowBitmap.Height - ShadowY - 1, Color.FromArgb(255 * ShadowOpacity * ShadowX ^ 2 / DoubleSize ^ 2, ShadowColor))
                ShadowBitmap.SetPixel(ShadowBitmap.Width - ShadowX - 1, ShadowBitmap.Height - ShadowY - 1, Color.FromArgb(255 * ShadowOpacity * ShadowX ^ 2 / DoubleSize ^ 2, ShadowColor))
            Next
        Next
        '绘制Alpha抛物线性渐变的四个圆角阴影
        For ShadowX = 0 To ForX
            For ShadowY = 0 To ForY
                Distance = DoubleSize - Math.Round(Math.Sqrt((DoubleSize - ShadowX) ^ 2 + (DoubleSize - ShadowY) ^ 2))
                If Distance > -1 Then
                    ShadowBitmap.SetPixel(ShadowX, ShadowY, Color.FromArgb(255 * ShadowOpacity * Distance ^ 2 / DoubleSize ^ 2, ShadowColor)) '左上
                    ShadowBitmap.SetPixel(ShadowBitmap.Width - ShadowX - 1, ShadowY, Color.FromArgb(255 * ShadowOpacity * Distance ^ 2 / DoubleSize ^ 2, ShadowColor)) '右上
                    ShadowBitmap.SetPixel(ShadowX, ShadowBitmap.Height - ShadowY - 1, Color.FromArgb(255 * ShadowOpacity * Distance ^ 2 / DoubleSize ^ 2, ShadowColor)) '左下
                    ShadowBitmap.SetPixel(ShadowBitmap.Width - ShadowX - 1, ShadowBitmap.Height - ShadowY - 1, Color.FromArgb(255 * ShadowOpacity * Distance ^ 2 / DoubleSize ^ 2, ShadowColor)) '右下
                End If
            Next
        Next
        '如果阴影大小不大于MainUI二分之一，就用阴影色填充阴影的中心区域，Alpha为255，无透明
        If Not (ForX = RightBorder Or ForY = DownBorder) Then
            For ShadowX = DoubleSize To ShadowBitmap.Width - DoubleSize - 1
                For ShadowY = DoubleSize To ShadowBitmap.Height - DoubleSize - 1
                    ShadowBitmap.SetPixel(ShadowX, ShadowY, Color.FromArgb(ShadowColor.A * ShadowOpacity, ShadowColor))
                Next
            Next
        End If

        '创建hDC,绘制阴影到屏幕
        SetAlphaPicture(Me, ShadowBitmap)
    End Sub

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            If Not DesignMode Then
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ExStyle = cp.ExStyle Or Win32.WS_EX_LAYERED
                Return cp
            Else
                Return MyBase.CreateParams
            End If
        End Get
    End Property

End Class