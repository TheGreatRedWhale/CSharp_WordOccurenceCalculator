using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordOccurenceCalculator
{
    public partial class Form1 : Form
    {
        List<string> wordsList = new List<string>();
        List<WordOccurrence> woList = new List<WordOccurrence>();
        Dictionary<string, int> woDict = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            wordsList = Regex.Split(inputTextBox.Text, "[^a-zA-Z']+").ToList<string>();
            string outputString = "";
            for (int i = 0; i < wordsList.Count; i++)
            {
                wordsList[i] = wordsList[i].ToLower();
                wordsList[i] = char.ToUpper(wordsList[i][0]) + wordsList[i].Substring(1);
                try
                {
                    woDict.Add(wordsList[i], 1);
                    woList.Add(new WordOccurrence(wordsList[i]));
                }
                catch (ArgumentException)
                {
                    woDict[wordsList[i]] += 1;
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
            for (int i = 0; i < woList.Count; i++)
            {
                outputString += ("DICT: " + woDict.Keys.ElementAt(i) + "\t" + woDict.Values.ElementAt(i).ToString() + "\n");
                outputString += ("WOCC: " + woList[i].Word + "\t" + woList[i].Count.ToString() + "\n\n");
            }
                MessageBox.Show(outputString);
        }
    }
}
