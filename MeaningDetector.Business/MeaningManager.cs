using MeaningManager.Models.Facades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MeaningDetector.Business
{
    public class MeaningManager
    {
        public List<WordIterations> GetTextMeaningAnalysis(string textPath)
        {
            //Get file content
            if (!File.Exists(textPath))
            {
                throw new Exception("Input file doesn't exist");
            }
            string text = File.ReadAllText(textPath);

            //Call IterationManager
            var dic = new Dictionary<string, int>();
            var splittedText = text.Split(' ');
            foreach(var word in splittedText)
            {
                var formatWord = word.ToLower();
                int count;
                if (dic.TryGetValue(formatWord, out count))
                {
                    dic[formatWord] = count + 1;
                }
                else
                {
                    dic.Add(formatWord, 1);
                }
            }

            //Call Order Manager
            var final = dic.OrderByDescending(x => x.Value).Select(x => new WordIterations { Word = x.Key, Iterations = x.Value }).ToList();

            return final;
        }
    }
}
