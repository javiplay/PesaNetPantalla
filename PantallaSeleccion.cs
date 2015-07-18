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
    }
}