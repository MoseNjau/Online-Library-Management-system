Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class CustomButton
    Inherits Button

    Public Sub New()
        ' Set default properties or customize behavior here
        Me.FlatStyle = FlatStyle.Flat
        Me.BackColor = Color.FromArgb(128, Color.Navy) ' Semi-transparent Navy blue background color
        Me.Font = New Font("Times New Roman", 12) ' Times New Roman font, size 12
        Me.ForeColor = Color.Black ' Black font color
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim buttonRect As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim cornerRadius As Integer = 20 ' Border radius

        Using path As GraphicsPath = GetRoundedRectangle(buttonRect, cornerRadius)
            Using brush As SolidBrush = New SolidBrush(Me.BackColor)
                e.Graphics.FillPath(brush, path)
            End Using
        End Using

        Dim textRect As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font, textRect, Me.ForeColor)

        ' Call base class OnPaint method to ensure button functionality remains intact
        MyBase.OnPaint(e)
    End Sub

    Private Function GetRoundedRectangle(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As GraphicsPath = New GraphicsPath()
        Dim diameter As Integer = radius * 2
        Dim arc As Rectangle = New Rectangle(rect.Location, New Size(diameter, diameter))

        ' Top left corner
        path.AddArc(arc, 180, 90)
        ' Top right corner
        arc.X = rect.Right - diameter
        path.AddArc(arc, 270, 90)
        ' Bottom right corner
        arc.Y = rect.Bottom - diameter
        path.AddArc(arc, 0, 90)
        ' Bottom left corner
        arc.X = rect.Left
        path.AddArc(arc, 90, 90)
        path.CloseFigure()

        Return path
    End Function
End Class
