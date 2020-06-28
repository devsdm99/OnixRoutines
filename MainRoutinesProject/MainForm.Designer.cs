namespace MainRoutinesProject
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titulo = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoOnix = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rutinasButton = new System.Windows.Forms.Button();
            this.clientesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flatOnix3 = new OnixLibrary.CustomControls.FlatOnix();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoOnix)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(89, 6);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(397, 57);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Onix Centre Terapèutic";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Coral;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Location = new System.Drawing.Point(1184, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 66);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Coral;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimize.Location = new System.Drawing.Point(1091, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(94, 66);
            this.minimize.TabIndex = 4;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseEnter += new System.EventHandler(this.minimize_MouseEnter);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.logoOnix);
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 66);
            this.panel1.TabIndex = 5;
            // 
            // logoOnix
            // 
            this.logoOnix.BackColor = System.Drawing.Color.Transparent;
            this.logoOnix.Image = global::MainRoutinesProject.Properties.Resources.OnixLogo;
            this.logoOnix.Location = new System.Drawing.Point(10, 5);
            this.logoOnix.Name = "logoOnix";
            this.logoOnix.Size = new System.Drawing.Size(71, 55);
            this.logoOnix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoOnix.TabIndex = 0;
            this.logoOnix.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.rutinasButton);
            this.panel2.Controls.Add(this.clientesButton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.flatOnix3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 672);
            this.panel2.TabIndex = 6;
            // 
            // rutinasButton
            // 
            this.rutinasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rutinasButton.FlatAppearance.BorderSize = 0;
            this.rutinasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rutinasButton.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold);
            this.rutinasButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rutinasButton.Image = ((System.Drawing.Image)(resources.GetObject("rutinasButton.Image")));
            this.rutinasButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rutinasButton.Location = new System.Drawing.Point(23, 235);
            this.rutinasButton.Name = "rutinasButton";
            this.rutinasButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rutinasButton.Size = new System.Drawing.Size(258, 185);
            this.rutinasButton.TabIndex = 4;
            this.rutinasButton.Text = "RUTINAS";
            this.rutinasButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rutinasButton.UseVisualStyleBackColor = true;
            this.rutinasButton.Click += new System.EventHandler(this.rutinasButton_Click);
            // 
            // clientesButton
            // 
            this.clientesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clientesButton.FlatAppearance.BorderSize = 0;
            this.clientesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientesButton.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold);
            this.clientesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientesButton.Image = ((System.Drawing.Image)(resources.GetObject("clientesButton.Image")));
            this.clientesButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clientesButton.Location = new System.Drawing.Point(23, 15);
            this.clientesButton.Name = "clientesButton";
            this.clientesButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientesButton.Size = new System.Drawing.Size(258, 185);
            this.clientesButton.TabIndex = 0;
            this.clientesButton.Text = "CLIENTES";
            this.clientesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clientesButton.UseVisualStyleBackColor = true;
            this.clientesButton.Click += new System.EventHandler(this.clientesButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Importar datos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flatOnix3
            // 
            this.flatOnix3.BackColor = System.Drawing.Color.Coral;
            this.flatOnix3.Imagen = null;
            this.flatOnix3.Location = new System.Drawing.Point(39, 426);
            this.flatOnix3.Name = "flatOnix3";
            this.flatOnix3.Size = new System.Drawing.Size(242, 165);
            this.flatOnix3.TabIndex = 2;
            this.flatOnix3.Texto = "HORARIOS";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(318, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 672);
            this.panel3.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1278, 738);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoOnix)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoOnix;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private OnixLibrary.CustomControls.FlatOnix flatOnix3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clientesButton;
        private System.Windows.Forms.Button rutinasButton;
    }
}

