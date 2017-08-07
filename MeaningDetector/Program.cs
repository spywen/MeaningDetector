using MeaningDetector.Designer;

namespace MeaningDetector
{
    public class Program
    {
        static void Main(string[] args)
        {
            var graphicDisplay = new GraphicDisplay();
            graphicDisplay.DisplayMeaningAnalysis(@".\Files\WithMeaning.txt");

            graphicDisplay.DisplayMeaningAnalysis(@".\Files\WithoutMeaning.txt");
        }
    }
}
