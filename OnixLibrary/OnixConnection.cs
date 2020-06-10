

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnixLibrary
{


   public static class OnixConnection
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# Project\OnixRoutines\OnixLibrary\BBDD\OnixDB.mdf;Integrated Security=True;Connect Timeout=30";
        private static SqlConnection connection;
        private static DataSet localTable;

        private static void OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static DataSet GetTableData(string tablename)
        {

            OpenConnection();
            string queryString = "SELECT * FROM " + tablename;
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, connectionString);
            connection.Close();
            localTable = new DataSet();
            adapter.Fill(localTable, tablename);

            return localTable;
        }


        public static void InsertaDatos()
        {

            OpenConnection();
            SqlCommand comando = connection.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into ";
        }


        public static void Inserta(string con)
        {
            OpenConnection();
            SqlCommand query = connection.CreateCommand();
            query.CommandType = CommandType.Text;
            query.CommandText = con;

            int fila = query.ExecuteNonQuery();

            connection.Close();
        }

    }
}
