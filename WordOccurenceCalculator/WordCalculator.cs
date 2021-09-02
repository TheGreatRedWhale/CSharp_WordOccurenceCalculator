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
        static List<WordOccurrence> CalculateOccurrences(List<string> occurences)
        {
            // If the input list is uninitialized or empty, throw an exception.
            if (occurences == null || occurences.Any())
            {
                throw new ArgumentException("Invalid input.");
            }

            return null; //TODO
        }
    }
}
