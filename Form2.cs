using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Ass6_GUI
{
    public partial class FormTrend : Form
    {
        public FormTrend()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Connect to SQL:
            string SQLconnectionString = "Data source = DESKTOP-MHK7BOK\\SQLEXPRESS;Initial Catalog =AirHeater;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection SqlCon = new SqlConnection(SQLconnectionString);
            SqlCon.Open();
            string SQLQueryReadSensor = $"select * from ViewSensors";

            using (var adapter = new SqlDataAdapter(SQLQueryReadSensor, SqlCon))
            {
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind DataTable til DataGridView
                dGViewSensors.DataSource = dataTable;
            }
            SqlCon.Close();
            dGViewSensors.Columns[0].Width = 50;
            dGViewSensors.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
