namespace Ass6GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            txtTT02_ref = new TextBox();
            label1 = new Label();
            txtTT01 = new TextBox();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            txtTT02 = new TextBox();
            cht_Temp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            txtEHT01 = new TextBox();
            label4 = new Label();
            cbEHT01Mode = new ComboBox();
            label5 = new Label();
            lstMessages = new ListBox();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new MenuStrip();
            realTimeDataToolStripMenuItem = new ToolStripMenuItem();
            historicalDataToolStripMenuItem = new ToolStripMenuItem();
            trendToolStripMenuItem = new ToolStripMenuItem();
            createReportToolStripMenuItem = new ToolStripMenuItem();
            alarmHandlingToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)cht_Temp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTT02_ref
            // 
            txtTT02_ref.AllowDrop = true;
            txtTT02_ref.Location = new Point(329, 166);
            txtTT02_ref.Name = "txtTT02_ref";
            txtTT02_ref.Size = new Size(78, 31);
            txtTT02_ref.TabIndex = 1;
            txtTT02_ref.TextChanged += txtOPCStSP_TextChanged;
            txtTT02_ref.KeyDown += txtTT02_ref_KeyDown;
            txtTT02_ref.KeyPress += txtTT02_ref_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 173);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 4;
            label1.Text = "TT02 Setpoint [C]";
            // 
            // txtTT01
            // 
            txtTT01.Location = new Point(329, 92);
            txtTT01.Name = "txtTT01";
            txtTT01.Size = new Size(78, 31);
            txtTT01.TabIndex = 5;
            txtTT01.TextChanged += txtOPCStTT01_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 88);
            label2.Name = "label2";
            label2.Size = new Size(283, 25);
            label2.TabIndex = 6;
            label2.Text = "TT01 Environment temperature [C]";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 133);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 8;
            label3.Text = "TT02 Heated [C]";
            // 
            // txtTT02
            // 
            txtTT02.Enabled = false;
            txtTT02.Location = new Point(329, 129);
            txtTT02.Name = "txtTT02";
            txtTT02.Size = new Size(78, 31);
            txtTT02.TabIndex = 7;
            txtTT02.TextChanged += txtOPCStTT02_TextChanged;
            // 
            // cht_Temp
            // 
            chartArea1.Name = "ChartArea1";
            cht_Temp.ChartAreas.Add(chartArea1);
            cht_Temp.ImeMode = ImeMode.On;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            cht_Temp.Legends.Add(legend1);
            cht_Temp.Location = new Point(475, 73);
            cht_Temp.Name = "cht_Temp";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            cht_Temp.Series.Add(series1);
            cht_Temp.Size = new Size(916, 341);
            cht_Temp.TabIndex = 23;
            cht_Temp.Text = "chart1";
            cht_Temp.Click += cht_Temp_Click;
            // 
            // txtEHT01
            // 
            txtEHT01.Location = new Point(329, 203);
            txtEHT01.Name = "txtEHT01";
            txtEHT01.Size = new Size(78, 31);
            txtEHT01.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 210);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 26;
            label4.Text = "Airheater [V]";
            label4.Click += label4_Click;
            // 
            // cbEHT01Mode
            // 
            cbEHT01Mode.FormattingEnabled = true;
            cbEHT01Mode.Location = new Point(327, 249);
            cbEHT01Mode.Name = "cbEHT01Mode";
            cbEHT01Mode.Size = new Size(80, 33);
            cbEHT01Mode.TabIndex = 27;
            cbEHT01Mode.SelectedIndexChanged += cbEHT01Mode_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 252);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 28;
            label5.Text = "Control Mode:";
            label5.Click += label5_Click;
            // 
            // lstMessages
            // 
            lstMessages.FormattingEnabled = true;
            lstMessages.ItemHeight = 25;
            lstMessages.Location = new Point(31, 666);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(1360, 154);
            lstMessages.TabIndex = 29;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(475, 420);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(916, 240);
            chart2.TabIndex = 24;
            chart2.Text = "chart2";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { realTimeDataToolStripMenuItem, historicalDataToolStripMenuItem, alarmHandlingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1418, 33);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // realTimeDataToolStripMenuItem
            // 
            realTimeDataToolStripMenuItem.Name = "realTimeDataToolStripMenuItem";
            realTimeDataToolStripMenuItem.Size = new Size(140, 29);
            realTimeDataToolStripMenuItem.Text = "Real time data";
            // 
            // historicalDataToolStripMenuItem
            // 
            historicalDataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trendToolStripMenuItem, createReportToolStripMenuItem });
            historicalDataToolStripMenuItem.Name = "historicalDataToolStripMenuItem";
            historicalDataToolStripMenuItem.Size = new Size(141, 29);
            historicalDataToolStripMenuItem.Text = "Historical data";
            // 
            // trendToolStripMenuItem
            // 
            trendToolStripMenuItem.Name = "trendToolStripMenuItem";
            trendToolStripMenuItem.Size = new Size(222, 34);
            trendToolStripMenuItem.Text = "Trend";
            trendToolStripMenuItem.Click += trendToolStripMenuItem_Click;
            // 
            // createReportToolStripMenuItem
            // 
            createReportToolStripMenuItem.Name = "createReportToolStripMenuItem";
            createReportToolStripMenuItem.Size = new Size(222, 34);
            createReportToolStripMenuItem.Text = "Create Report";
            createReportToolStripMenuItem.Click += createReportToolStripMenuItem_Click;
            // 
            // alarmHandlingToolStripMenuItem
            // 
            alarmHandlingToolStripMenuItem.Name = "alarmHandlingToolStripMenuItem";
            alarmHandlingToolStripMenuItem.Size = new Size(152, 29);
            alarmHandlingToolStripMenuItem.Text = "Alarm Handling";
            alarmHandlingToolStripMenuItem.Click += alarmHandlingToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1418, 879);
            Controls.Add(lstMessages);
            Controls.Add(label5);
            Controls.Add(cbEHT01Mode);
            Controls.Add(label4);
            Controls.Add(txtEHT01);
            Controls.Add(chart2);
            Controls.Add(cht_Temp);
            Controls.Add(label3);
            Controls.Add(txtTT02);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTT01);
            Controls.Add(txtTT02_ref);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Tag = "ItemID";
            Text = "Air Heater";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cht_Temp).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTT02_ref;
        private Label label1;
        private TextBox txtTT01;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private TextBox txtTT02;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart2;
        private TextBox txtEHT01;
        private Label label4;
        private ComboBox cbEHT01Mode;
        private Label label5;
        private ListBox lstMessages;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem realTimeDataToolStripMenuItem;
        private ToolStripMenuItem historicalDataToolStripMenuItem;
        private ToolStripMenuItem createReportToolStripMenuItem;
        private ToolStripMenuItem alarmHandlingToolStripMenuItem;
        private ToolStripMenuItem trendToolStripMenuItem;
    }
}
