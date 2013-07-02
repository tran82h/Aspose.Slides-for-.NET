'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports System.Drawing

Namespace ControllingDegreeOfGradient
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate a Presentation object that represents a PPT file
			Dim pres As New Presentation(dataDir & "demo.ppt")


			'Accessing a slide using its slide position
			Dim slide As Slide = pres.GetSlideByPosition(2)


			'Adding an ellipse shape into the slide by defining its X,Y postion, width
			'and height
			Dim shape As Shape = slide.Shapes.AddEllipse(2300, 1200, 1000, 2000)


			'Setting the fill type of the ellipse to gradient
			shape.FillFormat.Type = FillType.Gradient


			'Setting the color type of the gradient to two colors
			shape.FillFormat.GradientColorType = GradientColorType.OneColor


			'Setting the foreground color of the ellipse to blue
			shape.FillFormat.ForeColor = Color.Blue


			'Setting the degree of the gradient
			shape.FillFormat.GradientDegree = 18


			'Writing the presentation as a PPT file
			pres.Write(dataDir & "modified.ppt")

		End Sub
	End Class
End Namespace