﻿using OnixLibrary;
using OnixModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onix.Screens.Manteniments
{
    public partial class MusculosMantenimiento : Form
    {
        public MusculosMantenimiento()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        private void MusculosMantenimiento_Load(object sender, EventArgs e)
        {
            FillDataGridView();

        }

        private void FillDataGridView()
        {
            var grupos = OnixConnection.GetAllGruposMusculares();
            var lista = new BindingSource(grupos, null);
            dataGridView1.DataSource = lista;
            dataGridView1.Rows[0].Selected = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    OnixConnection.InsertarGrupoMuscular(new GrupoMuscular()
                    {
                        Nombre = textBox1.Text
                    });
                    FillDataGridView();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Debes rellenar los campos de texto");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo insertar el musculo");

            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    OnixConnection.DeleteGrupoMuscular(new GrupoMuscular()
                    {
                        IdGrupoMuscular = Id,
                        Nombre = textBox1.Text
                    });
                    FillDataGridView();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila de la tabla");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el musculo");

            }
        }
    }
}
