using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SolucionPesaNetPantalla.ServiciosPesaNET;

namespace SolucionPesaNetPantalla
{
    public partial class PantallaActualizando : Form
    {
        public PantallaActualizando()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PeticionParaActualizarProceso peticion = new PeticionParaActualizarProceso() { Linea = 1 };
            RespuestaDeActualizarProceso respuesta = Bienvenido.servicios.ActualizarProceso(peticion);
            lbParcial.Text = respuesta.Parcial.ToString();
            lbTotal.Text = respuesta.Total.ToString();
            if (respuesta.Duracion == null)
            {
                lbDuracion.Text = "-";
            }
            else
            {
                lbDuracion.Text = respuesta.Duracion.ToString();
            }
            if (respuesta.Finalizado)
            {
                timer1.Enabled = false;
                Bienvenido.Final.Invoke((Action)(() => Bienvenido.Final.lbPesoFinal.Text = respuesta.Total.ToString()));
                Bienvenido.Actualizando.Invoke((Action)(() => Bienvenido.Actualizando.Hide()));
                Bienvenido.Seleccionando.Invoke((Action)(() => Bienvenido.Seleccionando.Hide()));
                Bienvenido.Final.Invoke((Action)(() => Bienvenido.Final.ShowDialog()));
                
            }
        }
    }
}