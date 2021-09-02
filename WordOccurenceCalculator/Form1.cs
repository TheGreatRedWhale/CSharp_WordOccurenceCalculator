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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            List<string> wordsList = new List<string>();
            wordsList = Regex.Split(inputTextBox.Text, "[^a-zA-Z']+").ToList<string>();
            List<WordOccurrence> woList = new List<WordOccurrence>();

            string outputString = "";
            woList = WordCalculator.CalculateOccurrences(wordsList);
            for (int i = 0; i < woList.Count; i++)
            {
                outputString += ("WOCC: " + woList[i].Word + "\t" + woList[i].Count.ToString() + "\n\n");
            }
                MessageBox.Show(outputString);
        }
    }
}
