namespace SolucionPesaNetPantalla
{
    partial class ProcesandoPeticion
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
            this.timer1 = new System.Windows.Forms.Timer();
            this.lbProcesando = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbProcesando
            // 
            this.lbProcesando.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lbProcesando.ForeColor = System.Drawing.Color.Orange;
            this.lbProcesando.Location = new System.Drawing.Point(152, 40);
            this.lbProcesando.Name = "lbProcesando";
            this.lbProcesando.Size = new System.Drawing.Size(470, 52);
            this.lbProcesando.Text = "...";
            // 
            // lbError
            // 
            this.lbError.Location = new System.Drawing.Point(82, 150);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(634, 42);
            this.lbError.Text = "El servidor no está conectado";
            // 
            // lbMensaje
            // 
            this.lbMensaje.Location = new System.Drawing.Point(82, 192);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(634, 185);
            this.lbMensaje.Text = "No server found (exception message)";
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            
            // 
            // ProcesandoPeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 575);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbProcesando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcesandoPeticion";
            this.Text = "ProcesandoPeticion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbProcesando;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Timer timer2;
    }
}