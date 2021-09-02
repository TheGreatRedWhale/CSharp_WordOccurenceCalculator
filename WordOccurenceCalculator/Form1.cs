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
            string outputString = "";
            for (int i = 0; i < wordsList.Count; i++)
            {
                outputString += (wordsList[i] + "\n");
            }
            MessageBox.Show(outputString);
        }
    }
}
