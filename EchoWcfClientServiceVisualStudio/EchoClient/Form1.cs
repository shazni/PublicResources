using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using WSO2.Echo;
using System.Runtime.InteropServices;

namespace EchoClient
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public Form1()
        {
            AllocConsole();
            InitializeComponent();
        }

        private void btnEcho_Click(object sender, EventArgs e)
        {
            echoPortTypeClient client = new echoPortTypeClient();

            try
            {
                string[] a = new string[1];
                a[0] = "John";
                string[] b = new string[1];
                b[0] = "Jane";
                int c = 999;

                //SimpleBean r = client.echoStringArrays(a, b, c);

                //int r = client.echoInt(c);
                string myname = "##### Shazni #####";
                string r = client.echoString(myname);

                Console.WriteLine("The resoponse fromo the service = " + r);
                client.Close();

                MessageBox.Show("Response received " + r);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
