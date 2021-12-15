Imports System.Drawing.Drawing2D
Imports iRISTheme.Src.Helpers

Namespace Src.Utilities
    ''' <summary>
    ''' GraphicsUtilities provides extra methods for graphics.
    ''' </summary>
    Public Class GraphicsUtilities
        ''' <summary>
        ''' Returns a rounded rectangle.
        ''' </summary>
        ''' <param name="Bounds">The Actual Rectangle to apply rounded path on it.</param>
        ''' <param name="Curve">The Curve degreee</param>
        ''' <param name="TopLeft">Represents if the round occurs only on the TopLeft Corner.</param>
        ''' <param name="TopRight">Represents if the round occurs only on the TopRight Corner.</param>
        ''' <param name="BottomLeft">Represents if the round occurs only on the BottomLeft Corner.</param>
        ''' <param name="BottomRight">Represents if the round occurs only on the BottomRight Corner.</param>
        ''' <returns></returns>
        Public Shared Function RoundedRectangle(Bounds As Rectangle, Curve As Integer, Optional TopLeft As Boolean = True, Optional TopRight As Boolean = True, Optional BottomLeft As Boolean = True, Optional BottomRight As Boolean = True) As GraphicsPath
            Dim CreateRoundPath As New GraphicsPath(FillMode.Winding)
            If TopLeft Then
                CreateRoundPath.AddArc(Bounds.X, Bounds.Y, Curve, Curve, 180.0F, 90.0F)
            Else
                CreateRoundPath.AddLine(Bounds.X, Bounds.Y, Bounds.X, Bounds.Y)
            End If
            If TopRight Then
                CreateRoundPath.AddArc(Bounds.Right - Curve, Bounds.Y, Curve, Curve, 270.0F, 90.0F)
            Else
                CreateRoundPath.AddLine(Bounds.Right - Bounds.Width, Bounds.Y, Bounds.Width, Bounds.Y)
            End If
            If BottomRight Then
                CreateRoundPath.AddArc(Bounds.Right - Curve, Bounds.Bottom - Curve, Curve, Curve, 0.0F, 90.0F)
            Else
                CreateRoundPath.AddLine(Bounds.Right, Bounds.Bottom, Bounds.Right, Bounds.Bottom)

            End If
            If BottomLeft Then
                CreateRoundPath.AddArc(Bounds.X, Bounds.Bottom - Curve, Curve, Curve, 90.0F, 90.0F)
            Else
                CreateRoundPath.AddLine(Bounds.X, Bounds.Bottom, Bounds.X, Bounds.Bottom)
            End If
            CreateRoundPath.CloseFigure()
            Return CreateRoundPath
        End Function
        ''' <summary>
        ''' Draws an image with a given location into the graphics object.
        ''' </summary>
        ''' <param name="Graphics">Represents the Graphics Object.</param>
        ''' <param name="Base64Image">Represents the base 64 encoded image.</param>
        ''' <param name="Rect">Represents the Point and Size that are stored in the Rectangle.</param>
        Public Shared Sub DrawImageFromBase64(Graphics As Graphics, Base64Image As String, Rect As Rectangle)
            Dim Img As Image = Nothing
            Try
                Using ms = New IO.MemoryStream(Convert.FromBase64String(Base64Image))
                    Img = Image.FromStream(ms)
                    ms.Close()
                End Using
                Graphics.DrawImage(Img, Rect)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ''' <summary>
        ''' Represents a positioner adujustment for horiztonal and vertical.
        ''' </summary>
        ''' <param name="Horizontal">Represents the horizontal alignment.</param>
        ''' <param name="Vertical">Represents the Vertical alignment.</param>
        ''' <returns></returns>
        Public Shared Function SetPosition(Optional Horizontal As StringAlignment = StringAlignment.Center, Optional Vertical As StringAlignment = StringAlignment.Center) As StringFormat
            Return New StringFormat With
            {
                .Alignment = Horizontal,
                .LineAlignment = Vertical
            }
        End Function
        ''' <summary>
        ''' Converts a base64 encoded image to an actual image object.
        ''' </summary>
        ''' <param name="Base64Image">Represents the base 64 encoded image.</param>
        ''' <returns>Returns Image Object.</returns>
        Public Shared Function ImageFromBase64(Base64Image As String) As Image
            Try
                Using ms = New IO.MemoryStream(Convert.FromBase64String(Base64Image))
                    Return Image.FromStream(ms)
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
    End Class
End Namespace