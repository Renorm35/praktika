using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Tema5._2.Controller
{
    class Query2
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Query2(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public DataTable UpdateInfo()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Result", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void Add(int Shop, string Film, int Kilkist_Prodazh)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Result(Shop,Film,Kilkist_Prodazh) VALUES(Shop,@Film,Kilkist_Prodazh)", connection);
            command.Parameters.AddWithValue("Shop", Shop);
            command.Parameters.AddWithValue("Film", Film);
            command.Parameters.AddWithValue("Cina_za_odunucyu", Kilkist_Prodazh);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int Kod)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Films WHERE Kod = {Kod}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
