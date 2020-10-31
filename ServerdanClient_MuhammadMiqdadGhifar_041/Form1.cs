using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerdanClient_MuhammadMiqdadGhifar_041
{
    public partial class Form1 : Form
    {
        ServiceReference1.iMatematika obj = new ServiceReference1.iMatematika();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            int angka1 = Int32.Parse(textBox1.Text);
            int angka2 = Int32.Parse(textBox2.Text);



            label7.Text = obj.Tambah(angka1, angka2).ToString();
            label8.Text = obj.Kurang(angka1, angka2).ToString();
            label9.Text = obj.Kali(angka1, angka2).ToString();
            label10.Text = obj.Bagi(angka1, angka2).ToString();



        }
    }
}
