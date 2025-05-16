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
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;

namespace Ass6_GUI
{
    public partial class FormTrend : Form
    {
       
       
        public SqlConnection SqlCon = new SqlConnection("Data source = DESKTOP-MHK7BOK\\SQLEXPRESS;Initial Catalog =AirHeater;Integrated Security=True;TrustServerCertificate=True");
        public FormTrend()
        {
             InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           //opne kontakt mot SQL
            SqlCon.Open();
            
            //lese sensorane i sensorlista
            string SQLQueryReadSensor = $"select SensorID, SensorTag, Description from ViewSensors";

            using (var adapter = new SqlDataAdapter(SQLQueryReadSensor, SqlCon))
            {
                var SensorTable = new DataTable();
                adapter.Fill(SensorTable);

                // Bind DataTable til DataGridView
                dGViewSensors.DataSource = SensorTable;
            }
            
            dGViewSensors.Columns[0].Width = 50;
            dGViewSensors.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            // Initialize the chart 
            cht_Trend.Series.Clear();

            //lage ferske 1.min verdiar
            string SQLQueryCreate1MinSamples1= "calculate1Min 1";
            string SQLQueryCreate1MinSamples2 = "calculate1Min 2";
            string SQLQueryCreate1MinSamples3 = "calculate1Min 3";
            SqlCommand SqlCmd1 = new SqlCommand(SQLQueryCreate1MinSamples1, SqlCon);
            SqlCmd1.ExecuteNonQuery();
            SqlCommand SqlCmd2 = new SqlCommand(SQLQueryCreate1MinSamples2, SqlCon);
            SqlCmd2.ExecuteNonQuery();
            SqlCommand SqlCmd3 = new SqlCommand(SQLQueryCreate1MinSamples3, SqlCon);
            SqlCmd3.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // henter den tagen som er valgt, og skal oppdatere trend
        {
            var Tag = dGViewSensors.Rows[e.RowIndex].Cells[1].Value.ToString();
            lstMessages.Items.Add("Chosen Tag: " + Tag);
            //cht_Trend.Series.Clear();
            

            ReadAndPresent1MinSamples(Tag);
        }
        private void ReadAndPresent1MinSamples(string Tag)
        {
            DateTime Now = DateTime.Now;
    
            string SQLQueryReadSample1Min = $"select Timestamp,AvgValue from view1MinSamples where SensorTag='{Tag}' and Timestamp >= DATEADD(MINUTE, -60, GETDATE()) order by TimeStamp desc";
            lstMessages.Items.Add(SQLQueryReadSample1Min);
            SqlCommand command = new(SQLQueryReadSample1Min, SqlCon);
            SqlDataReader read1MinSamples = command.ExecuteReader();
            
            Series Serie1 = new(Tag);
            Serie1.ChartType = SeriesChartType.Line;
            Serie1.MarkerStyle = MarkerStyle.Circle;
            Serie1.MarkerSize = 5;
            cht_Trend.Series.Add(Serie1);
            cht_Trend.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:ss";
            cht_Trend.ChartAreas[0].AxisX.Title = "Time [min]";
            cht_Trend.ChartAreas[0].AxisY.Title = "Temperature [C]";
            cht_Trend.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            cht_Trend.ChartAreas[0].BackColor = Color.LightGray;


            while (read1MinSamples.Read())
            {
                //lstMessages.Items.Add(read1MinSamples.GetDateTime(0) + " og " + read1MinSamples.GetDouble(1));
                DateTime timestamp = read1MinSamples.GetDateTime(0);
                double Sampleverdi = read1MinSamples.GetDouble(1);
                              
                // Legg til data i chart
                cht_Trend.Series[Tag].Points.AddXY(timestamp, Sampleverdi);
            }

            read1MinSamples.Close();
            //SqlCon.Close();
        }


    }
}

