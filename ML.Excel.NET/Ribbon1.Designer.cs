
namespace ML.Excel.NET
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tabML = this.Factory.CreateRibbonTab();
            this.classification = this.Factory.CreateRibbonGroup();
            this.btnNaiveBayes = this.Factory.CreateRibbonButton();
            this.btnkNN = this.Factory.CreateRibbonButton();
            this.tabML.SuspendLayout();
            this.classification.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabML
            // 
            this.tabML.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabML.Groups.Add(this.classification);
            this.tabML.Label = "Excel.ML";
            this.tabML.Name = "tabML";
            // 
            // classification
            // 
            this.classification.Items.Add(this.btnNaiveBayes);
            this.classification.Items.Add(this.btnkNN);
            this.classification.Label = "Supervised Classification";
            this.classification.Name = "classification";
            // 
            // btnNaiveBayes
            // 
            this.btnNaiveBayes.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnNaiveBayes.Image = ((System.Drawing.Image)(resources.GetObject("btnNaiveBayes.Image")));
            this.btnNaiveBayes.Label = "Naive Bayes";
            this.btnNaiveBayes.Name = "btnNaiveBayes";
            this.btnNaiveBayes.ShowImage = true;
            this.btnNaiveBayes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnNaiveBayes_Click);
            // 
            // btnkNN
            // 
            this.btnkNN.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnkNN.Label = "kNN Clustering";
            this.btnkNN.Name = "btnkNN";
            this.btnkNN.ShowImage = true;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabML);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tabML.ResumeLayout(false);
            this.tabML.PerformLayout();
            this.classification.ResumeLayout(false);
            this.classification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabML;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup classification;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnNaiveBayes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnkNN;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
