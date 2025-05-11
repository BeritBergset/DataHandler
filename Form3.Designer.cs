namespace AirHeater
{
    partial class Alarms
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
            dgAlarms = new DataGridView();
            lstMessages = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgAlarms).BeginInit();
            SuspendLayout();
            // 
            // dgAlarms
            // 
            dgAlarms.AllowUserToAddRows = false;
            dgAlarms.AllowUserToDeleteRows = false;
            dgAlarms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlarms.Location = new Point(0, 0);
            dgAlarms.Name = "dgAlarms";
            dgAlarms.ReadOnly = true;
            dgAlarms.RowHeadersWidth = 62;
            dgAlarms.Size = new Size(1366, 493);
            dgAlarms.TabIndex = 0;
            dgAlarms.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lstMessages
            // 
            lstMessages.FormattingEnabled = true;
            lstMessages.ItemHeight = 25;
            lstMessages.Location = new Point(0, 539);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(1366, 129);
            lstMessages.TabIndex = 1;
            lstMessages.SelectedIndexChanged += lstMessages_SelectedIndexChanged;
            // 
            // Alarms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1558, 680);
            Controls.Add(lstMessages);
            Controls.Add(dgAlarms);
            Name = "Alarms";
            Text = "Alarm Handler";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgAlarms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgAlarms;
        private ListBox lstMessages;
    }
}