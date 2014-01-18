using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using LabTrak.SQLTools;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTrak
{
    public partial class Form1 : Form
    {
        CompactDataBaseConnection dataBaseConnector = new CompactDataBaseConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBaseConnector.ConnectToDatabase(LabTrak.Properties.Settings.Default.LabTrakDBConnectionString);
        }
    }
}
