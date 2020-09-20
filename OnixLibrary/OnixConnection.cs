using Dapper;
using OnixModels.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace OnixLibrary
{

    public static class OnixConnection
    {
        #region Gets
        public static List<Ejercicio> ObtenerEjercicios()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Ejercicio>("Select * from Ejercicios", new DynamicParameters());
                return output.ToList();
            }

        }
        public static List<Comentario> GetAllComentarios()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Comentario>("Select * from Comentarios", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Descanso> GetAllDescanansos()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Descanso>("Select * from Descansos", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<GrupoMuscular> GetAllGruposMusculares()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<GrupoMuscular>("Select * from GruposMusculares", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Ejercicio> GetExercicesByGroupId(int idGrupo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Ejercicio>("Select * from Ejercicios where IdGrupoMuscular = " + idGrupo, new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Ejercicio> GetAllEjercicios()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Ejercicio>("Select * from Ejercicios", new DynamicParameters());
                return output.ToList();
            }
        }

        #endregion


        #region Inserts
        public static void InsertaEjercicio(Ejercicio ej)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Ejercicios (Nombre, IdGrupoMuscular) values (@Nombre, @IdGrupoMuscular)", ej);
            }
        }
        public static void InsertarGrupoMuscular(GrupoMuscular ej)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into GruposMusculares (Nombre) values (@Nombre)", ej);
            }
        }
        #endregion


        #region Deletes

        public static void DeleteGrupoMuscular(GrupoMuscular ej)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from GruposMusculares where IdGrupoMuscular = (@IdGrupoMuscular) And Nombre = (@Nombre)", ej);
            }
        }

        public static void DeleteEjercicio(Ejercicio ej)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Ejercicios where IdEjercicio = (@IdEjercicio) And Nombre = (@Nombre) And IdGrupoMuscular = (@IdGrupoMuscular)", ej);
            }
        }

        #endregion



        #region Updates

        #endregion

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

     

      
    }
}
