using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MeaningDetector.Business.Tests
{
    [TestClass]
    public class MeaningManagerTests
    {
        [TestMethod]
        public void GetTextMeaningAnalysis_MeaningText()
        {
            var meaningManager = new MeaningManager();

            var wordIterations = meaningManager.GetTextMeaningAnalysis(@".\Files\WithMeaning.txt");

            Assert.AreEqual("", wordIterations.ElementAt(0).Word);
            Assert.AreEqual(5, wordIterations.ElementAt(0).Iterations);
        }
    }
}
