namespace SolucionPesaNetPantalla
{
    partial class PantallaFinal
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbPesoFinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(290, 425);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(192, 50);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            // 
            // lbPesoFinal
            // 
            this.lbPesoFinal.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Regular);
            this.lbPesoFinal.Location = new System.Drawing.Point(324, 95);
            this.lbPesoFinal.Name = "lbPesoFinal";
            this.lbPesoFinal.Size = new System.Drawing.Size(397, 73);
            this.lbPesoFinal.Text = "...";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(207, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 73);
            this.label1.Text = "Peso:";
            // 
            // PantallaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPesoFinal);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaFinal";
            this.Text = "PantallaFinal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbPesoFinal;
    }
}