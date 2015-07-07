using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SolucionPesaNetPantalla.lenovo_pc;

namespace SolucionPesaNetPantalla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelloWorldService serv = new HelloWorldService() { Url = "http://192.168.89.100:8000/Test" };
            MessageBox.Show( serv.SayHello("Javier"));
        }
    }
}