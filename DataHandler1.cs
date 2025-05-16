using System;
using RealTimeModule;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;
using Opc.UaFx.Client;

namespace DataModule
{
    public partial class DataHandler1 : Form
    {

        public DataHandler1()
        {
            InitializeComponent();
            // timer1.Interval = 1000;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // read all strings into variables and create a new Data Handler Form. Form3
            string NewServer = txtServer.Text;
            string NewSQLServer = txtSqlServer.Text;
            string NewDatabase = txtDatabase.Text;
            string NewIp = txtIpAdresse.Text;
            string NewPort = txtPort.Text;
            string NewOPCServer = txtOpcServerName.Text;
            String DataHandlerName = txtPCSName.Text;
            string NewOpcUrl = $"opc.tcp://{NewIp}:{NewPort}/{NewOPCServer}"; // adresse to OPC Server Simulator for Stryn, IO server Simulator
            RealTimeData RealTimeModule = new RealTimeData(NewServer, NewSQLServer, NewDatabase, NewOpcUrl,DataHandlerName);
            RealTimeModule.Show();

        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    OpcReadCyclic();
        //    cnt++;
        //}


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
