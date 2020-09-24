using OnixLibrary;
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
    public partial class DescansosMantenimiento : Form
    {
        public DescansosMantenimiento()
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
            var grupos = OnixConnection.GetAllDescanansos();
            var lista = new BindingSource(grupos, null);
            dataGridView1.DataSource = lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    OnixConnection.InsetarDescanso(new Descanso()
                    {
                        TiempoDescanso = textBox1.Text,
                    });
                    FillDataGridView();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingresa un desanso en el campo de texto.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo insertar el descanso");

            }


        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    OnixConnection.DeleteDescanso(new Descanso()
                    {
                        IdDescanso = Id,
                        TiempoDescanso = textBox1.Text.Trim()

                    });

                    FillDataGridView();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo eliminar el descanso");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDatos();
        }
        private void GetDatos()
        {
            try
            {
                Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetDatos();
        }
    }
}
