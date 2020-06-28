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
            this.panelRutinas = new System.Windows.Forms.Panel();
            this.nuevaRutina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelRutinas
            // 
            this.panelRutinas.AutoScroll = true;
            this.panelRutinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRutinas.Location = new System.Drawing.Point(0, 0);
            this.panelRutinas.Name = "panelRutinas";
            this.panelRutinas.Size = new System.Drawing.Size(1587, 503);
            this.panelRutinas.TabIndex = 1;
            // 
            // nuevaRutina
            // 
            this.nuevaRutina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nuevaRutina.BackColor = System.Drawing.Color.Coral;
            this.nuevaRutina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nuevaRutina.FlatAppearance.BorderSize = 0;
            this.nuevaRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaRutina.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaRutina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nuevaRutina.Image = global::MainRoutinesProject.Properties.Resources.mas_64px;
            this.nuevaRutina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nuevaRutina.Location = new System.Drawing.Point(55, 532);
            this.nuevaRutina.Name = "nuevaRutina";
            this.nuevaRutina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nuevaRutina.Size = new System.Drawing.Size(234, 139);
            this.nuevaRutina.TabIndex = 5;
            this.nuevaRutina.Text = "NUEVA RUTINA";
            this.nuevaRutina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevaRutina.UseVisualStyleBackColor = false;
            this.nuevaRutina.Click += new System.EventHandler(this.nuevaRutina_Click);
            // 
            // RutinasScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1587, 722);
            this.Controls.Add(this.nuevaRutina);
            this.Controls.Add(this.panelRutinas);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RutinasScreen";
            this.Text = "Rutinas";
            this.Load += new System.EventHandler(this.Rutinas_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRutinas;
        private System.Windows.Forms.Button nuevaRutina;
    }
}