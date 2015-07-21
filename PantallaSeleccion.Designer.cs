namespace SolucionPesaNetPantalla
{
    partial class PantallaSeleccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbProductor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPlantacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMedianeria = new System.Windows.Forms.ComboBox();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.Text = "Bienvenido";
            // 
            // lbProductor
            // 
            this.lbProductor.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lbProductor.ForeColor = System.Drawing.Color.Black;
            this.lbProductor.Location = new System.Drawing.Point(276, 40);
            this.lbProductor.Name = "lbProductor";
            this.lbProductor.Size = new System.Drawing.Size(195, 45);
            this.lbProductor.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(47, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 32);
            this.label2.Text = "Seleccione el cultivo";
            // 
            // cbPlantacion
            // 
            this.cbPlantacion.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular);
            this.cbPlantacion.Location = new System.Drawing.Point(47, 152);
            this.cbPlantacion.Name = "cbPlantacion";
            this.cbPlantacion.Size = new System.Drawing.Size(704, 49);
            this.cbPlantacion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(47, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 32);
            this.label3.Text = "Seleccione medianería";
            // 
            // cbMedianeria
            // 
            this.cbMedianeria.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular);
            this.cbMedianeria.Location = new System.Drawing.Point(47, 260);
            this.cbMedianeria.Name = "cbMedianeria";
            this.cbMedianeria.Size = new System.Drawing.Size(704, 49);
            this.cbMedianeria.TabIndex = 7;
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular);
            this.cbVehiculo.Location = new System.Drawing.Point(47, 376);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(704, 49);
            this.cbVehiculo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(47, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 32);
            this.label4.Text = "Seleccione vehículo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(122, 478);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 50);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.Location = new System.Drawing.Point(490, 478);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(192, 50);
            this.btnContinuar.TabIndex = 16;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // PantallaSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 575);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMedianeria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPlantacion);
            this.Controls.Add(this.lbProductor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaSeleccion";
            this.Text = "SeleccionarDatos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.PantallaSeleccion_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProductor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPlantacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMedianeria;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
    }
}