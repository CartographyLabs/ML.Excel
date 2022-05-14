using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ML.Excel.NET
{
    class NaiveBayesModel // uses the e1071 package in R
    {
        string naiveBayesOutput;

        public void RunRTrain()
        {
            string rpath = @"C:\Program Files\R\R-3.6.0\bin\Rscript.exe";
            string scriptpath = @"C:\Users\ahart\Desktop\Excel.ML\Excel.ML\naiveBayes\NaiveBayes.r";
            RunRScript(rpath, scriptpath);
        }

        public void RunRClassify()
        {
            string rpath = @"C:\Program Files\R\R-3.6.0\bin\Rscript.exe";
            string scriptpath = @"C:\Users\ahart\Desktop\Excel.ML\Excel.ML\naiveBayes\nbClassifyExcelData.r";
            RunRScript(rpath, scriptpath);
        }

        public string[] GetModelOutput()
        {
            try
            {
                using (var reader = new StreamReader(@"C:\Users\ahart\Desktop\Excel.ML\Excel.ML\naiveBayes\modelPerformance.csv"))
                {
                    string[] modelOutArray = new string[0] { };

                    // skip headers
                    reader.ReadLine();

                    // read results
                    var line = reader.ReadLine();
                    modelOutArray = line.Split(',');
                    return modelOutArray;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return new string[0] { };
        }

        public static string RunRScript(string rpath, string scriptpath)
        {
            try
            {
                var info = new ProcessStartInfo
                {
                    FileName = rpath,
                    WorkingDirectory = Path.GetDirectoryName(scriptpath),
                    Arguments = scriptpath,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };

                using (var proc = new Process { StartInfo = info })
                {
                    proc.Start();
                    return proc.StandardOutput.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return string.Empty;
        }

        // Default Constructor Overload for Model Instantiation
        public NaiveBayesModel()
        {
            //
        }
    }
}
