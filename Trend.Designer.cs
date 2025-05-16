namespace Ass6_GUI
{
    partial class FormTrend
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dGViewSensors = new DataGridView();
            lblSensorlist = new Label();
            lstMessages = new ListBox();
            cht_Trend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGViewSensors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cht_Trend).BeginInit();
            SuspendLayout();
            // 
            // dGViewSensors
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dGViewSensors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dGViewSensors.BorderStyle = BorderStyle.Fixed3D;
            dGViewSensors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGViewSensors.GridColor = SystemColors.ControlLightLight;
            dGViewSensors.Location = new Point(12, 51);
            dGViewSensors.Name = "dGViewSensors";
            dGViewSensors.ReadOnly = true;
            dGViewSensors.RowHeadersWidth = 62;
            dGViewSensors.ScrollBars = ScrollBars.Vertical;
            dGViewSensors.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dGViewSensors.Size = new Size(339, 183);
            dGViewSensors.TabIndex = 0;
            dGViewSensors.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblSensorlist
            // 
            lblSensorlist.AutoSize = true;
            lblSensorlist.Location = new Point(16, 19);
            lblSensorlist.Name = "lblSensorlist";
            lblSensorlist.Size = new Size(122, 25);
            lblSensorlist.TabIndex = 1;
            lblSensorlist.Text = "Choose a Tag:";
            // 
            // lstMessages
            // 
            lstMessages.FormattingEnabled = true;
            lstMessages.ItemHeight = 25;
            lstMessages.Location = new Point(17, 452);
            lstMessages.Name = "lstMessages";
            lstMessages.SelectionMode = SelectionMode.MultiSimple;
            lstMessages.Size = new Size(1313, 129);
            lstMessages.TabIndex = 2;
            // 
            // cht_Trend
            // 
            chartArea1.Name = "ChartArea1";
            cht_Trend.ChartAreas.Add(chartArea1);
            cht_Trend.ImeMode = ImeMode.On;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            cht_Trend.Legends.Add(legend1);
            cht_Trend.Location = new Point(414, 51);
            cht_Trend.Name = "cht_Trend";
            cht_Trend.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            cht_Trend.Series.Add(series1);
            cht_Trend.Size = new Size(916, 395);
            cht_Trend.TabIndex = 24;
            cht_Trend.Text = "chart1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 424);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 32;
            label6.Text = "Logg";
            // 
            // FormTrend
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 587);
            Controls.Add(label6);
            Controls.Add(cht_Trend);
            Controls.Add(lstMessages);
            Controls.Add(lblSensorlist);
            Controls.Add(dGViewSensors);
            Name = "FormTrend";
            Text = "Trend";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dGViewSensors).EndInit();
            ((System.ComponentModel.ISupportInitialize)cht_Trend).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGViewSensors;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn Description;
        private Label lblSensorlist;
        private ListBox lstMessages;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Trend;
        private Label label6;
    }
}