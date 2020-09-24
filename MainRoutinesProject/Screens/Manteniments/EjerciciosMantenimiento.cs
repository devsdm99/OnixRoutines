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
    public partial class EjerciciosMantenimiento : Form
    {
        public EjerciciosMantenimiento()
        {
            InitializeComponent();
        }

        private List<GrupoMuscular> GrupoMusculars;

        public List<GrupoMuscular> GruposMusculares
        {
            get { return GrupoMusculars; }
            set { GrupoMusculars = value; }
        }

        public int IdMusculo { get; set; }
        public int Id { get; set; }

        private void EjerciciosMantenimiento_Load(object sender, EventArgs e)
        {
            FillDataGridView();


            GruposMusculares = OnixConnection.GetAllGruposMusculares();

            foreach (var item in GruposMusculares)
            {
                itemsCombo1.Items.Add(item.Nombre);
            }

            itemsCombo1.SelectedIndex = 0;

        }



        private void FillDataGridView()
        {
            var ejercicios = OnixConnection.GetAllEjercicios();
            var lista = new BindingSource(ejercicios, null);
            dataGridView1.DataSource = lista;

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    OnixConnection.InsertaEjercicio(new Ejercicio()
                    {
                        IdEjercicio = Id,
                        Nombre = textBox1.Text,
                        IdGrupoMuscular = IdMusculo
                    });
                    itemsCombo1.SelectedIndex = 0;
                    textBox1.Text = "";
                    FillDataGridView();
                }
                else
                {
                    MessageBox.Show("Inserta un nombre de ejercicio");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo insertar el ejercicio");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDatos();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    OnixConnection.DeleteEjercicio(new Ejercicio()
                    {
                        IdEjercicio = Id,
                        Nombre = textBox1.Text,
                        IdGrupoMuscular = IdMusculo
                    });
                    textBox1.Text = "";
                    FillDataGridView();
                }
                else {
                    MessageBox.Show("Deber seleccionar alguna fila de la tabla.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar el ejercicio");
            }
        }

        private void itemsCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdMusculo = GruposMusculares[itemsCombo1.SelectedIndex].IdGrupoMuscular;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetDatos();
        }
        private void GetDatos()
        {
            try
            {
                Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
