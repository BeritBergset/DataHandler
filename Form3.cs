using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AirHeater
{
    public partial class Alarms : Form
    {
        public SqlConnection SqlCon = new SqlConnection("Data source = DESKTOP-MHK7BOK\\SQLEXPRESS;Initial Catalog =AirHeater;Integrated Security=True;TrustServerCertificate=True");
        public Alarms()
        {
            InitializeComponent();
            time.Interval = 1000;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //opne kontakt mot SQL
            SqlCon.Open();

            //lese alle alarmar i alarmdatabasen
            string SQLQueryReadAlarms = $"select ID, AlarmTag, Time, AlarmState, Description from ViewAlarms";

            using (var adapter = new SqlDataAdapter(SQLQueryReadAlarms, SqlCon))
            {
                var SensorTable = new DataTable();
                adapter.Fill(SensorTable);

                // Bind DataTable til DataGridView
                dgAlarms.DataSource = SensorTable;
            }

            //dgAlarms.Columns[0].Width = 50;
            dgAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            SQLReadCyclic();
            
        }
        private void SQLReadCyclic()
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var AlarmID = dgAlarms.Rows[e.RowIndex].Cells[0].Value;
            string SQLQueryUpdateAlarms = $"select ID, AlarmTag, Time, AlarmState, Description from ViewAlarms";
            lstMessages.Items.Add("Chosen AlarmID: " + AlarmID);

        }

        private void lstMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
