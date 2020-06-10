namespace OnixLibrary.CustomControls
{
    partial class FlatOnix
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
            this.labelmenu = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmenu
            // 
            this.labelmenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelmenu.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmenu.ForeColor = System.Drawing.Color.White;
            this.labelmenu.Location = new System.Drawing.Point(39, 104);
            this.labelmenu.Name = "labelmenu";
            this.labelmenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelmenu.Size = new System.Drawing.Size(163, 41);
            this.labelmenu.TabIndex = 1;
            this.labelmenu.Text = "CLIENTES";
            this.labelmenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelmenu.Click += new System.EventHandler(this.labelmenu_Click);
            this.labelmenu.MouseEnter += new System.EventHandler(this.labelmenu_MouseEnter);
            this.labelmenu.MouseLeave += new System.EventHandler(this.labelmenu_MouseLeave);
            // 
            // foto
            // 
            this.foto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.foto.Location = new System.Drawing.Point(75, 12);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(90, 80);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            this.foto.Click += new System.EventHandler(this.foto_Click);
            this.foto.MouseEnter += new System.EventHandler(this.foto_MouseEnter);
            this.foto.MouseLeave += new System.EventHandler(this.foto_MouseLeave);
            // 
            // FlatOnix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.foto);
            this.Controls.Add(this.labelmenu);
            this.Name = "FlatOnix";
            this.Size = new System.Drawing.Size(242, 157);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Label labelmenu;
    }
}
