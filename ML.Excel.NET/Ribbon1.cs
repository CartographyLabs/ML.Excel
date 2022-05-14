using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.Excel.NET
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnNaiveBayes_Click(object sender, RibbonControlEventArgs e)
        {
            NaiveBayesGUI.Instance = new NaiveBayesGUI();
            NaiveBayesGUI.Instance.Show();
        }
    }
}
