namespace MainRoutinesProject.Screens
{
    partial class NuevaRutinaScreen
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
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaTB = new System.Windows.Forms.TextBox();
            this.ControlTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RutinaNumTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newRutina = new OnixLibrary.CustomControls.FlatOnix();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NombreLabel.Location = new System.Drawing.Point(61, 45);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(100, 25);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre:";
            // 
            // NombreTB
            // 
            this.NombreTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreTB.Location = new System.Drawing.Point(166, 47);
            this.NombreTB.Multiline = true;
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(188, 23);
            this.NombreTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(382, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Inicio:";
            // 
            // FechaTB
            // 
            this.FechaTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FechaTB.Location = new System.Drawing.Point(535, 47);
            this.FechaTB.Multiline = true;
            this.FechaTB.Name = "FechaTB";
            this.FechaTB.Size = new System.Drawing.Size(108, 23);
            this.FechaTB.TabIndex = 5;
            // 
            // ControlTB
            // 
            this.ControlTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlTB.Location = new System.Drawing.Point(841, 45);
            this.ControlTB.Multiline = true;
            this.ControlTB.Name = "ControlTB";
            this.ControlTB.Size = new System.Drawing.Size(108, 23);
            this.ControlTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(661, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proxim Control:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(971, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nº Rutina";
            // 
            // RutinaNumTB
            // 
            this.RutinaNumTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RutinaNumTB.Location = new System.Drawing.Point(1089, 47);
            this.RutinaNumTB.Multiline = true;
            this.RutinaNumTB.Name = "RutinaNumTB";
            this.RutinaNumTB.Size = new System.Drawing.Size(46, 23);
            this.RutinaNumTB.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FechaTB);
            this.panel1.Controls.Add(this.NombreLabel);
            this.panel1.Controls.Add(this.RutinaNumTB);
            this.panel1.Controls.Add(this.NombreTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ControlTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 94);
            this.panel1.TabIndex = 10;
            // 
            // newRutina
            // 
            this.newRutina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newRutina.BackColor = System.Drawing.Color.Coral;
            this.newRutina.Imagen = global::MainRoutinesProject.Properties.Resources.mas;
            this.newRutina.Location = new System.Drawing.Point(1005, 28);
            this.newRutina.Name = "newRutina";
            this.newRutina.Size = new System.Drawing.Size(241, 163);
            this.newRutina.TabIndex = 0;
            this.newRutina.Texto = "Añadir";
            this.newRutina.Click += new System.EventHandler(this.flatOnix1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newRutina);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 225);
            this.panel2.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1326, 504);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // NuevaRutinaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1326, 823);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaRutinaScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaRutina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OnixLibrary.CustomControls.FlatOnix newRutina;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FechaTB;
        private System.Windows.Forms.TextBox ControlTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RutinaNumTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}