Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports iRISTheme.Src.Helpers
Imports iRISTheme.Src.Utilities

Namespace Src.Extensions
    Module GraphicsExtension
        ''' <summary>
        ''' Draws a rounded border around the rectangle with a given corner radius.
        ''' </summary>
        ''' <param name="Graphics">Represents the graphics object.</param>
        ''' <param name="Pen">Represents the brush to fil the surface.</param>
        ''' <param name="Bounds">Represents the bounds of the rectangle (x, y, width, height).</param>
        ''' <param name="CornerRadius">Represents the curve radius.</param>
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
        ''' Fills the rectangle with a specific color and curves the rectangle with a given corner radius.
        ''' </summary>
        ''' <param name="Graphics">Represents the graphics object.</param>
        ''' <param name="Brush">Represents the brush to fill the surface.</param>
        ''' <param name="Bounds">Represents the bounds of the rectangle (x, y, width, height).</param>
        ''' <param name="CornerRadius">Represents the curve radius.</param>
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
        ''' Returns a graphics path contains a rounded corners for the rectangle.
        ''' </summary>
        ''' <param name="Graphics">Represents the graphics object.</param>
        ''' <param name="Bounds">Represents the bounds of the rectangle (x, y, width, height).</param>
        ''' <param name="CornerRadius">Represents the curve radius.</param>
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
        ''' Draws an image with a given image alignment and image offset.
        ''' </summary>
        ''' <param name="G">Represents the graphics object.</param>
        ''' <param name="Img">Represents the image to be drawn on the graphics.</param>
        ''' <param name="ImageSize">Represents the image size (widthxheight).</param>
        ''' <param name="ImageAlign">Represents the image alignment.</param>
        ''' <param name="ImageOffset">Represents the image offset.</param>
        ''' <param name="Bounds">Represents the bounds of the rectangle (x, y, width, height).</param>
        <Extension()>
        Sub DrawImage(G As Graphics, Img As Image, ImageSize As Size, ImageAlign As ContentAlignment, ImageOffset As Point, Bounds As Rectangle)
            Dim ImageLocation As Point = GraphicsHelper.GetImageAlignmentPoint(ImageAlign, Bounds.Size, ImageSize)
            Bounds.Offset(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y)
            G.DrawImage(Img, New Rectangle(Bounds.Location, ImageSize))
        End Sub
        ''' <summary>
        ''' Draws an image with a given image alignment and image offset.
        ''' </summary>
        ''' <param name="G">Represents the graphics object.</param>
        ''' <param name="Img">Represents the image to be drawn on the graphics.</param>
        ''' <param name="ImageSize">Represents the image size (widthxheight).</param>
        ''' <param name="ImageAlign">Represents the image alignment.</param>
        ''' <param name="ImageOffset">Represents the image offset (x, y).</param>
        ''' <param name="Bounds">Represents the bounds of the rectangle (x, y, width, height).</param>
        <Extension()>
        Sub DrawImage(G As Graphics, Img As Image, ImageSize As Size, ImageAlign As StringAlignment, ImageOffset As Point, Bounds As Rectangle) 'HERE1
            Dim ImageLocation As Point = GraphicsHelper.GetImageAlignmentPoint(ImageAlign, Bounds.Size, ImageSize)
            Bounds.Offset(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y)
            G.DrawImage(Img, New Rectangle(Bounds.Location, ImageSize))
        End Sub
        ''' <summary>
        ''' Draws an image with a given image alignment, image offset, and background color for the image.
        ''' </summary>
        ''' <param name="G">Represents the graphics object.</param>
        ''' <param name="BackgroundColor">Represents the background color for the image.</param>
        ''' <param name="Img">Represents the image to be drawn on the graphics.</param>
        ''' <param name="ImageSize">Represents the image size (widthxheight).</param>
        ''' <param name="ImageAlign">Represents the image alignment.</param>
        ''' <param name="ImageOffset">Represents the image offset (x, y).</param>
        ''' <param name="Bounds">Represents the bounds of the rectangle (x, y, width, height).</param>
        <Extension()>
        Sub DrawImageWithColor(G As Graphics, BackgroundColor As Color, Img As Image, ImageSize As Size, ImageAlign As ContentAlignment, ImageOffset As Point, Bounds As Rectangle) 'HERE2
            Dim ImageLocation As Point = GraphicsHelper.GetImageAlignmentPoint(ImageAlign, Bounds.Size, ImageSize)
            Bounds.Offset(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y)
            G.DrawImageWithColor(New Rectangle(Bounds.Location, ImageSize), Img, BackgroundColor)
        End Sub
        ''' <summary>
        ''' Draws an image with a given image alignment, image offset, and background color for the image.
        ''' </summary>
        ''' <param name="G">Represents the graphics object.</param>
        ''' <param name="BackgroundColor">Represents the background color for the image.</param>
        ''' <param name="Img">Represents the image to be drawn on the graphics.</param>
        ''' <param name="ImageSize">Represents the image size (widthxheight).</param>
        ''' <param name="ImageAlign">Represents the image alignment.</param>
        ''' <param name="ImageOffset">Represents the image offset (x, y).</param>
        ''' <param name="Bounds">Represents the bounds of the rectangle (x, y, width, height).</param>
        <Extension()>
        Sub DrawImageWithColor(G As Graphics, BackgroundColor As Color, Img As Image, ImageSize As Size, ImageAlign As StringAlignment, ImageOffset As Point, Bounds As Rectangle)
            Dim ImageLocation As Point = GraphicsHelper.GetImageAlignmentPoint(ImageAlign, Bounds.Size, ImageSize)
            Bounds.Offset(ImageLocation.X + ImageOffset.X, ImageLocation.Y + ImageOffset.Y)
            G.DrawImageWithColor(New Rectangle(Bounds.Location, ImageSize), Img, BackgroundColor)
        End Sub
        ''' <summary>
        ''' Draws an image with a background color.
        ''' </summary>
        ''' <param name="G"> The Graphic to draw the image </param>
        ''' <param name="Bounds"> The Rectangle area of image </param>
        ''' <param name="Img"> The image that the custom color applies on it</param>
        ''' <param name="BackgroundColor">The Color that be applied to the image </param>
        <Extension()>
        Sub DrawImageWithColor(G As Graphics, Bounds As Rectangle, Img As Image, BackgroundColor As Color)
            Dim PtsArray As Single()() =
            {
                New Single() {Convert.ToSingle(BackgroundColor.R / 255), 0, 0, 0, 0},
                New Single() {0, Convert.ToSingle(BackgroundColor.G / 255), 0, 0, 0},
                New Single() {0, 0, Convert.ToSingle(BackgroundColor.B / 255), 0, 0},
                New Single() {0, 0, 0, Convert.ToSingle(BackgroundColor.A / 255), 0},
                New Single() {Convert.ToSingle(BackgroundColor.R / 255), Convert.ToSingle(BackgroundColor.G / 255), Convert.ToSingle(BackgroundColor.B / 255), 0.0F, Convert.ToSingle(BackgroundColor.A / 255)}
            }
            Dim ImgAttr As New Imaging.ImageAttributes
            ImgAttr.SetColorMatrix(New Imaging.ColorMatrix(PtsArray), Imaging.ColorMatrixFlag.Default, Imaging.ColorAdjustType.Default)
            G.DrawImage(Img, Bounds, 0, 0, Img.Width, Img.Height, GraphicsUnit.Pixel, ImgAttr)
        End Sub
        ''' <summary>
        ''' Draws a text with a given text alignment and text offset.
        ''' </summary>
        ''' <param name="G">Represents the graphics object.</param>
        ''' <param name="Font">Represents the font of the text..</param>
        ''' <param name="Text">Represents the text to be drawn.</param>
        ''' <param name="TextBrush">Represents the text brush for drawing a text with a specific color.</param>
        ''' <param name="TextAlign">Represetns the text alignment.</param>
        ''' <param name="TextOffset">Represetns the text offset (x, y) on how much to be moved.</param>
        ''' <param name="Bounds">Represents the bounds of the rectangle (x, y, width, height).</param>
        ''' <param name="StringFormat">Represents the text alignment for vertical and horizontal..</param>
        <Extension()>
        Sub DrawText(G As Graphics, Font As Font, Text As String, TextBrush As SolidBrush, TextAlign As StringAlignment, TextOffset As Point, Bounds As Rectangle, StringFormat As StringFormat)
            Bounds.Offset(TextOffset)
            Dim TextSize As SizeF = G.MeasureString(Text, Font)
            Dim TextLocation As Point = GraphicsHelper.GetTextAlignmentPoint(TextAlign, Bounds.Size)
            Select Case TextAlign
                Case StringAlignment.Near
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X, Bounds.Y + TextLocation.Y, StringFormat)
                Case StringAlignment.Center
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X - (TextSize.Width / 2), Bounds.Y + TextLocation.Y, StringFormat)
                Case StringAlignment.Far
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X - TextSize.Width, Bounds.Y + TextLocation.Y, StringFormat)
            End Select
        End Sub
        ''' <summary>
        '''  Draws a text with a given text alignment and text offset.
        ''' </summary>
        ''' <param name="G">Represents the graphics object.</param>
        ''' <param name="Font">Represents the font of the text..</param>
        ''' <param name="Text">Represents the text to be drawn.</param>
        ''' <param name="TextBrush">Represents the text brush for drawing a text with a specific color.</param>
        ''' <param name="TextAlign">Represetns the text alignment.</param>
        ''' <param name="TextOffset">Represetns the text offset (x, y) on how much to be moved.</param>
        ''' <param name="Bounds">Represents the bounds of the rectangle (x, y, width, height).</param>
        ''' <param name="StringFormat">Represents the text alignment for vertical and horizontal..</param>
        <Extension()>
        Sub DrawText(G As Graphics, Font As Font, Text As String, TextBrush As SolidBrush, TextAlign As ContentAlignment, TextOffset As Point, Bounds As Rectangle, StringFormat As StringFormat)
            Bounds.Offset(TextOffset)
            Dim TextSize As SizeF = G.MeasureString(Text, Font)
            Dim TextLocation As Point = GraphicsHelper.GetTextAlignmentPoint(TextAlign, Bounds.Size)
            Select Case TextAlign
                Case ContentAlignment.TopLeft
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X, Bounds.Y + TextLocation.Y, StringFormat)
                Case ContentAlignment.TopCenter
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X - (TextSize.Width / 8), Bounds.Y + TextLocation.Y, StringFormat)
                Case ContentAlignment.TopRight
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X - TextSize.Width, Bounds.Y + TextLocation.Y, StringFormat)
                Case ContentAlignment.MiddleLeft
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X, Bounds.Y + TextLocation.Y - (TextSize.Height / 2), StringFormat)
                Case ContentAlignment.MiddleCenter
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X - (TextSize.Width / 2), Bounds.Y + TextLocation.Y - (TextSize.Height / 2), StringFormat)
                Case ContentAlignment.MiddleRight
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X - TextSize.Width, Bounds.Y + TextLocation.Y - (TextSize.Height / 2), StringFormat)
                Case ContentAlignment.BottomLeft
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X, Bounds.Y + TextLocation.Y - TextSize.Height, StringFormat)
                Case ContentAlignment.BottomCenter
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X - (TextSize.Width / 2), Bounds.Y + TextLocation.Y - TextSize.Height, StringFormat)
                Case ContentAlignment.BottomRight
                    G.DrawString(Text, Font, TextBrush, Bounds.X + TextLocation.X - TextSize.Width, Bounds.Y + TextLocation.Y - TextSize.Height, StringFormat)
            End Select
        End Sub
        ''' <summary>
        ''' Sets the Graphics object to the highest quality.
        ''' </summary>
        ''' <param name="Graphics">Represents the Graphics Object.</param>
        <Extension()>
        Function ToHighQuality(Graphics As Graphics) As Graphics
            Graphics.SmoothingMode = SmoothingMode.HighQuality
            Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            Return Graphics
        End Function
        ''' <summary>
        ''' Sets the Graphics object to the lowest quality.
        ''' </summary>
        ''' <param name="Graphics">Represents the Graphics Object.</param>
        <Extension()>
        Function ToLowQuality(Graphics As Graphics) As Graphics
            Graphics.SmoothingMode = SmoothingMode.HighSpeed
            Graphics.TextRenderingHint = TextRenderingHint.SystemDefault
            Return Graphics
        End Function
    End Module
End Namespace