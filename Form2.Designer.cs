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
            dGViewSensors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dGViewSensors).BeginInit();
            SuspendLayout();
            // 
            // dGViewSensors
            // 
            dGViewSensors.BorderStyle = BorderStyle.Fixed3D;
            dGViewSensors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGViewSensors.GridColor = SystemColors.Info;
            dGViewSensors.Location = new Point(22, 22);
            dGViewSensors.Name = "dGViewSensors";
            dGViewSensors.RowHeadersWidth = 62;
            dGViewSensors.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dGViewSensors.Size = new Size(518, 109);
            dGViewSensors.TabIndex = 0;
            dGViewSensors.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormTrend
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 526);
            Controls.Add(dGViewSensors);
            Name = "FormTrend";
            Text = "Trend";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dGViewSensors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGViewSensors;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewTextBoxColumn Description;
    }
}