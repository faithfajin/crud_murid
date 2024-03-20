using Npgsql;
using System.Data;

namespace crud_murid.Helpers
{
    public class SqlDBHelper
    {
        private NpgsqlConnection connection;
        private string __constr;

        public SqlDBHelper(string pCOnstr)
        {
            __constr = pCOnstr;
            connection = new NpgsqlConnection();
            connection.ConnectionString = __constr;
        }

        public NpgsqlCommand GetNpgsqlCommand(string query)
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            return cmd;
        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}

// Ini buat databasenya kalau mau mencoba //

//CREATE TABLE murid (
//id_murid SERIAL PRIMARY KEY,
//nama VARCHAR(100),
//alamat VARCHAR(255),
//email VARCHAR(100)
//);

//INSERT INTO murid (nama, alamat, email) VALUES
//('Faith Reyhan', 'Mastrip', 'faithreyhan@gmail.com'),
//('Elian Waluyo', 'Kaliurang', 'elianwaluyo@gmail.com'),
//('Sehat Abadi', 'Sumbersari', 'sehatabadi@gmail.com');
