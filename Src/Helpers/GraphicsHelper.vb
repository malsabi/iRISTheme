Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports iRISTheme.Src.Utilities

Namespace Src.Helpers
    ''' <summary>
    ''' GraphicsHelper provides extra methods for supporting graphics.
    ''' </summary>
    Public Class GraphicsHelper
        ''' <summary>
        ''' Returns a StringFormat object that contains horizontal and vertical alignments depending on the provided text alignment.
        ''' </summary>
        ''' <param name="TextAlignment">Represents the text alignment.</param>
        ''' <returns>Returns a StringFormat object.</returns>
        Public Shared Function GetTextPosition(TextAlignment As ContentAlignment) As StringFormat
            Select Case TextAlignment
                Case ContentAlignment.TopLeft
                    Return GraphicsUtilities.SetPosition(StringAlignment.Near, StringAlignment.Near)
                Case ContentAlignment.TopCenter
                    Return GraphicsUtilities.SetPosition(StringAlignment.Center, StringAlignment.Near)
                Case ContentAlignment.TopRight
                    Return GraphicsUtilities.SetPosition(StringAlignment.Far, StringAlignment.Near)
                Case ContentAlignment.MiddleLeft
                    Return GraphicsUtilities.SetPosition(StringAlignment.Near, StringAlignment.Center)
                Case ContentAlignment.MiddleCenter
                    Return GraphicsUtilities.SetPosition(StringAlignment.Center, StringAlignment.Center)
                Case ContentAlignment.MiddleRight
                    Return GraphicsUtilities.SetPosition(StringAlignment.Far, StringAlignment.Center)
                Case ContentAlignment.BottomLeft
                    Return GraphicsUtilities.SetPosition(StringAlignment.Near, StringAlignment.Far)
                Case ContentAlignment.BottomCenter
                    Return GraphicsUtilities.SetPosition(StringAlignment.Center, StringAlignment.Far)
                Case ContentAlignment.BottomRight
                    Return GraphicsUtilities.SetPosition(StringAlignment.Far, StringAlignment.Far)
                Case Else
                    Return Nothing
            End Select
        End Function
        ''' <summary>
        ''' Returns the Point(x, y) that stores the text depending on how the text is aligned using ContentAlignment.
        ''' </summary>
        ''' <param name="TextAlignment">Represents how text is aligned.</param>
        ''' <param name="ControlSize">Represents the size of the control area.</param>
        Public Shared Function GetTextAlignmentPoint(TextAlignment As ContentAlignment, ControlSize As Size) As Point
            Select Case TextAlignment
                Case ContentAlignment.TopLeft
                    Return New Point(0, 0)
                Case ContentAlignment.TopCenter
                    Return New Point(ControlSize.Width / 2, 0)
                Case ContentAlignment.TopRight
                    Return New Point(ControlSize.Width, 0)
                Case ContentAlignment.MiddleLeft
                    Return New Point(0, ControlSize.Height / 2)
                Case ContentAlignment.MiddleCenter
                    Return New Point(ControlSize.Width / 2, ControlSize.Height / 2)
                Case ContentAlignment.MiddleRight
                    Return New Point(ControlSize.Width, ControlSize.Height / 2)
                Case ContentAlignment.BottomLeft
                    Return New Point(0, ControlSize.Height)
                Case ContentAlignment.BottomCenter
                    Return New Point(ControlSize.Width / 2, ControlSize.Height)
                Case ContentAlignment.BottomRight
                    Return New Point(ControlSize.Width, ControlSize.Height)
                Case Else
                    Return New Point(-1, -1)
            End Select
        End Function
        ''' <summary>
        ''' Returns the Point(x, y) that stores the image depending on how the image is aligned using ContentAlignment.
        ''' </summary>
        ''' <param name="ImageAlignment">Represents how image is aligned.</param>
        ''' <param name="ControlSize">Represents the size of the control area.</param>
        ''' <param name="ImageSize">Represents the size of the image dimension.</param>
        Public Shared Function GetImageAlignmentPoint(ImageAlignment As ContentAlignment, ControlSize As Size, ImageSize As Size) As Point
            ImageSize.Width /= 2
            ImageSize.Height /= 2
            Select Case ImageAlignment
                Case ContentAlignment.TopLeft
                    Return New Point(0, 2)
                Case ContentAlignment.TopCenter
                    Return New Point((ControlSize.Width / 2) - ImageSize.Width, 2)
                Case ContentAlignment.TopRight
                    Return New Point(ControlSize.Width - (ImageSize.Width * 2), 2)
                Case ContentAlignment.MiddleLeft
                    Return New Point(0, (ControlSize.Height / 2) - ImageSize.Height)
                Case ContentAlignment.MiddleCenter
                    Return New Point((ControlSize.Width / 2) - ImageSize.Width, (ControlSize.Height / 2) - ImageSize.Height)
                Case ContentAlignment.MiddleRight
                    Return New Point(ControlSize.Width - (ImageSize.Width * 2), (ControlSize.Height / 2) - ImageSize.Height)
                Case ContentAlignment.BottomLeft
                    Return New Point(0, ControlSize.Height - (ImageSize.Height * 2) - 2)
                Case ContentAlignment.BottomCenter
                    Return New Point((ControlSize.Width / 2) - ImageSize.Width, ControlSize.Height - (ImageSize.Height * 2) - 2)
                Case ContentAlignment.BottomRight
                    Return New Point(ControlSize.Width - (ImageSize.Width * 2), ControlSize.Height - (ImageSize.Height * 2) - 2)
                Case Else
                    Return New Point(-1, -1)
            End Select
        End Function
    End Class
End Namespace