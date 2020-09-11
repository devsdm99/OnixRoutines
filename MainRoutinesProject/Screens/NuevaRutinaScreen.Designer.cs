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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RutinaNumTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FechaFinTB = new System.Windows.Forms.DateTimePicker();
            this.FechaTB = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.ordenarbutton = new System.Windows.Forms.Button();
            this.finalizarButton = new System.Windows.Forms.Button();
            this.añadirButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NombreLabel.Location = new System.Drawing.Point(44, 39);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(219, 31);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre cliente:";
            // 
            // NombreTB
            // 
            this.NombreTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NombreTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NombreTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTB.Location = new System.Drawing.Point(269, 39);
            this.NombreTB.Multiline = true;
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(152, 31);
            this.NombreTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(447, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1053, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proxim Control:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1513, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nº Rutina:";
            // 
            // RutinaNumTB
            // 
            this.RutinaNumTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RutinaNumTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RutinaNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutinaNumTB.Location = new System.Drawing.Point(1679, 39);
            this.RutinaNumTB.Multiline = true;
            this.RutinaNumTB.Name = "RutinaNumTB";
            this.RutinaNumTB.Size = new System.Drawing.Size(77, 31);
            this.RutinaNumTB.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FechaFinTB);
            this.panel1.Controls.Add(this.FechaTB);
            this.panel1.Controls.Add(this.NombreLabel);
            this.panel1.Controls.Add(this.RutinaNumTB);
            this.panel1.Controls.Add(this.NombreTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1880, 110);
            this.panel1.TabIndex = 2;
            // 
            // FechaFinTB
            // 
            this.FechaFinTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaFinTB.CalendarForeColor = System.Drawing.Color.Coral;
            this.FechaFinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFinTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinTB.Location = new System.Drawing.Point(1290, 44);
            this.FechaFinTB.Name = "FechaFinTB";
            this.FechaFinTB.Size = new System.Drawing.Size(194, 26);
            this.FechaFinTB.TabIndex = 9;
            // 
            // FechaTB
            // 
            this.FechaTB.CalendarForeColor = System.Drawing.Color.Coral;
            this.FechaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaTB.Location = new System.Drawing.Point(635, 44);
            this.FechaTB.Name = "FechaTB";
            this.FechaTB.Size = new System.Drawing.Size(196, 26);
            this.FechaTB.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.eliminarbutton);
            this.panel2.Controls.Add(this.ordenarbutton);
            this.panel2.Controls.Add(this.finalizarButton);
            this.panel2.Controls.Add(this.añadirButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 835);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1880, 225);
            this.panel2.TabIndex = 11;
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eliminarbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eliminarbutton.FlatAppearance.BorderSize = 2;
            this.eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarbutton.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold);
            this.eliminarbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminarbutton.Image = global::MainRoutinesProject.Properties.Resources.dejar;
            this.eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eliminarbutton.Location = new System.Drawing.Point(1578, 19);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eliminarbutton.Size = new System.Drawing.Size(258, 185);
            this.eliminarbutton.TabIndex = 8;
            this.eliminarbutton.Text = "ELIMINAR";
            this.eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // ordenarbutton
            // 
            this.ordenarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ordenarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ordenarbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ordenarbutton.FlatAppearance.BorderSize = 2;
            this.ordenarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordenarbutton.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold);
            this.ordenarbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ordenarbutton.Image = global::MainRoutinesProject.Properties.Resources.lista;
            this.ordenarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ordenarbutton.Location = new System.Drawing.Point(34, 19);
            this.ordenarbutton.Name = "ordenarbutton";
            this.ordenarbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ordenarbutton.Size = new System.Drawing.Size(258, 185);
            this.ordenarbutton.TabIndex = 7;
            this.ordenarbutton.Text = "ORDENAR";
            this.ordenarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ordenarbutton.UseVisualStyleBackColor = true;
            this.ordenarbutton.Click += new System.EventHandler(this.OrdenarButton_Click);
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
            this.finalizarButton.Location = new System.Drawing.Point(1242, 19);
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
            this.añadirButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.añadirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.añadirButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.añadirButton.FlatAppearance.BorderSize = 2;
            this.añadirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadirButton.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold);
            this.añadirButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.añadirButton.Image = global::MainRoutinesProject.Properties.Resources.mas_128px;
            this.añadirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.añadirButton.Location = new System.Drawing.Point(339, 19);
            this.añadirButton.Name = "añadirButton";
            this.añadirButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.añadirButton.Size = new System.Drawing.Size(258, 185);
            this.añadirButton.TabIndex = 5;
            this.añadirButton.Text = "AÑADIR";
            this.añadirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.añadirButton.UseVisualStyleBackColor = true;
            this.añadirButton.Click += new System.EventHandler(this.newRutina_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 214);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1880, 621);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.closeButton);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1880, 104);
            this.panel3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(994, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "generarpdf test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(893, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "cargar datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(1664, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 104);
            this.button1.TabIndex = 3;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.Location = new System.Drawing.Point(1769, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 104);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainRoutinesProject.Properties.Resources.OnixLogo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(573, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = "Onix Centre Terapèutic";
            // 
            // NuevaRutinaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1880, 1060);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaRutinaScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaRutina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RutinaNumTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button añadirButton;
        private System.Windows.Forms.Button ordenarbutton;
        private System.Windows.Forms.Button finalizarButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.DateTimePicker FechaTB;
        private System.Windows.Forms.DateTimePicker FechaFinTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}