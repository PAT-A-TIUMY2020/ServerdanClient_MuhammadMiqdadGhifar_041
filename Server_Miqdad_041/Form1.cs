using ServerdanClient_MuhammadMiqdadGhifar_041.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Miqdad_041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(iMatematika));
                hostObj.Open();

                hostObj.Close();
            }
            catch (Exception ex)
            {
                button2.Enabled = false;
                button1.Enabled = true;
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(iMatematika));
                hostObj.Close();

                button2.Enabled = false;
                button1.Enabled = true;
                Console.WriteLine("Server's OFF");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
    
}
