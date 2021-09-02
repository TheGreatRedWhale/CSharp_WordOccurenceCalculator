using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurenceCalculator
{

    class WordCalculator
    {
        /**
         * <summary>
         * 
         * </summary>
         */
        public static List<WordOccurrence> CalculateOccurrences(List<string> wordsList)
        {
            // If the input list is uninitialized or empty, throw an exception.
            if (wordsList == null || !wordsList.Any())
            {
                throw new ArgumentException("Invalid input.");
            }

            List<WordOccurrence> woList = new List<WordOccurrence>();
            Dictionary<string, byte> woDict = new Dictionary<string, byte>();

            for (int i = 0; i < wordsList.Count; i++)
            {
                // Convert all strings to lowercase and then capitalize the first letter to avoid erroneous duplicates based on casing.
                wordsList[i] = wordsList[i].ToLower();
                wordsList[i] = char.ToUpper(wordsList[i][0]) + wordsList[i].Substring(1);
                try
                {
                    woDict.Add(wordsList[i], 0);
                    woList.Add(new WordOccurrence(wordsList[i]));
                }
                catch (ArgumentException)
                {
                    for (int j = 0; j < woList.Count; j++)
                    {
                        if (woList[j].Word.Equals(wordsList[i]))
                        {
                            woList[j].Count += 1;
                            break;
                        }
                    }
                }
            }

            return woList;
        }
    }
}
