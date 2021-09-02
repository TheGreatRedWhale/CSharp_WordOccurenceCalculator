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

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            List<string> wordsList = new List<string>();
            wordsList = Regex.Split(inputTextBox.Text, "[^a-zA-Z']+").ToList<string>();
            if (wordsList[wordsList.Count-1].Equals(""))
            {
                wordsList.RemoveAt(wordsList.Count - 1);
            }
            List<WordOccurrence> woList = new List<WordOccurrence>();
            try
            {

                string outputString = "";
                woList = WordCalculator.CalculateOccurrences(wordsList);
                for (int i = 0; i < woList.Count; i++)
                {
                    outputString += (woList[i] + "\n");
                }
                outputString = outputString.Substring(0, outputString.Length - 1);
                resultLabel.Text = outputString;
            }
            catch (ArgumentException)
            {
                resultLabel.Text = "There are no words\nin the textbox!";
            }
        }
    }
}
