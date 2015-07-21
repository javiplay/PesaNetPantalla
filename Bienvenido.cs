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
        public static ServiciosDePantalla servicios = new ServiciosDePantalla() { Url = "http://192.168.89.100:8000/ServiciosPesaNET" };
        private static PantallaProcesando _procesando = new PantallaProcesando();

        public static PantallaProcesando Procesando
        {
            get { return Bienvenido._procesando; }
            set { Bienvenido._procesando = value; }
        }
        private static PantallaSeleccion _seleccionando = new PantallaSeleccion();

        public static PantallaSeleccion Seleccionando
        {
            get { return Bienvenido._seleccionando; }
            set { Bienvenido._seleccionando = value; }
        }

        private static PantallaActualizando _actualizando = new PantallaActualizando();

        public static PantallaActualizando Actualizando
        {
            get { return Bienvenido._actualizando; }
            set { Bienvenido._actualizando = value; }
        }


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
                        Procesando.Limpiar();
                        Procesando.Show();
                        AsyncCallback callback = new AsyncCallback(CallbackComprobarProductor);
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

        public static void MostrarError(string error, string mensaje)
        {
            Procesando.Error = error;
            Procesando.Mensaje = mensaje;
            Thread.Sleep(3000);
            
            Procesando.Invoke((Action)(() => Procesando.Hide()));
          
        }

        private void CallbackComprobarProductor(IAsyncResult ar)
        {
            try
            {
                RespuestaDeComprobarProductor respuesta = servicios.EndComprobarProductor(ar);
                if (respuesta.Existe)
                {
                    Seleccionando.Datos = respuesta;
                    Seleccionando.Invoke((Action)(() => Seleccionando.Show()));
                    Procesando.Invoke((Action)(() => Procesando.Hide()));
                }
                else
                {
                    MostrarError("Productor no encontrado.", "El código proporcionado no se encuentra registrado.");
                }
            }
            catch (WebException e)
            {
                MostrarError("Servidor no conectado.", e.Message);
                tbCodigo.Invoke((Action)(() => tbCodigo.Text = ""));
            }
        }

        private void Bienvenido_Activated(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
        }
    }
}