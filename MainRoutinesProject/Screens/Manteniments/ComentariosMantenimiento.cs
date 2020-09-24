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
    public partial class ComentariosMantenimiento : Form
    {
        public ComentariosMantenimiento()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        private void MusculosMantenimiento_Load(object sender, EventArgs e)
        {

            var grupos = OnixConnection.GetAllComentarios();
            var lista = new BindingSource(grupos,null);
            dataGridView1.DataSource = lista;
            dataGridView1.Rows[0].Selected = true;

        }

        private void FillDataGridView()
        {
            var grupos = OnixConnection.GetAllComentarios();
            var lista = new BindingSource(grupos, null);
            dataGridView1.DataSource = lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    OnixConnection.InsertarComentario(new Comentario()
                    {
                        TipoComentario = textBox1.Text
                    });
                    FillDataGridView();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Inserta un comentario en la caja de texto.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo insertar el comentario");
            }


        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    OnixConnection.DeleteComentario(new Comentario()
                    {
                        IdComentario = Id,
                        TipoComentario = textBox1.Text

                    });

                    FillDataGridView();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Antes debes seleccionar una fila.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar el comentario");
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
