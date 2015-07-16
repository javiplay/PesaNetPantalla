using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SolucionPesaNetPantalla
{
    public partial class ProcesandoPeticion : Form
    {
        public ProcesandoPeticion()
        {
            InitializeComponent();
        }
        int cont;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;

        }
    }
}