using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordOccurenceCalculator;

namespace WordOccurrenceLibrary
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalculateOccurrencesTest()
        {
            // Create variables to store data for comparison and transformation.
            List<WordOccurrence> wordOccurrences = new List<WordOccurrence>();
            List<string> input = new List<string>();
            // Show expected output string
            string expected = "This: 1Isn't: 1Very: 1Hard: 1";
            // Initialize output string to ""
            string actual = "";
            // Add string to string list
            input.Add("this");
            input.Add("ISn'T");
            input.Add("VeRy");
            input.Add("hARD");

            // Convert string list to wordOccurrence list
            wordOccurrences = WordCalculator.CalculateOccurrences(input);
            // Generate actual output string
            for (int i = 0; i < wordOccurrences.Count; i++)
            {
                actual += wordOccurrences[i];
            }
            // Compare with the expected result
            Assert.IsTrue(expected.Equals(actual));
        }

        [Test]
        public void CalculateOccurrencesShouldThrowException()
        {
            // Tests to ensure that ArgumentException is thrown when calculator is provided with a null argument.
            Assert.Throws<ArgumentException>(
                delegate { WordCalculator.CalculateOccurrences(null); });
        }
    }
}
