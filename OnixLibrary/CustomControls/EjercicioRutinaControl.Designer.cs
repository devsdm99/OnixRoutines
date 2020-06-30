namespace OnixLibrary.CustomControls
{
    partial class EjercicioRutinaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjercicioRutinaControl));
            this.diaLabel = new System.Windows.Forms.Label();
            this.diaTB = new System.Windows.Forms.TextBox();
            this.SerTB = new System.Windows.Forms.TextBox();
            this.SerieLabel = new System.Windows.Forms.Label();
            this.RepsTB = new System.Windows.Forms.TextBox();
            this.RepLabel = new System.Windows.Forms.Label();
            this.imagenRutina = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grupoCombo = new System.Windows.Forms.ComboBox();
            this.ejercicoCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descansoCombo = new System.Windows.Forms.ComboBox();
            this.notasCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagenRutina)).BeginInit();
            this.SuspendLayout();
            // 
            // diaLabel
            // 
            this.diaLabel.AutoSize = true;
            this.diaLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.diaLabel.Location = new System.Drawing.Point(15, 85);
            this.diaLabel.Name = "diaLabel";
            this.diaLabel.Size = new System.Drawing.Size(37, 22);
            this.diaLabel.TabIndex = 0;
            this.diaLabel.Text = "Dia";
            // 
            // diaTB
            // 
            this.diaTB.Location = new System.Drawing.Point(58, 85);
            this.diaTB.Name = "diaTB";
            this.diaTB.Size = new System.Drawing.Size(58, 20);
            this.diaTB.TabIndex = 1;
            // 
            // SerTB
            // 
            this.SerTB.Location = new System.Drawing.Point(57, 117);
            this.SerTB.Name = "SerTB";
            this.SerTB.Size = new System.Drawing.Size(58, 20);
            this.SerTB.TabIndex = 3;
            // 
            // SerieLabel
            // 
            this.SerieLabel.AutoSize = true;
            this.SerieLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerieLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SerieLabel.Location = new System.Drawing.Point(15, 117);
            this.SerieLabel.Name = "SerieLabel";
            this.SerieLabel.Size = new System.Drawing.Size(36, 22);
            this.SerieLabel.TabIndex = 2;
            this.SerieLabel.Text = "Ser";
            // 
            // RepsTB
            // 
            this.RepsTB.Location = new System.Drawing.Point(168, 120);
            this.RepsTB.Name = "RepsTB";
            this.RepsTB.Size = new System.Drawing.Size(53, 20);
            this.RepsTB.TabIndex = 5;
            // 
            // RepLabel
            // 
            this.RepLabel.AutoSize = true;
            this.RepLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RepLabel.Location = new System.Drawing.Point(121, 117);
            this.RepLabel.Name = "RepLabel";
            this.RepLabel.Size = new System.Drawing.Size(41, 22);
            this.RepLabel.TabIndex = 4;
            this.RepLabel.Text = "Rep";
            // 
            // imagenRutina
            // 
            this.imagenRutina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenRutina.Location = new System.Drawing.Point(19, 174);
            this.imagenRutina.Name = "imagenRutina";
            this.imagenRutina.Size = new System.Drawing.Size(230, 150);
            this.imagenRutina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenRutina.TabIndex = 6;
            this.imagenRutina.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grupo Muscular";
            // 
            // grupoCombo
            // 
            this.grupoCombo.FormattingEnabled = true;
            this.grupoCombo.Location = new System.Drawing.Point(167, 18);
            this.grupoCombo.Name = "grupoCombo";
            this.grupoCombo.Size = new System.Drawing.Size(82, 21);
            this.grupoCombo.TabIndex = 8;
            this.grupoCombo.SelectedIndexChanged += new System.EventHandler(this.grupoCombo_SelectedIndexChanged);
            // 
            // ejercicoCombo
            // 
            this.ejercicoCombo.Enabled = false;
            this.ejercicoCombo.FormattingEnabled = true;
            this.ejercicoCombo.Location = new System.Drawing.Point(19, 55);
            this.ejercicoCombo.Name = "ejercicoCombo";
            this.ejercicoCombo.Size = new System.Drawing.Size(230, 21);
            this.ejercicoCombo.TabIndex = 9;
            this.ejercicoCombo.SelectedIndexChanged += new System.EventHandler(this.ejercicoCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(16, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descanso";
            // 
            // descansoCombo
            // 
            this.descansoCombo.FormattingEnabled = true;
            this.descansoCombo.Location = new System.Drawing.Point(108, 341);
            this.descansoCombo.Name = "descansoCombo";
            this.descansoCombo.Size = new System.Drawing.Size(141, 21);
            this.descansoCombo.TabIndex = 11;
            // 
            // notasCombo
            // 
            this.notasCombo.FormattingEnabled = true;
            this.notasCombo.Location = new System.Drawing.Point(19, 400);
            this.notasCombo.Name = "notasCombo";
            this.notasCombo.Size = new System.Drawing.Size(230, 21);
            this.notasCombo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(16, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Notas";
            // 
            // listaImagenes
            // 
            this.listaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenes.ImageStream")));
            this.listaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenes.Images.SetKeyName(0, "Dominadas agarre en V.jpg");
            this.listaImagenes.Images.SetKeyName(1, "Dominadas agarre supino.jpg");
            this.listaImagenes.Images.SetKeyName(2, "Dominadas alterno manos juntas.jpg");
            this.listaImagenes.Images.SetKeyName(3, "Dominadas con cuerda manos juntas.jpg");
            this.listaImagenes.Images.SetKeyName(4, "Dominadas con lastre.jpg");
            this.listaImagenes.Images.SetKeyName(5, "Dominadas en máquina asistida.jpg");
            this.listaImagenes.Images.SetKeyName(6, "Dominadas.jpg");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // EjercicioRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notasCombo);
            this.Controls.Add(this.descansoCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ejercicoCombo);
            this.Controls.Add(this.grupoCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagenRutina);
            this.Controls.Add(this.RepsTB);
            this.Controls.Add(this.RepLabel);
            this.Controls.Add(this.SerTB);
            this.Controls.Add(this.SerieLabel);
            this.Controls.Add(this.diaTB);
            this.Controls.Add(this.diaLabel);
            this.Name = "EjercicioRutina";
            this.Size = new System.Drawing.Size(266, 441);
            this.Load += new System.EventHandler(this.EjercicioRutina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenRutina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diaLabel;
        private System.Windows.Forms.TextBox diaTB;
        private System.Windows.Forms.TextBox SerTB;
        private System.Windows.Forms.Label SerieLabel;
        private System.Windows.Forms.TextBox RepsTB;
        private System.Windows.Forms.Label RepLabel;
        private System.Windows.Forms.PictureBox imagenRutina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox grupoCombo;
        private System.Windows.Forms.ComboBox ejercicoCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox descansoCombo;
        private System.Windows.Forms.ComboBox notasCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList listaImagenes;
        private System.Windows.Forms.ImageList imageList1;
    }
}
