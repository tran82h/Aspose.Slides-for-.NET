﻿Imports Aspose.Slides.Export
Imports Aspose.Slides

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace Aspose.Slides.Examples.VisualBasic.Presentations
    Public Class ConvetToSWF
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Presentations()

            'Instantiate a Presentation object that represents a presentation file
            Using presentation As New Presentation(dataDir + "HelloWorld.pptx")
                Dim swfOptions As New SwfOptions()
                swfOptions.ViewerIncluded = False

                ' Saving presentation
                presentation.Save(dataDir + "SaveAsSwf.swf", SaveFormat.Swf, swfOptions)

                swfOptions.ViewerIncluded = True

                ' Saving notes pages
                presentation.Save(dataDir + "SaveNotes.swf", SaveFormat.SwfNotes, swfOptions)
            End Using
        End Sub
    End Class
End Namespace