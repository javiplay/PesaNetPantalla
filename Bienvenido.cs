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
    public partial class Bienvenido : Form
    {
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

                        ServiciosDePantalla servicios = new ServiciosDePantalla() { Url = "http://192.168.89.100:8000/ServiciosPesaNET" };
                        PeticionParaComprobarProductor peticion = new PeticionParaComprobarProductor() { Codigo = int.Parse(tbCodigo.Text) };
                        try
                        {
                            RespuestaDeComprobarProductor respuesta = servicios.ComprobarProductor(peticion);
                            if (respuesta.Existe)
                            {
                                MessageBox.Show(respuesta.Productor.Nombre + " (" + respuesta.Plantaciones.Length + " plantaciones)");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Servidor no encontrado");
                        }
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
    }
}