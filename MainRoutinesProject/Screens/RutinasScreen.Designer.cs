namespace MainRoutinesProject.Screens
{
    partial class RutinasScreen
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
            this.components = new System.ComponentModel.Container();
            this.panelRutinas = new System.Windows.Forms.Panel();
            this.nuevaRutina = new OnixLibrary.CustomControls.FlatOnix();
            this.onixConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.onixConnectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRutinas
            // 
            this.panelRutinas.AutoScroll = true;
            this.panelRutinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRutinas.Location = new System.Drawing.Point(0, 0);
            this.panelRutinas.Name = "panelRutinas";
            this.panelRutinas.Size = new System.Drawing.Size(1587, 451);
            this.panelRutinas.TabIndex = 1;
            // 
            // nuevaRutina
            // 
            this.nuevaRutina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nuevaRutina.BackColor = System.Drawing.Color.Coral;
            this.nuevaRutina.Imagen = global::MainRoutinesProject.Properties.Resources.mas;
            this.nuevaRutina.Location = new System.Drawing.Point(31, 479);
            this.nuevaRutina.Name = "nuevaRutina";
            this.nuevaRutina.Size = new System.Drawing.Size(299, 206);
            this.nuevaRutina.TabIndex = 0;
            this.nuevaRutina.Texto = "Nueva Rutina";
            this.nuevaRutina.Click += new System.EventHandler(this.nuevaRutina_Click);
            // 
            // onixConnectionBindingSource
            // 
            this.onixConnectionBindingSource.DataSource = typeof(OnixLibrary.OnixConnection);
            // 
            // Rutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1587, 722);
            this.Controls.Add(this.panelRutinas);
            this.Controls.Add(this.nuevaRutina);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rutinas";
            this.Text = "Rutinas";
            this.Load += new System.EventHandler(this.Rutinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.onixConnectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OnixLibrary.CustomControls.FlatOnix nuevaRutina;
        private System.Windows.Forms.BindingSource onixConnectionBindingSource;
        private System.Windows.Forms.Panel panelRutinas;
    }
}