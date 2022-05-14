using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML.Excel.NET
{
    public partial class NaiveBayesGUI : Form
    {
        string[] lines;
        string[] colnames;
        string[][] strValues;
        static string[][] stringVals;
        string fileName;
        static NaiveBayesModel NBM = new NaiveBayesModel();

        private static NaiveBayesGUI instance = null;

        public static NaiveBayesGUI Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public NaiveBayesGUI()
        {
            InitializeComponent();
        }

        public string[][] GetNBData()
        {
            return (stringVals);
        }

        public void LoadData()
        {
            OpenFileDialog mydialog = new OpenFileDialog();
            mydialog.InitialDirectory = @"c:\";
            mydialog.Filter = "csv Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files(*.*)|*.*";

            // Open a file dialog for users to select a csv file
            if (mydialog.ShowDialog() == DialogResult.OK)
            {
                fileName = mydialog.FileName;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string csvLine;
                    List<string> lineItems = new List<string>();
                    // Read and display lines from the file until the end of
                    // the file is reached (reduce time complexity)
                    while ((csvLine = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(csvLine)) { lineItems.Add(csvLine); }
                    }
                    lines = lineItems.ToArray();
                }
            }

            // The first row makes up column names
            colnames = lines[0].Split(',');
            int w = colnames.Length;

            // Create dgvData columns
            foreach (string x in colnames) { dgvData.Columns.Add(x, x); }

            int h = lines.Length;

            // Split strValues and add lines read above from file to strValues array based on comma delimiter
            strValues = new string[h - 1][];
            for (int i = 1; i < h; i++)
            { strValues[i - 1] = lines[i].Split(','); }

            // Add imported data to dgvData control and strvalues to stringVals
            stringVals = new string[h - 1][];
            dgvData.ColumnCount = w;
            for (int i = 0; i < h - 1; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvData);
                stringVals[i] = new string[w];
                for (int j = 0; j < strValues[i].Length; j++)
                {
                    r.Cells[j].Value = strValues[i][j];
                    stringVals[i][j] = strValues[i][j];
                }
                dgvData.Rows.Add(r);
            }
        }

        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\ahart\Desktop\Excel.ML\Excel.ML\naiveBayes\naiveBayesScriptInput.csv"))
                {
                    // Write colnames to first line as headers
                    sw.WriteLine(String.Join(",", colnames));
                    foreach (string[] i in stringVals)
                    {
                        // Write each line in stringVals to 
                        sw.WriteLine(String.Join(",", i));
                    }
                }
                using (StreamWriter sw = new StreamWriter(@"C:\Users\ahart\Desktop\Excel.ML\Excel.ML\naiveBayes\nbConfig.csv"))
                {
                    // Create headers for configuration file
                    string[] configHeaders = new string[5] { "class", "laplace", "percenttesting", "percenttraining", "seed" };

                    // Format configuration settings
                    string classColName = lblClColName.Text;
                    string laplace = tBlaplace.Text;
                    string testDataPct;
                    if (tBpcttestingdata.Text != "")
                    { testDataPct = (Decimal.Parse(tBpcttestingdata.Text) / 100).ToString(); } 
                    else { testDataPct = "0"; }
                    string trainDataPct;
                    if (lblpcttrainingdata.Text != "--%")
                    { trainDataPct = (Decimal.Parse(lblpcttrainingdata.Text.Remove(lblpcttrainingdata.Text.IndexOf("%"))) / 100).ToString(); }
                    else { trainDataPct = "0"; }
                    string seed;
                    if (tBseed.Text != "")
                    { seed = tBseed.Text; }
                    else { seed = "1"; }
                    

                    // Create configuration data
                    string[] configSettings = new string[5] { classColName, laplace, testDataPct, trainDataPct, seed };
                    
                    // Write headers as first line and settings as second
                    sw.WriteLine(String.Join(",", configHeaders));
                    sw.WriteLine(String.Join(",", configSettings));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // Update stringVals when user changes a cell - ensure the proper and intended vals get to the model
        private void dgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;

            // Update strValues from data grid
            stringVals[r][c] = dgvData.Rows[r].Cells[c].Value.ToString();

            // Update originally read data lines
            lines[r + 1] = stringVals[r][0].ToString();
            for (int i = 1; i < stringVals[r].Length; i++)
                lines[r + 1] += "," + stringVals[r][i];

            // Write updated csv file
            SaveData();
        }

        // This is the 'Open Data' button - it loads the data from a csv or text file, updates the model info,
        // and saves stringVals to a csv in the Excel.ML file for future reference by R scripts
        private void button1_Click(object sender, EventArgs e)
        {
            // Load in New Data
            LoadData();

            label44.Text = stringVals.GetLength(0).ToString();
            label48.Text = stringVals[1].GetLength(0).ToString();
            if (tBpcttestingdata.Text != "")
            {
                label49.Text = Decimal.ToInt32(stringVals.GetLength(0) * (Decimal.Parse(tBpcttestingdata.Text) / 100)).ToString();
                label50.Text = (stringVals.GetLength(0) - (Decimal.ToInt32(stringVals.GetLength(0) * (Decimal.Parse(tBpcttestingdata.Text) / 100)))).ToString();
            }
            if(textBox4.Text != "")
            {
                lblClColName.Text = colnames[int.Parse(textBox4.Text)-1].ToString();
            }

            SaveData();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                int.Parse(tBpcttestingdata.Text) <= 100)
            {
                e.Handled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (tBpcttestingdata.Text != "" && Decimal.Parse(tBpcttestingdata.Text) <= 100)
            {
                decimal i = Decimal.Parse(tBpcttestingdata.Text);
                i = 100 - i;
                lblpcttrainingdata.Text = i.ToString() + "%";
            }
            else if (tBpcttestingdata.Text != "" && Decimal.Parse(tBpcttestingdata.Text) > 100)
            {
                lblpcttrainingdata.Text = "ERROR - Enter Number < 100";
            }
            else
            {
                lblpcttrainingdata.Text = "--%";
            }
        }

        // This is the 'Train Model' Button
        private void button2_Click(object sender, EventArgs e)
        {
            string[] modelEval;

            NBM.RunRTrain();
            modelEval = NBM.GetModelOutput();

            lVcm.Items[0].SubItems[1].Text = modelEval[1];
            lVcm.Items[1].SubItems[1].Text = modelEval[3];
            lVcm.Items[0].SubItems[2].Text = modelEval[4];
            lVcm.Items[1].SubItems[2].Text = modelEval[2];
            lblAcc.Text = modelEval[5];
            lblCI.Text = modelEval[6];
            lblNIR.Text = modelEval[7];
            lblPVal.Text = modelEval[8];
            lblKappa.Text = modelEval[9];
            lblMPVal.Text = modelEval[10];
            lblSens.Text = modelEval[11];
            lblSpec.Text = modelEval[12];
            lblPrec.Text = modelEval[13];
            lblRecall.Text = modelEval[14];
            lblF1.Text = modelEval[15];
            lblPPV.Text = modelEval[16];
            lblNPV.Text = modelEval[17];
            lblPrev.Text = modelEval[18];
            lblDR.Text = modelEval[19];
            lblDP.Text = modelEval[20];
            lblBAcc.Text = modelEval[21];
        }
    }
}
