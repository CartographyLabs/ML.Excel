
namespace ML.Excel.NET
{
    partial class NaiveBayesGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pred - Positive",
            "NaN",
            "NaN"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pred - Negative",
            "NaN",
            "NaN"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaiveBayesGUI));
            this.lblFormName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tBinputRange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblpcttrainingdata = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tBpcttestingdata = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBOutputCell = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBlaplace = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lVcm = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.lblF1 = new System.Windows.Forms.Label();
            this.lblBAcc = new System.Windows.Forms.Label();
            this.lblDP = new System.Windows.Forms.Label();
            this.lblDR = new System.Windows.Forms.Label();
            this.lblPrev = new System.Windows.Forms.Label();
            this.lblNPV = new System.Windows.Forms.Label();
            this.lblPPV = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblSens = new System.Windows.Forms.Label();
            this.lblKappa = new System.Windows.Forms.Label();
            this.lblPVal = new System.Windows.Forms.Label();
            this.lblNIR = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClColName = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tBseed = new System.Windows.Forms.TextBox();
            this.lblMPVal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblRecall = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.Location = new System.Drawing.Point(353, 12);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(447, 36);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Naive Bayes Binary Classification";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(55, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBinputRange
            // 
            this.tBinputRange.Location = new System.Drawing.Point(57, 97);
            this.tBinputRange.Name = "tBinputRange";
            this.tBinputRange.Size = new System.Drawing.Size(152, 22);
            this.tBinputRange.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Testing Data (Excel)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.tBinputRange);
            this.groupBox1.Controls.Add(this.tBOutputCell);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(591, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 287);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Class Column Index";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(55, 190);
            this.textBox4.MaxLength = 3;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 22);
            this.textBox4.TabIndex = 17;
            // 
            // lblpcttrainingdata
            // 
            this.lblpcttrainingdata.AutoSize = true;
            this.lblpcttrainingdata.Location = new System.Drawing.Point(52, 145);
            this.lblpcttrainingdata.Name = "lblpcttrainingdata";
            this.lblpcttrainingdata.Size = new System.Drawing.Size(30, 17);
            this.lblpcttrainingdata.TabIndex = 16;
            this.lblpcttrainingdata.Text = "--%";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(52, 122);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(147, 17);
            this.label23.TabIndex = 15;
            this.label23.Text = "Percent Training Data";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(52, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 17);
            this.label22.TabIndex = 14;
            this.label22.Text = "Percent Testing Data";
            // 
            // tBpcttestingdata
            // 
            this.tBpcttestingdata.Location = new System.Drawing.Point(55, 100);
            this.tBpcttestingdata.MaxLength = 3;
            this.tBpcttestingdata.Name = "tBpcttestingdata";
            this.tBpcttestingdata.Size = new System.Drawing.Size(152, 22);
            this.tBpcttestingdata.TabIndex = 13;
            this.tBpcttestingdata.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.tBpcttestingdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label47);
            this.groupBox3.Controls.Add(this.tBseed);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.lblpcttrainingdata);
            this.groupBox3.Controls.Add(this.tBpcttestingdata);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tBlaplace);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(35, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 344);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Model Training Criterion";
            // 
            // tBOutputCell
            // 
            this.tBOutputCell.Location = new System.Drawing.Point(57, 150);
            this.tBOutputCell.Name = "tBOutputCell";
            this.tBOutputCell.Size = new System.Drawing.Size(152, 22);
            this.tBOutputCell.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(80, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Classify";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Laplace Estimator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Start Cell";
            // 
            // tBlaplace
            // 
            this.tBlaplace.Location = new System.Drawing.Point(56, 244);
            this.tBlaplace.Name = "tBlaplace";
            this.tBlaplace.Size = new System.Drawing.Size(152, 22);
            this.tBlaplace.TabIndex = 12;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvData.Location = new System.Drawing.Point(35, 364);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(809, 340);
            this.dgvData.TabIndex = 12;
            this.dgvData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellValueChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(732, 713);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Train Model";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPrec);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.lblRecall);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.lVcm);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.lblF1);
            this.groupBox4.Controls.Add(this.lblBAcc);
            this.groupBox4.Controls.Add(this.lblDP);
            this.groupBox4.Controls.Add(this.lblDR);
            this.groupBox4.Controls.Add(this.lblPrev);
            this.groupBox4.Controls.Add(this.lblNPV);
            this.groupBox4.Controls.Add(this.lblPPV);
            this.groupBox4.Controls.Add(this.lblSpec);
            this.groupBox4.Controls.Add(this.lblSens);
            this.groupBox4.Controls.Add(this.lblMPVal);
            this.groupBox4.Controls.Add(this.lblKappa);
            this.groupBox4.Controls.Add(this.lblPVal);
            this.groupBox4.Controls.Add(this.lblNIR);
            this.groupBox4.Controls.Add(this.lblCI);
            this.groupBox4.Controls.Add(this.lblAcc);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(861, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 729);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Model Evaluation";
            // 
            // lVcm
            // 
            this.lVcm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lVcm.HideSelection = false;
            this.lVcm.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lVcm.Location = new System.Drawing.Point(18, 33);
            this.lVcm.MultiSelect = false;
            this.lVcm.Name = "lVcm";
            this.lVcm.Size = new System.Drawing.Size(369, 128);
            this.lVcm.TabIndex = 35;
            this.lVcm.UseCompatibleStateImageBehavior = false;
            this.lVcm.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Actual - Positive";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Actual - Negative";
            this.columnHeader3.Width = 120;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(124, 663);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 44);
            this.button5.TabIndex = 12;
            this.button5.Text = "Export Model Data to csv";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lblF1
            // 
            this.lblF1.AutoSize = true;
            this.lblF1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF1.Location = new System.Drawing.Point(263, 459);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(32, 17);
            this.lblF1.TabIndex = 34;
            this.lblF1.Text = "--%";
            // 
            // lblBAcc
            // 
            this.lblBAcc.AutoSize = true;
            this.lblBAcc.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBAcc.Location = new System.Drawing.Point(263, 627);
            this.lblBAcc.Name = "lblBAcc";
            this.lblBAcc.Size = new System.Drawing.Size(32, 17);
            this.lblBAcc.TabIndex = 32;
            this.lblBAcc.Text = "--%";
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDP.Location = new System.Drawing.Point(263, 599);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(32, 17);
            this.lblDP.TabIndex = 31;
            this.lblDP.Text = "--%";
            // 
            // lblDR
            // 
            this.lblDR.AutoSize = true;
            this.lblDR.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDR.Location = new System.Drawing.Point(263, 571);
            this.lblDR.Name = "lblDR";
            this.lblDR.Size = new System.Drawing.Size(32, 17);
            this.lblDR.TabIndex = 30;
            this.lblDR.Text = "--%";
            // 
            // lblPrev
            // 
            this.lblPrev.AutoSize = true;
            this.lblPrev.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrev.Location = new System.Drawing.Point(263, 543);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(32, 17);
            this.lblPrev.TabIndex = 29;
            this.lblPrev.Text = "--%";
            // 
            // lblNPV
            // 
            this.lblNPV.AutoSize = true;
            this.lblNPV.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPV.Location = new System.Drawing.Point(263, 515);
            this.lblNPV.Name = "lblNPV";
            this.lblNPV.Size = new System.Drawing.Size(32, 17);
            this.lblNPV.TabIndex = 28;
            this.lblNPV.Text = "--%";
            // 
            // lblPPV
            // 
            this.lblPPV.AutoSize = true;
            this.lblPPV.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPV.Location = new System.Drawing.Point(263, 487);
            this.lblPPV.Name = "lblPPV";
            this.lblPPV.Size = new System.Drawing.Size(32, 17);
            this.lblPPV.TabIndex = 27;
            this.lblPPV.Text = "--%";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpec.Location = new System.Drawing.Point(263, 375);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(32, 17);
            this.lblSpec.TabIndex = 26;
            this.lblSpec.Text = "--%";
            // 
            // lblSens
            // 
            this.lblSens.AutoSize = true;
            this.lblSens.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSens.Location = new System.Drawing.Point(263, 347);
            this.lblSens.Name = "lblSens";
            this.lblSens.Size = new System.Drawing.Size(32, 17);
            this.lblSens.TabIndex = 25;
            this.lblSens.Text = "--%";
            // 
            // lblKappa
            // 
            this.lblKappa.AutoSize = true;
            this.lblKappa.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKappa.Location = new System.Drawing.Point(263, 294);
            this.lblKappa.Name = "lblKappa";
            this.lblKappa.Size = new System.Drawing.Size(32, 17);
            this.lblKappa.TabIndex = 23;
            this.lblKappa.Text = "--%";
            // 
            // lblPVal
            // 
            this.lblPVal.AutoSize = true;
            this.lblPVal.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPVal.Location = new System.Drawing.Point(263, 263);
            this.lblPVal.Name = "lblPVal";
            this.lblPVal.Size = new System.Drawing.Size(32, 17);
            this.lblPVal.TabIndex = 22;
            this.lblPVal.Text = "--%";
            // 
            // lblNIR
            // 
            this.lblNIR.AutoSize = true;
            this.lblNIR.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIR.Location = new System.Drawing.Point(263, 235);
            this.lblNIR.Name = "lblNIR";
            this.lblNIR.Size = new System.Drawing.Size(32, 17);
            this.lblNIR.TabIndex = 21;
            this.lblNIR.Text = "--%";
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI.Location = new System.Drawing.Point(263, 207);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(32, 17);
            this.lblCI.TabIndex = 20;
            this.lblCI.Text = "--%";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.Location = new System.Drawing.Point(263, 179);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(32, 17);
            this.lblAcc.TabIndex = 17;
            this.lblAcc.Text = "--%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(193, 291);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 18;
            this.label20.Text = "Kappa :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(81, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(176, 17);
            this.label19.TabIndex = 17;
            this.label19.Text = "P-Value [Acc > NIR] :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(81, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 17);
            this.label18.TabIndex = 16;
            this.label18.Text = "No Information Rate :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(185, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 15;
            this.label17.Text = "95% CI :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(169, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Accuracy :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(169, 459);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "F1 Score :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(97, 627);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Balanced Accuracy :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(73, 599);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Detection Prevalence :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(121, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Detection Rate :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(153, 543);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Prevalence :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Neg Pred Value :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Pos Pred Value :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Specificity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sensitivity :";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(35, 713);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(72, 76);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(100, 17);
            this.label41.TabIndex = 17;
            this.label41.Text = "Number Rows:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblClColName);
            this.groupBox2.Controls.Add(this.label50);
            this.groupBox2.Controls.Add(this.label49);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.label46);
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Location = new System.Drawing.Point(304, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 286);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model Dataset Information";
            // 
            // lblClColName
            // 
            this.lblClColName.AutoSize = true;
            this.lblClColName.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClColName.Location = new System.Drawing.Point(178, 212);
            this.lblClColName.Name = "lblClColName";
            this.lblClColName.Size = new System.Drawing.Size(24, 17);
            this.lblClColName.TabIndex = 39;
            this.lblClColName.Text = "--";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(178, 155);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(24, 17);
            this.label50.TabIndex = 38;
            this.label50.Text = "--";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(178, 129);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(24, 17);
            this.label49.TabIndex = 37;
            this.label49.Text = "--";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(178, 103);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(24, 17);
            this.label48.TabIndex = 36;
            this.label48.Text = "--";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(178, 77);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(24, 17);
            this.label44.TabIndex = 35;
            this.label44.Text = "--";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(41, 154);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(131, 17);
            this.label46.TabIndex = 22;
            this.label46.Text = "Testing Data Rows:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(36, 128);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(136, 17);
            this.label45.TabIndex = 21;
            this.label45.Text = "Training Data Rows:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(23, 211);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(149, 17);
            this.label43.TabIndex = 19;
            this.label43.Text = "Classification Column: ";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(52, 102);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(120, 17);
            this.label42.TabIndex = 18;
            this.label42.Text = "Number Columns:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(53, 279);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(138, 17);
            this.label47.TabIndex = 19;
            this.label47.Text = "RNG Sampling Seed";
            // 
            // tBseed
            // 
            this.tBseed.Location = new System.Drawing.Point(55, 299);
            this.tBseed.Name = "tBseed";
            this.tBseed.Size = new System.Drawing.Size(152, 22);
            this.tBseed.TabIndex = 20;
            // 
            // lblMPVal
            // 
            this.lblMPVal.AutoSize = true;
            this.lblMPVal.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPVal.Location = new System.Drawing.Point(263, 319);
            this.lblMPVal.Name = "lblMPVal";
            this.lblMPVal.Size = new System.Drawing.Size(32, 17);
            this.lblMPVal.TabIndex = 24;
            this.lblMPVal.Text = "--%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(57, 319);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(200, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "Mcnemar\'s Test P-Value :";
            // 
            // lblRecall
            // 
            this.lblRecall.AutoSize = true;
            this.lblRecall.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecall.Location = new System.Drawing.Point(263, 431);
            this.lblRecall.Name = "lblRecall";
            this.lblRecall.Size = new System.Drawing.Size(32, 17);
            this.lblRecall.TabIndex = 37;
            this.lblRecall.Text = "--%";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(185, 431);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(72, 17);
            this.label39.TabIndex = 36;
            this.label39.Text = "Recall :";
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrec.Location = new System.Drawing.Point(263, 403);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(32, 17);
            this.lblPrec.TabIndex = 39;
            this.lblPrec.Text = "--%";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(161, 403);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(96, 17);
            this.label53.TabIndex = 38;
            this.label53.Text = "Precision :";
            // 
            // NaiveBayesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1295, 763);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFormName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NaiveBayesGUI";
            this.Text = "Excel.ML  |  Supervised Classification  |  Naive Bayes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBinputRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBOutputCell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBlaplace;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpcttrainingdata;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tBpcttestingdata;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.Label lblBAcc;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.Label lblDR;
        private System.Windows.Forms.Label lblPrev;
        private System.Windows.Forms.Label lblNPV;
        private System.Windows.Forms.Label lblPPV;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.Label lblSens;
        private System.Windows.Forms.Label lblKappa;
        private System.Windows.Forms.Label lblPVal;
        private System.Windows.Forms.Label lblNIR;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label lblClColName;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ListView lVcm;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox tBseed;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label lblRecall;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lblMPVal;
        private System.Windows.Forms.Label label21;
    }
}