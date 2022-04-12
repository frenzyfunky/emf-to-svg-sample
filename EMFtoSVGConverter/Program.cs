using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using System;

namespace EMFtoSVGConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var emfPath = "example.emf";
            var destPath = "svg_out.svg";

            using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Load(emfPath))
            {
                // Initilaize EmfRasterizationOptions class object
                EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();

                emfRasterizationOptions.BackgroundColor = Color.Transparent;
                emfRasterizationOptions.PageWidth = image.Width;
                emfRasterizationOptions.PageHeight = image.Height;

                image.Save(destPath, new SvgOptions() { VectorRasterizationOptions = emfRasterizationOptions });
            }
        }
    }
}
