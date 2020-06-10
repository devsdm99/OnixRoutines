using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using OnixLibrary.BBDD;
using System.Reflection;
using System.IO;
using OnixModels.Models;

namespace OnixLibrary.CustomControls
{
    public partial class EjercicioRutina : UserControl
    {


        private List<GrupoMuscular> _gruposMuscularesList = new List<GrupoMuscular>();
        private List<Ejercicio> _ejerciciosList = new List<Ejercicio>();
        private string _grupoSeleccionado;
        private string _ejercicioSeleccionado;
        private string _dia;
        private int _series;
        private int _reps;
        private List<Descanso> _descansosList = new List<Descanso>();
        private List<Comentario> _notasList = new List<Comentario>();


        private EjerciciosRutinaController controlador;

        public List<GrupoMuscular> GruposMusculares {
            get { return _gruposMuscularesList; }
            set { _gruposMuscularesList = value ; } 
        }

        public List<Ejercicio> Ejercicios {
            get { return _ejerciciosList; }
            set {_ejerciciosList = value; }
        }


        public string GrupoSeleccionado
        {
            get { return _grupoSeleccionado; }
            set { _grupoSeleccionado = value; }
        }



        public string EjercicioSeleccionado
        {
            get { return _ejercicioSeleccionado; }
            set { _ejercicioSeleccionado = value; }
        }

        public string Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        public int Series
        {
            get { return _series; }
            set { _series = value; }
        }

        public int Repeticiones
        {
            get { return _reps; }
            set { _reps = value; }
        }


        private Image image;

        public Image Imagen
        {
            get { return image; }
            set { image = value; }
        }




        public List<Descanso> Descansos
        {
            get { return _descansosList; }
            set { _descansosList = value; }
        }



        public List<Comentario> Notas
        {
            get { return _notasList; }
            set { _notasList = value; }
        }

        public EjercicioRutina()
        {
            InitializeComponent();
        }


        private EjerciciosRutinaController GetControlador()
        {
            if (controlador == null)
            {
                controlador = new EjerciciosRutinaController();
            }
            return controlador;
        }
        private void EjercicioRutina_Load(object sender, EventArgs e)
        {
            _gruposMuscularesList = GetControlador().GetGruposController().GetAllGruposMusculaes();

            foreach (var item in _gruposMuscularesList)
            {
                grupoCombo.Items.Add(item.Nombre); //AÑADIMOS LOS VALORES AL COMBO
            }
            CargarDescansos();
            CargarComentarios();
   
        }

        private void CargarDescansos()
        {
            _descansosList = GetControlador().GetAllDescansos();
            foreach (var item in _descansosList)
            {
                descansoCombo.Items.Add(item.TiempoDescanso);
            }
        }

        private void CargarComentarios()
        {
            _notasList = GetControlador().GetComentarios();

            foreach (var item in _notasList)
            {
                notasCombo.Items.Add(item.TipoComentario);
            }
        }

        private void grupoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idGrupo = GruposMusculares[grupoCombo.SelectedIndex].IdGrupoMuscular;

            _ejerciciosList = GetControlador().GetEjerciciosController().GetExercicesByGroupId(idGrupo);

            if (_ejerciciosList.Count > 0)
            {
                ejercicoCombo.Enabled = true;
                foreach (var item in _ejerciciosList)
                {
                    ejercicoCombo.Items.Add(item.Nombre);
                }
            }

            _grupoSeleccionado = grupoCombo.SelectedItem.ToString();


        }

        private void ejercicoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ejercicios_Fotos");
            foreach (string file in Directory.GetFiles(path, "*.jpg"))
            {
                string[] elements = file.Split('\\');
                string nameEjercicio = elements[elements.Length-1];
                elements = nameEjercicio.Split('.');
                nameEjercicio = elements[0];
                nameEjercicio = nameEjercicio.Trim().Replace(' ', '_');
                if (ejercicoCombo.SelectedItem.ToString().Equals(nameEjercicio))
                {
                    imagenRutina.Image = Image.FromFile(file);
                }
               
            }
            _ejercicioSeleccionado = ejercicoCombo.SelectedItem.ToString();
        }
    }
}
