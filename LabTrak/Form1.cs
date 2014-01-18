using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlServerCe;
using LabTrak.SQLTools;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTrak
{
    public partial class Form1 : Form
    {
        CompactDataBaseConnection dataBaseConnector = new CompactDataBaseConnection();
        CompactDatabaseCommand dataBaseCommand = new CompactDatabaseCommand();
        CompactDatabaseReader dataBaseReader = new CompactDatabaseReader();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //For Test Purposes: Testing Connection, Creating a new row of data, then read that data, and publish it to the TextBox control
            dataBaseConnector.ConnectToDatabase(LabTrak.Properties.Settings.Default.LabTrakDBConnectionString);
            dataBaseCommand.CreateCommand(new SqlCeCommand("INSERT INTO ComputerInformation (ComputerName, AssetTag)", dataBaseConnector.SqlCeSocket));
            dataBaseCommand.SqlCeCommandString.ExecuteNonQuery(); //Need to fix this line, it throws an exception
            dataBaseCommand.CreateCommand(new SqlCeCommand("SELECT * FROM ComputerInformation", dataBaseConnector.SqlCeSocket));
            dataBaseReader.CreateReader(dataBaseCommand.SqlCeCommandString.ExecuteReader());
            
            textBox1.Text = dataBaseReader.ReadDataStrings(dataBaseReader.SqlCeReader, new int[] { 5, 6 } );
        }
    }
}
