using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SolucionPesaNetPantalla.ServiciosPesaNET;
using System.Net;
using System.Threading;

namespace SolucionPesaNetPantalla
{
    public partial class Bienvenido : Form
    {
        ServiciosDePantalla servicios = new ServiciosDePantalla() { Url = "http://192.168.89.100:8000/ServiciosPesaNET" };
        ProcesandoPeticion procesando = new ProcesandoPeticion();


        public Bienvenido()
        {
            InitializeComponent();
        }

       

        private void teclado_OnUserControlButtonClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (tbCodigo != null)
            {
                switch (b.Text)
                {
                    case "Borrar":
                        if (tbCodigo.Text.Length > 1)
                        {
                            tbCodigo.Text = tbCodigo.Text.Substring(0, tbCodigo.Text.Length - 1);
                        }
                        else
                        {
                            tbCodigo.Text = string.Empty;
                        }
                        break;
                    case "Entrar":                       
                        PeticionParaComprobarProductor peticion = new PeticionParaComprobarProductor() { Codigo = int.Parse(tbCodigo.Text) };
                        procesando.Limpiar();
                        procesando.Show();
                        AsyncCallback callback = new AsyncCallback(metodoRespuesta);
                        IAsyncResult ar = servicios.BeginComprobarProductor(peticion, callback, null);                     
                        break;


                    default:
                        if (tbCodigo.Text.Length < 5)
                        {

                            tbCodigo.Text += b.Text;
                        }

                        break;
                }
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(this.Width + "x" + this.Height);
        }

        private void metodoRespuesta(IAsyncResult ar)
        {
            try
            {
                RespuestaDeComprobarProductor respuesta = servicios.EndComprobarProductor(ar);
                if (respuesta.Existe)
                {
                    MessageBox.Show(respuesta.Productor.Nombre + " (" + respuesta.Plantaciones.Length + " plantaciones)");
                }
            }
            catch (WebException e)
            {
                procesando.Error = "Servidor no conectado.";
                procesando.Mensaje = e.Message;
                Thread.Sleep(2000);
                if (procesando.InvokeRequired)
                {
                    procesando.Invoke((Action)(() => procesando.Hide()));
                }
                else
                {
                    procesando.Hide();
                }


                if (procesando.InvokeRequired)
                {
                    tbCodigo.Invoke((Action)(() => tbCodigo.Text = ""));
                }
                else
                {
                    tbCodigo.Text = "";
                }
            }
            
        }
    }
}