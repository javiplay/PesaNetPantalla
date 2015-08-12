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
    public partial class PantallaConfirmarDatos : Form
    {
        ProductorWCF _productor;

        public ProductorWCF Productor
        {
            get { return _productor; }
            set { _productor = value; }
        }


        PlantacionWCF _plantacion;

        public PlantacionWCF Plantacion
        {
            get { return _plantacion; }
            set { _plantacion = value; }
        }
        MedianeriaWCF _medianeria;

        public MedianeriaWCF Medianeria
        {
            get { return _medianeria; }
            set { _medianeria = value; }
        }
        VehiculoWCF _vehiculo;

        public VehiculoWCF Vehiculo
        {
            get { return _vehiculo; }
            set { _vehiculo = value; }
        }

        CalidadWCF _calidad;

        public CalidadWCF Calidad
        {
            get { return _calidad; }
            set { _calidad = value; }
        }

        VariedadWCF _variedad;

        public VariedadWCF Variedad
        {
            get { return _variedad; }
            set { _variedad = value; }
        }

        public PantallaConfirmarDatos()
        {
            InitializeComponent();
        }

        private void PantallaConfirmarDatos_Activated(object sender, EventArgs e)
        {
            lbProductor.Text = Productor.Mostrar;
            lbPlantacion.Text = Plantacion.Mostrar;
            lbVehiculo.Text = Vehiculo.Mostrar;
            lbMedianeria.Text = Medianeria.Nombre;
            if (Medianeria.Medianeros != null )
            {
                listMedianeros.Visible = true;
                listMedianeros.DataSource = Medianeria.Medianeros;
                listMedianeros.DisplayMember = "Mostrar";
                listMedianeros.Enabled = false;
                listMedianeros.SelectedIndex = -1;
            }
            else
            {
                listMedianeros.Visible = false;
            }
            lbCalidad.Text = Calidad.Mostrar;
            lbVariedad.Text = Variedad.Mostrar;
            
        }

      
    }
}