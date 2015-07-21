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

namespace SolucionPesaNetPantalla
{
    public partial class PantallaSeleccion : Form
    {
        RespuestaDeComprobarProductor _datos;

        public RespuestaDeComprobarProductor Datos
        {
            get { return _datos; }
            set { _datos = value; }
        }

        public PantallaSeleccion()
        {
            InitializeComponent();            
            
        }

        private void PantallaSeleccion_Activated(object sender, EventArgs e)
        {
            lbProductor.Text = Datos.Productor.Nombre + " " + Datos.Productor.Apellidos ?? "";


            cbPlantacion.DataSource = Datos.Plantaciones;
            cbPlantacion.DisplayMember = "Mostrar";
            cbPlantacion.ValueMember = "Id";

            cbMedianeria.DataSource = Datos.Medianerias;
            cbMedianeria.DisplayMember = "Mostrar";
            cbMedianeria.ValueMember = "Id";

            cbVehiculo.DataSource = Datos.Vehiculos;
            cbVehiculo.DisplayMember = "Mostrar";
            cbVehiculo.ValueMember = "Id";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantallaConfirmacion confirmar = new PantallaConfirmacion();
            confirmar.lbMensaje.Text = "¿Desea cancelar la introducción de datos y volver a la pantalla inicial?";
            confirmar.btnAceptar.Text = "Sí";
            confirmar.btnCancelar.Text = "No";
           
            confirmar.ShowDialog();
            if (confirmar.DialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            PantallaConfirmarDatos confirmaDatos = new PantallaConfirmarDatos();
            confirmaDatos.Productor = Datos.Productor;
            confirmaDatos.Plantacion = cbPlantacion.SelectedItem as PlantacionWCF;
            confirmaDatos.Medianeria = cbMedianeria.SelectedItem as MedianeriaWCF;
            confirmaDatos.Vehiculo = cbVehiculo.SelectedItem as VehiculoWCF;

            // se muestra la confirmación como diálogo
            confirmaDatos.ShowDialog();

            if (confirmaDatos.DialogResult == DialogResult.Yes)
            {
                // iniciar pesada con los datos 
                PeticionParaIniciarProceso peticion = new PeticionParaIniciarProceso() 
                {
                 Linea = 1,
                 Productor = confirmaDatos.Productor,
                 Plantacion = confirmaDatos.Plantacion, 
                 Medianeria = (confirmaDatos.Medianeria.Id == -1)? null: confirmaDatos.Medianeria,
                 Vehiculo = (confirmaDatos.Vehiculo.Id == -1)? null: confirmaDatos.Vehiculo
                };

                Bienvenido.Procesando.Limpiar();
                Bienvenido.Procesando.Show();
                AsyncCallback callback = new AsyncCallback(CallbackIniciarProceso);
                IAsyncResult ar = Bienvenido.servicios.BeginIniciarProceso(peticion, callback, null);

            }            

        }

        private void CallbackIniciarProceso(IAsyncResult ar)
        {
            try
            {
                RespuestaDeIniciarProceso respuesta = Bienvenido.servicios.EndIniciarProceso(ar);
                if (respuesta.ProcesoIniciado)
                {
                    Bienvenido.Actualizando.Invoke((Action)(() => Bienvenido.Actualizando.Show()));
                    Bienvenido.Procesando.Invoke((Action)(() => Bienvenido.Procesando.Hide()));
                }
                else
                {
                    Bienvenido.MostrarError("Productor no encontrado.", "El código proporcionado no se encuentra registrado.");
                }
            }
            catch (WebException e)
            {
                Bienvenido.MostrarError("Servidor no conectado.", e.Message);
            }
        }
    }
}