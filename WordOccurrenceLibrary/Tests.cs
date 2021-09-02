using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurrenceLibrary
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalculateOccurrencesTest()
        {
            List<string> input = new List<string>();
            string expected = "This: 1Isn't: 1Very: 1Hard: 1";
            string actual = "";
            input.Add("this");
            input.Add("ISn'T");
            input.Add("VeRy");
            input.Add("hARD");
            for (int i = 0; i < input.Count; i++)
            {
                actual += input[i];
            }
            Assert.IsTrue(expected.Equals(actual));
        }
    }
}
