using MeaningManager.Models.Facades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeaningDetector.Designer
{
    public class GraphicDisplay
    {
        public void DisplayMeaningAnalysis(string path)
        {
            var meaningManager = new MeaningDetector.Business.MeaningManager();
            List<WordIterations> wordIterations = meaningManager.GetTextMeaningAnalysis(path);

            Console.WriteLine("### MEANING ANALYSIS ###");
            Console.WriteLine();

            var wordCount = wordIterations.Count;
            var wordCountStepPer10 = Math.Round((double)(wordCount / 10));
            var decal = " ";
            var test = new List<WordIterations>();
            for(var i = 0; i < 10 * wordCountStepPer10; i+=10)
            {
                test.Add(wordIterations.ElementAt(i));
            }


            Console.WriteLine($"{wordIterations.ElementAt(i).Iterations} |{decal} +");
            decal += " ";

            Console.ReadKey();
        }
    }
}
