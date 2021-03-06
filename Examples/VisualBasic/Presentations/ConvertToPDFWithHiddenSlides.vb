﻿Imports System
Imports System.Drawing
Imports Aspose.Slides.Export
Imports Aspose.Slides

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Slides.Examples.VisualBasic.Presentations
    Class ConvertToPDFWithHiddenSlides
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Presentations()

            Using presentation As New Presentation(dataDir & Convert.ToString("HiddingSlides.pptx"))

                ' Instantiate the PdfOptions class
                Dim pdfOptions As New PdfOptions()

                ' Specify that the generated document should include hidden slides
                pdfOptions.ShowHiddenSlides = True

                ' Save the presentation to PDF with specified options
                presentation.Save(dataDir & Convert.ToString("PDFWithHiddenSlides_out.pdf"), SaveFormat.Pdf, pdfOptions)
            End Using
        End Sub
    End Class
End Namespace
