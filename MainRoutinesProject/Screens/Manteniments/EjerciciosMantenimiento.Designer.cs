namespace Onix.Screens.Manteniments
{
    partial class EjerciciosMantenimiento
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
            this.EditarButton = new System.Windows.Forms.Button();
            this.ElimianrButton = new System.Windows.Forms.Button();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemsCombo1 = new OnixLibrary.CustomControls.ItemsCombo();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditarButton
            // 
            this.EditarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarButton.Location = new System.Drawing.Point(836, 627);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(227, 107);
            this.EditarButton.TabIndex = 2;
            this.EditarButton.Text = "Editar";
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Visible = false;
            // 
            // ElimianrButton
            // 
            this.ElimianrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ElimianrButton.BackColor = System.Drawing.Color.Red;
            this.ElimianrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ElimianrButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElimianrButton.Location = new System.Drawing.Point(1097, 627);
            this.ElimianrButton.Name = "ElimianrButton";
            this.ElimianrButton.Size = new System.Drawing.Size(239, 107);
            this.ElimianrButton.TabIndex = 3;
            this.ElimianrButton.Text = "Eliminar";
            this.ElimianrButton.UseVisualStyleBackColor = false;
            this.ElimianrButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AñadirButton
            // 
            this.AñadirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AñadirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AñadirButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirButton.Location = new System.Drawing.Point(1097, 491);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(239, 107);
            this.AñadirButton.TabIndex = 4;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(965, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 43);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Ejercicio:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "GrupoMuscular:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 763);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // itemsCombo1
            // 
            this.itemsCombo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsCombo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsCombo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsCombo1.FormattingEnabled = true;
            this.itemsCombo1.Id = 0;
            this.itemsCombo1.Location = new System.Drawing.Point(965, 136);
            this.itemsCombo1.Name = "itemsCombo1";
            this.itemsCombo1.Size = new System.Drawing.Size(371, 32);
            this.itemsCombo1.TabIndex = 8;
            this.itemsCombo1.Texto = null;
            this.itemsCombo1.SelectedIndexChanged += new System.EventHandler(this.itemsCombo1_SelectedIndexChanged);
            // 
            // EjerciciosMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 763);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.itemsCombo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AñadirButton);
            this.Controls.Add(this.ElimianrButton);
            this.Controls.Add(this.EditarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EjerciciosMantenimiento";
            this.Text = "EjerciciosMantenimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EjerciciosMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button ElimianrButton;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private OnixLibrary.CustomControls.ItemsCombo itemsCombo1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}