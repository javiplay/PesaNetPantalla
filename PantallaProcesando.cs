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
    public partial class PantallaProcesando : Form
    {
        public PantallaProcesando()
        {
            InitializeComponent();
            lbError.Text = "";
            lbMensaje.Text = "";

        }
        int cont;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont = (cont + 1) % 5;
            lbProcesando.Text = "Procesando petición";
            for (int i = 0; i < cont; i++)
            {
                lbProcesando.Text += ".";
            }
        }

        public void Limpiar()
        {
            Error = "";
            Mensaje = "";
        }
        public string Error
        {
            get { return lbError.Text; }
            set {
                if (lbError.InvokeRequired)
                {
                    lbError.Invoke((Action)(() => lbError.Text = value));
                }
                else
                {
                    lbError.Text = value;
                }
            }
        }
        public string Mensaje
        {
            get { return lbMensaje.Text; }
            set {
                if (lbMensaje.InvokeRequired)
                {
                    lbMensaje.Invoke((Action)(() => lbMensaje.Text = value));
                }
                else
                {
                    lbMensaje.Text = value;
                }
            }
        }

       


    }
}