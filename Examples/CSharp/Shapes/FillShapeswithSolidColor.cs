﻿using System.Drawing;
using Aspose.Slides.Export;
using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Slides.Examples.CSharp.Shapes
{
    class FillShapeswithSolidColor
    {
        public static void Run()
        {
            // The path to the documents directory.                    
            string dataDir = RunExamples.GetDataDir_Shapes();

            // Create an instance of Presentation class
            Presentation presentation = new Presentation();

            //Get the first slide
            ISlide slide = presentation.Slides[0];

            //Add autoshape of rectangle type
            IShape shape = slide.Shapes.AddAutoShape(ShapeType.Rectangle, 50, 150, 75, 150);

            //Set the fill type to Solid
            shape.FillFormat.FillType = FillType.Solid;

            //Set the color of the rectangle
            shape.FillFormat.SolidFillColor.Color = Color.Yellow;

            //Write the PPTX file to disk
            presentation.Save(dataDir + "RectShpSolid.pptx", SaveFormat.Pptx);
        }
    }
}

