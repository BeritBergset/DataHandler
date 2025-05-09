using Opc.Ua;
using Opc.UaFx.Client;
using Microsoft.Data.SqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;
using Microsoft.Data.SqlTypes;

namespace Ass6GUI
{
    public partial class Form1 : Form
    {
        private List<double> x_values = new List<double>();
        private List<double> TT01_values = new List<double>();
        private List<double> TT02_values = new List<double>();
        private List<double> TT02ref_values = new List<double>();
        private List<double> EHT01_values = new List<double>();
        //private List<double> MY_TT02_values = new List<double>();
        //private List<double> MY_TT03_values = new List<double>();
        private OpcClient clientR;
       
        private int cnt = 0;
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            OpcReadCyclic();
            cnt++;

        }
        void OpcReadCyclic()
        {
            //les inn alle variabler temperaturar pr syklustid
            string TT01 = "ns=2;s=TT01";
            string TT02 = "ns=2;s=TT02";
            string TT02_ref = "ns=2;s=TT02_ref";
            string EHT01 = "ns=2;s=EHT01";
            string EHT01_Mode = "ns=2;s=EHT01_Mode";
            Opc.UaFx.OpcValue opcData1 = clientR.ReadNode(TT01);
            Opc.UaFx.OpcValue opcData2 = clientR.ReadNode(TT02);
            Opc.UaFx.OpcValue opcData3 = clientR.ReadNode(TT02_ref);
            Opc.UaFx.OpcValue opcData4 = clientR.ReadNode(EHT01);
            Opc.UaFx.OpcValue opcData5 = clientR.ReadNode(EHT01_Mode).As<int>();
            TT01_values.Add((double)opcData1.Value);
            TT02_values.Add((double)opcData2.Value);
            TT02ref_values.Add((double)opcData3.Value);
            EHT01_values.Add((double)opcData4.Value);
            x_values.Add(cnt);

            txtTT01.Text = TT01_values[cnt].ToString("#.##");
            txtTT02.Text = TT02_values[cnt].ToString("#.##");
            txtTT02_ref.Text = TT02ref_values[cnt].ToString("#.##");
            txtEHT01.Text = EHT01_values[cnt].ToString("#.##");
            cbEHT01Mode.SelectedIndex = (int)opcData5.Value;

            //chart1.Series["TT01"].Points.AddXY(x_values[cnt], TT01_values[cnt]);
            cht_Temp.Series["TT02"].Points.AddXY(x_values[cnt], TT02_values[cnt]);
            cht_Temp.Series["TT02 Reference"].Points.AddXY(x_values[cnt], TT02ref_values[cnt]);
            chart2.Series["EHT01"].Points.AddXY(x_values[cnt], EHT01_values[cnt]);

            //Connect to SQL:
            string SQLconnectionString = "Data source = DESKTOP-MHK7BOK\\SQLEXPRESS;Initial Catalog =AirHeater;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection SqlCon = new SqlConnection(SQLconnectionString);
            SqlCon.Open();





            DateTime Now = DateTime.Now;

            string SQLQueryWriteSample1 = $"insertsample TT01,{TT01_values[cnt]},'{Now}'";
            lstMessages.Items.Add(DateTime.Now + SQLQueryWriteSample1);
            string SQLQueryWriteSample2 = "insertsample TT02,10.44,'2025-05-08 13:45:00'";

            SqlCommand SqlCmd = new SqlCommand(SQLQueryWriteSample1,SqlCon);
            SqlCmd.ExecuteNonQuery();
            SqlCommand SqlCmd2 = new SqlCommand(SQLQueryWriteSample2, SqlCon);
            SqlCmd2.ExecuteNonQuery();
            SqlCon.Close();
        }
        void OpcReadOnStartup()
        {
            //les inn alle variabler temperaturar pr syklustid
            string TT01 = "ns=2;s=TT01";
            string TT02 = "ns=2;s=TT02";
            string TT02_ref = "ns=2;s=TT02_ref";
            string EHT01 = "ns=2;s=EHT01";
            string EHT01_Mode = "ns=2;s=EHT01_Mode";
            Opc.UaFx.OpcValue opcData1 = clientR.ReadNode(TT01);
            Opc.UaFx.OpcValue opcData2 = clientR.ReadNode(TT02);
            Opc.UaFx.OpcValue opcData3 = clientR.ReadNode(TT02_ref);
            Opc.UaFx.OpcValue opcData4 = clientR.ReadNode(EHT01);
            Opc.UaFx.OpcValue opcData5 = clientR.ReadNode(EHT01_Mode);


            txtTT01.Text = opcData1.Value.ToString();
            txtTT02.Text = opcData2.Value.ToString();
            txtTT02_ref.Text = opcData3.Value.ToString();
            txtEHT01.Text = opcData4.Value.ToString();
            //cbEHT01Mode.SelectedIndex = (int)opcData5.Value;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the chart 1, temperatures
            cht_Temp.Series.Clear();
            cht_Temp.ChartAreas[0].AxisX.Title = "Time [s]";
            cht_Temp.ChartAreas[0].AxisY.Title = "Temperature [C]";

            // Initialize the chart 2, Air Heater Power, 
            chart2.Series.Clear();
            chart2.ChartAreas[0].AxisX.Title = "Time [s]";
            chart2.ChartAreas[0].AxisY.Title = "Output [V]";


            var TT02_ch = new Series("TT02");
            TT02_ch.ChartType = SeriesChartType.Line;
            TT02_ch.Color = System.Drawing.Color.Green;
            //TT02_ch.IsValueShownAsLabel = false;
            cht_Temp.Series.Add(TT02_ch);


            var TT02ref_ch = new Series("TT02 Reference");
            TT02ref_ch.ChartType = SeriesChartType.Line;
            TT02ref_ch.BorderDashStyle = ChartDashStyle.Dash;
            TT02ref_ch.Color = System.Drawing.Color.Red;
            // TT02ref_ch.IsVisibleInLegend = false;
            cht_Temp.Series.Add(TT02ref_ch);

            var EHT01_ch = new Series("EHT01");
            EHT01_ch.ChartType = SeriesChartType.Line;
            //EHT01_ch.IsValueShownAsLabel = false;
            chart2.Series.Add(EHT01_ch);


            // connect to OPC
            string opcUrl = "opc.tcp://desktop-mhk7bok:62640/Airheater"; // adress to OPC Server Simulator for Stryn, IO server Simulator
            clientR = new OpcClient(opcUrl);
            clientR.Connect();
            timer1.Start();
            cnt = 0;
            cbEHT01Mode.Items.Add("Off");
            cbEHT01Mode.Items.Add("Manual On");
            cbEHT01Mode.Items.Add("Auto");
            OpcReadOnStartup();



            



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cht_Temp_Click(object sender, EventArgs e)
        {

        }
        private void txtOPCStSP_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtOPCStTT01_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtOPCStTT02_TextChanged(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTT02_ref_KeyDown(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (clientR != null)
                clientR.Disconnect();
            //save to file
        }

        private void txtTT02_ref_KeyPress(object sender, KeyPressEventArgs e)
        {
            string opcUrl1 = "opc.tcp://desktop-mhk7bok:62640/Airheater"; // adress to OPC Server Simulator
            var tagName = "ns=2;s=TT02_ref";    //name in OPC server
            var clientW = new OpcClient(opcUrl1); // create new object
            clientW.Connect();
            double TT02_ref;                        // define the variable to be written to OPC
            TT02_ref = Convert.ToDouble(txtTT02_ref.Text);  //convert to right format
            clientW.WriteNode(tagName, TT02_ref);           // 
            lstMessages.Items.Add(DateTime.Now + ": New reference for TT02 set to: " + TT02_ref + " ['C]");
            clientW.Disconnect();
        }

        private void cbEHT01Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int EHT01_mode = (int)cbEHT01Mode.SelectedIndex; // the integer to be sent to OPC
            string opcUrl2 = "opc.tcp://desktop-mhk7bok:62640/Airheater"; // adress to OPC Server Simulator
            var tagName = "ns=2;s=EHT01_Mode";    //tag in OPC server
            var clientW2 = new OpcClient(opcUrl2); // create new object
            clientW2.Connect();
            clientW2.WriteNode(tagName, (int)EHT01_mode);           // 
            clientW2.Disconnect();
            lstMessages.Items.Add(DateTime.Now + ": New Mode for EHT01 set to: " + cbEHT01Mode.SelectedItem);
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void createReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string SQLconnectionString = "Data source = DESKTOP-MHK7BOK\\SQLEXPRESS;Initial Catalog =AirHeater;Integrated Security=True;TrustServerCertificate=True";
            //string SQLQueryWriteSample = "insertsample TT01,22.44,'2025-05-08 13:30:00'";
            //SqlConnection sqlCon = new SqlConnection(SQLconnectionString);
            //sqlCon.Open();
            //SqlCommand sqlCmd = new SqlCommand(SQLQueryWriteSample, sqlCon);
            //sqlCmd.ExecuteNonQuery();
            //SqlCon.Close();


        }
    }
}
