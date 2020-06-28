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
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.finalizarButton = new System.Windows.Forms.Button();
            this.añadirButton = new System.Windows.Forms.Button();
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
            this.NombreLabel.Location = new System.Drawing.Point(29, 45);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(167, 25);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre rutina:";
            // 
            // NombreTB
            // 
            this.NombreTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreTB.Location = new System.Drawing.Point(202, 47);
            this.NombreTB.Multiline = true;
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(152, 23);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.finalizarButton);
            this.panel2.Controls.Add(this.añadirButton);
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
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1326, 504);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::MainRoutinesProject.Properties.Resources.mas_128px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(34, 19);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(258, 185);
            this.button2.TabIndex = 7;
            this.button2.Text = "VER DETALLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // finalizarButton
            // 
            this.finalizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finalizarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.finalizarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.finalizarButton.FlatAppearance.BorderSize = 2;
            this.finalizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizarButton.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold);
            this.finalizarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finalizarButton.Image = global::MainRoutinesProject.Properties.Resources.finish;
            this.finalizarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.finalizarButton.Location = new System.Drawing.Point(691, 19);
            this.finalizarButton.Name = "finalizarButton";
            this.finalizarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.finalizarButton.Size = new System.Drawing.Size(258, 185);
            this.finalizarButton.TabIndex = 6;
            this.finalizarButton.Text = "FINALIZAR";
            this.finalizarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.finalizarButton.UseVisualStyleBackColor = true;
            this.finalizarButton.Click += new System.EventHandler(this.finalizarButton_Click);
            // 
            // añadirButton
            // 
            this.añadirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.añadirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.añadirButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.añadirButton.FlatAppearance.BorderSize = 2;
            this.añadirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadirButton.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold);
            this.añadirButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.añadirButton.Image = global::MainRoutinesProject.Properties.Resources.mas_128px;
            this.añadirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.añadirButton.Location = new System.Drawing.Point(1008, 19);
            this.añadirButton.Name = "añadirButton";
            this.añadirButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.añadirButton.Size = new System.Drawing.Size(258, 185);
            this.añadirButton.TabIndex = 5;
            this.añadirButton.Text = "RUTINAS";
            this.añadirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.añadirButton.UseVisualStyleBackColor = true;
            this.añadirButton.Click += new System.EventHandler(this.newRutina_Click);
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
        private System.Windows.Forms.Button añadirButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button finalizarButton;
    }
}