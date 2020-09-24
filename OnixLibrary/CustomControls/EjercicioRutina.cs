using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using OnixModels.Models;
using System.ComponentModel;
using System.Linq;

namespace OnixLibrary.CustomControls
{
    public partial class EjercicioRutina : UserControl, INotifyPropertyChanged
    {

        public EjercicioRutina()
        {
            InitializeComponent();
        }

        private List<GrupoMuscular> _gruposMuscularesList = new List<GrupoMuscular>();
        private List<Ejercicio> _ejerciciosList = new List<Ejercicio>();
        private int _IdgrupoSeleccionado;
        private int _IdejercicioSeleccionado;
        private string _dia;
        private int _series;
        private string _reps;
        private List<Descanso> _descansosList = new List<Descanso>();
        private List<Comentario> _comentariosList = new List<Comentario>();
        private bool _pendienteEliminar;

        #region properties
        public bool IsElimianar
        {
            get { return _pendienteEliminar; }
            set { _pendienteEliminar = value; }
        }


        public List<GrupoMuscular> GruposMusculares {
            get { return _gruposMuscularesList; }
            set { _gruposMuscularesList = value ; } 
        }

        public List<Ejercicio> Ejercicios {
            get { return _ejerciciosList; }
            set {_ejerciciosList = value; }
        }

        private string _ejercicioSeleccionado;

        public string Ejercicio
        {
            get { return _ejercicioSeleccionado; }
            set { _ejercicioSeleccionado = value; }
        }

        private string _musculoSeleccionado;

        public string Musculo
        {
            get { return _musculoSeleccionado; }
            set { _musculoSeleccionado = value; }
        }



        public int IdGrupoSeleccionado
        {
            get { return _IdgrupoSeleccionado; }
            set {
                _IdgrupoSeleccionado = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("IdGrupoSeleccionado"));
            }
        }



        public int IdEjercicioSeleccionado
        {
            get { return _IdejercicioSeleccionado; }
            set {
                _IdejercicioSeleccionado = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("IdEjercicioSeleccionado"));
            }
        }

        public string Dia
        {
            get { return _dia; }
            set {   
                  _dia = value;
                  InvokePropertyChanged(new PropertyChangedEventArgs("Dia"));    
            }
        }

        public int Series
        {
            get { return _series; }
            set {
                _series = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Series"));

            }
        }

        public string Repeticiones
        {
            get { return _reps; }
            set { 
                _reps = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Repeticiones"));

            }
        }


        private int _idDescanso;

        public int IdDescanso
        {
            get { return _idDescanso; }
            set { _idDescanso = value; }
        }

        public List<Descanso> Descansos
        {
            get { return _descansosList; }
            set { _descansosList = value; }
        }


        private int _idComentario;

        public int IdComentario
        {
            get { return _idComentario; }
            set { _idComentario = value; }
        }

        public List<Comentario> Comentarios
        {
            get { return _comentariosList; }
            set { _comentariosList = value; }
        }

        private string _comentario;

        public string Comentario
        {
            get { return _comentario; }
            set { _comentario = value; }
        }

        private string _descanso;

        public string Descanso
        {
            get { return _descanso; }
            set { _descanso = value; }
        }



        private string _imagePath;

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BindGruposMusuclaesList();
            //BindDescansos();
            //BindComentarios();
            ImagePath = "";

            diaTB.DataBindings.Add("Text", this, "Dia");
            SerTB.DataBindings.Add("Text", this, "Series");
            RepsTB.DataBindings.Add("Text", this, "Repeticiones");     

        }

        private void BindGruposMusuclaesList()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _gruposMuscularesList;
            grupoCombo.DataSource = bs.DataSource;
            grupoCombo.DisplayMember = "Nombre";
            grupoCombo.ValueMember = "IdGrupoMuscular";
        }

        private void BindDescansos()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _descansosList;
            descansoCombo.DataSource = bs.DataSource;
            descansoCombo.DisplayMember = "TiempoDescanso";
            descansoCombo.ValueMember = "IdDescanso";
        }
        private void BindComentarios()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _comentariosList;
            notasCombo.DataSource = bs.DataSource;
            notasCombo.DisplayMember = "TipoComentario";
            notasCombo.ValueMember = "IdComentario";
        }

      
        private void EjercicioRutina_Load(object sender, EventArgs e)
        {
            GruposMusculares = OnixConnection.GetAllGruposMusculares();
            Musculo = GruposMusculares.FirstOrDefault().Nombre;
            foreach (var item in GruposMusculares)
            {
                grupoCombo.Items.Add(item.Nombre); //AÑADIMOS LOS VALORES AL COMBO
            }
            CargarDescansos();
            CargarComentarios();
   
        }

        private void CargarDescansos()
        {
            Descansos = OnixConnection.GetAllDescanansos();

            foreach (var item in Descansos)
            {
                descansoCombo.Items.Add(item.TiempoDescanso);
            }
            IdDescanso = Descansos[0].IdDescanso;
           // Descanso = Descansos.Select(x => x.TiempoDescanso).FirstOrDefault();

        }

        private void CargarComentarios()
        {
            Comentarios = OnixConnection.GetAllComentarios();

            foreach (var item in Comentarios)
            {
                notasCombo.Items.Add(item.TipoComentario);
            }
            IdComentario = Comentarios[0].IdComentario;
            //Comentario = Comentarios.Select(x => x.TipoComentario).FirstOrDefault();

        }

        private void grupoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ejercicoCombo.Items.Clear();
            ejercicoCombo.Text = "";
            Musculo = GruposMusculares[grupoCombo.SelectedIndex].Nombre;
            int idGrupo = GruposMusculares[grupoCombo.SelectedIndex].IdGrupoMuscular;

            _ejerciciosList = OnixConnection.GetExercicesByGroupId(idGrupo);

            if (_ejerciciosList.Count > 0)
            {
                ejercicoCombo.Enabled = true;
                foreach (var item in _ejerciciosList)
                {
                    ejercicoCombo.Items.Add(item.Nombre);
                }
                IdGrupoSeleccionado = GruposMusculares[grupoCombo.SelectedIndex].IdGrupoMuscular;
                Ejercicio = Ejercicios.Select(x => x.Nombre).FirstOrDefault();
                //ejercicoCombo.SelectedIndex = 0;
            }



        }

        private void ejercicoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Ejercicios_Fotos");

            foreach (string file in Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".jpg") || s.EndsWith(".JPG")))
            {
                string[] elements = file.Split('\\');
                string nameEjercicio = elements[elements.Length-1];
                elements = nameEjercicio.Split('.');
                nameEjercicio = elements[0];
                nameEjercicio = nameEjercicio.Trim().Replace(' ', '_');

                if (ejercicoCombo.SelectedItem.ToString().Equals(nameEjercicio))
                {
                    imagenRutina.Image = Image.FromFile(file);
                    ImagePath = file;
                    break;
                }
                else
                {
                    imagenRutina.Image = null;
                    ImagePath = "";
                }

            }

            Ejercicio = ejercicoCombo.SelectedItem.ToString().Replace('_',' ');
            IdEjercicioSeleccionado = Ejercicios[ejercicoCombo.SelectedIndex].IdEjercicio;


        }

        private void notasCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdComentario = Comentarios[notasCombo.SelectedIndex].IdComentario;
            Comentario = Comentarios[notasCombo.SelectedIndex].TipoComentario;

        }

        private void descansoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdDescanso = Descansos[descansoCombo.SelectedIndex].IdDescanso;
            Descanso = Descansos[descansoCombo.SelectedIndex].TiempoDescanso;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!IsElimianar) {
                IsElimianar = true;
                CambiarEstadoControles(false);
            }
            else
            {
                IsElimianar = false;
                CambiarEstadoControles(true);
            }

        }

        private void CambiarEstadoControles(bool estado)
        {

            foreach (Control item in this.Controls)
            {
                if (!(item is PictureBox))
                {
                    item.Enabled = estado;

                }
            }
        }

        private void borrar_MouseHover(object sender, EventArgs e)
        {
            borrar.BackColor = Color.Gray;
        }

        private void borrar_MouseLeave(object sender, EventArgs e)
        {
            borrar.BackColor = Color.Transparent;
        }

        private void cargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imagenRutina.Image = new Bitmap(dlg.FileName);
                    ImagePath = dlg.FileName;
                }
            }
        }
    }
}
