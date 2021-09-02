using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurenceCalculator
{
    class WordOccurrence
    {
        public string Word { get; set; }
        public int Count { get; set; }

        public WordOccurrence(string word, int count)
        {
            Word = word;
            Count = count;
        }

        public WordOccurrence(string word)
        {
            Word = word;
            Count = 1;
        }
        
        override public string ToString()
        {
            return (Word + ": " + Count);
        }
    }
}