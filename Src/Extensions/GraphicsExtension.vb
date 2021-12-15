Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports iRISTheme.Src.Helpers
Imports iRISTheme.Src.Utilities

Namespace Src.Extensions
    Module GraphicsExtension
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="Graphics"></param>
        ''' <param name="Pen"></param>
        ''' <param name="Bounds"></param>
        ''' <param name="CornerRadius"></param>
        <Extension()>
        Sub DrawRoundedRectangle(Graphics As Graphics, Pen As Pen, Bounds As Rectangle, CornerRadius As Integer)
            If Graphics Is Nothing Then
                Throw New ArgumentNullException("Graphics object is null")
            End If
            If Pen Is Nothing Then
                Throw New ArgumentNullException("Pen object is null")
            End If
            Using Path As GraphicsPath = GraphicsUtilities.RoundedRectangle(Bounds, CornerRadius)
                Graphics.DrawPath(Pen, Path)
            End Using
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="Graphics"></param>
        ''' <param name="Brush"></param>
        ''' <param name="Bounds"></param>
        ''' <param name="CornerRadius"></param>
        <Extension()>
        Sub FillRoundedRectangle(Graphics As Graphics, Brush As Brush, Bounds As Rectangle, CornerRadius As Integer)
            If Graphics Is Nothing Then
                Throw New ArgumentNullException("Graphics object is null")
            End If
            If Brush Is Nothing Then
                Throw New ArgumentNullException("Brush object is null")
            End If
            Using Path As GraphicsPath = GraphicsUtilities.RoundedRectangle(Bounds, CornerRadius)
                Graphics.FillPath(Brush, Path)
            End Using
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="Graphics"></param>
        ''' <param name="Bounds"></param>
        ''' <param name="CornerRadius"></param>
        ''' <returns></returns>
        <Extension()>
        Function GetRoundedGraphicsPath(Graphics As Graphics, Bounds As Rectangle, CornerRadius As Integer) As GraphicsPath
            If Graphics Is Nothing Then
                Throw New ArgumentNullException("Graphics object is null")
            End If
            Return GraphicsUtilities.RoundedRectangle(Bounds, CornerRadius)
        End Function
        ''' <summary>
        ''' Draws the image before the text.
        ''' </summary>
        ''' <param name="G">Represents the Graphics Object.</param>
        ''' <param name="Img">Represents the Image to be drawn.</param>
        ''' <param name="Text">Represents the Text to be drawn.</param>
        ''' <param name="ThemeFont">Represents the font of the Text.</param>
        ''' <param name="TextBrush">Represents the Text brush color.</param>
        ''' <param name="TextAlign">Represents how the text is aligned using the ContentAlignment.</param>
        ''' <param name="ControlSize">Represents the control area size.</param>
        <Extension()>
        Sub DrawImageAndText(G As Graphics, Img As Image, Text As String, ThemeFont As Font, TextBrush As SolidBrush, TextAlign As ContentAlignment, ControlSize As Size)
            Dim TextAlignment As StringFormat = GraphicsHelper.GetTextPosition(TextAlign)
            Dim TextLocation As Point = GraphicsHelper.GetTextAlignmentPoint(TextAlign, ControlSize)
            Dim ImageLocation As Point = GraphicsHelper.GetImageAlignmentPoint(TextAlign, ControlSize, Img.Size)
            Dim FontSize As Size = TextRenderer.MeasureText(Text, ThemeFont)
            Select Case TextAlign
                Case ContentAlignment.TopLeft
                    G.DrawImage(Img, New Point(ImageLocation.X, ImageLocation.Y))
                    G.DrawString(Text, ThemeFont, TextBrush, New Point(TextLocation.X + Img.Width, TextLocation.Y))
                Case ContentAlignment.TopCenter
                    G.DrawImage(Img, New Point(ImageLocation.X - (FontSize.Width / 2), ImageLocation.Y))
                    G.DrawString(Text, ThemeFont, TextBrush, New Point(TextLocation.X - (FontSize.Width / 2) + (Img.Width / 2), TextLocation.Y))
                Case ContentAlignment.TopRight
                    G.DrawImage(Img, New Point(ImageLocation.X - FontSize.Width, ImageLocation.Y))
                    G.DrawString(Text, ThemeFont, TextBrush, New Point(TextLocation.X - FontSize.Width, TextLocation.Y))
                Case ContentAlignment.MiddleLeft
                    G.DrawImage(Img, New Point(ImageLocation.X, ImageLocation.Y))
                    G.DrawString(Text, ThemeFont, TextBrush, New Point(TextLocation.X + Img.Width, TextLocation.Y - (FontSize.Height / 2)))
                Case ContentAlignment.MiddleCenter
                    G.DrawImage(Img, New Point(ImageLocation.X - (FontSize.Width / 2), ImageLocation.Y))
                    G.DrawString(Text, ThemeFont, TextBrush, New Point(TextLocation.X - (FontSize.Width / 2) + (Img.Width / 2), TextLocation.Y - (FontSize.Height / 2)))
                Case ContentAlignment.MiddleRight
                    G.DrawImage(Img, New Point(ImageLocation.X - FontSize.Width, ImageLocation.Y))
                    G.DrawString(Text, ThemeFont, TextBrush, New Point(TextLocation.X - FontSize.Width, TextLocation.Y - (FontSize.Height / 2)))
                Case ContentAlignment.BottomLeft
                    G.DrawImage(Img, New Point(ImageLocation.X, ImageLocation.Y))
                    G.DrawString(Text, ThemeFont, TextBrush, New Point(TextLocation.X + Img.Width, TextLocation.Y - FontSize.Height))
                Case ContentAlignment.BottomCenter
                    G.DrawImage(Img, New Point(ImageLocation.X - (FontSize.Width / 2), ImageLocation.Y))
                    G.DrawString(Text, ThemeFont, TextBrush, New Point(TextLocation.X - (FontSize.Width / 2) + (Img.Width / 2), TextLocation.Y - FontSize.Height))
                Case ContentAlignment.BottomRight
                    G.DrawImage(Img, New Point(ImageLocation.X - FontSize.Width, ImageLocation.Y))
                    G.DrawString(Text, ThemeFont, TextBrush, New Point(TextLocation.X - FontSize.Width, TextLocation.Y - FontSize.Height))
            End Select
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="G"></param>
        ''' <param name="Img"></param>
        ''' <param name="ImageAlign"></param>
        <Extension()>
        Sub DrawImage(G As Graphics, Img As Image, ImageAlign As ContentAlignment, ImageOffset As Point, ControlSize As Size)
            Dim ImageLocation As Point = GraphicsHelper.GetImageAlignmentPoint(ImageAlign, ControlSize, Img.Size)
            Select Case ImageAlign
                Case ContentAlignment.TopLeft
                    G.DrawImage(Img, New Point(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y))
                Case ContentAlignment.TopCenter
                    G.DrawImage(Img, New Point(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y))
                Case ContentAlignment.TopRight
                    G.DrawImage(Img, New Point(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y))
                Case ContentAlignment.MiddleLeft
                    G.DrawImage(Img, New Point(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y))
                Case ContentAlignment.MiddleCenter
                    G.DrawImage(Img, New Point(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y))
                Case ContentAlignment.MiddleRight
                    G.DrawImage(Img, New Point(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y))
                Case ContentAlignment.BottomLeft
                    G.DrawImage(Img, New Point(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y))
                Case ContentAlignment.BottomCenter
                    G.DrawImage(Img, New Point(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y))
                Case ContentAlignment.BottomRight
                    G.DrawImage(Img, New Point(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y))
            End Select
        End Sub
        ''' <summary>
        ''' Sets the Graphics object to the highest quality.
        ''' </summary>
        ''' <param name="Graphics">Represents the Graphics Object.</param>
        <Extension()>
        Function ToHighQuality(Graphics As Graphics)
            Graphics.SmoothingMode = SmoothingMode.HighQuality
            Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            Return Graphics
        End Function
        ''' <summary>
        ''' Sets the Graphics object to the lowest quality.
        ''' </summary>
        ''' <param name="Graphics">Represents the Graphics Object.</param>
        <Extension()>
        Function ToLowQuality(Graphics As Graphics)
            Graphics.SmoothingMode = SmoothingMode.HighSpeed
            Graphics.TextRenderingHint = TextRenderingHint.SystemDefault
            Return Graphics
        End Function
    End Module
End Namespace