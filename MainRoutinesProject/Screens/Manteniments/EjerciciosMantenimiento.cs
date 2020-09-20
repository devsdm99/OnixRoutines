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
            var grupos = OnixConnection.GetAllGruposMusculares();
            var lista = new BindingSource(grupos,null);
            dataGridView1.DataSource = lista;

            GruposMusculares = OnixConnection.GetAllGruposMusculares();

            foreach (var item in GruposMusculares)
            {
                itemsCombo1.Items.Add(item.Nombre);
            }

        }

        private void FillDataGridView()
        {
            var grupos = OnixConnection.GetAllGruposMusculares();
            var lista = new BindingSource(grupos, null);
            dataGridView1.DataSource = lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                OnixConnection.InsertaEjercicio(new Ejercicio()
                {
                   Nombre = textBox1.Text

                });
            }

            FillDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OnixConnection.DeleteEjercicio(new Ejercicio()
                {
                    IdEjercicio = Id,
                    Nombre = textBox1.Text
                });

                FillDataGridView();

            }catch(Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar el ejercicio");
            }
        }

        private void itemsCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdMusculo = GruposMusculares[itemsCombo1.SelectedIndex].IdGrupoMuscular;
        }
    }
}
