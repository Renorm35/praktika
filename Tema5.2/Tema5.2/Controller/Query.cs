using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Threading;

namespace Tema5._2.Controller
{
    class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public DataTable UpdateInfo()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Films", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void Add(string Nazva_Filmu, string Zhanr, int Cina_za_odunucyu)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Films(Nazva_Filmu,Zhanr,Cina_za_odunucyu) VALUES(@Nazva_Filmu,@Zhanr,Cina_za_odunucyu)", connection);
            command.Parameters.AddWithValue("Nazva_Filmu", Nazva_Filmu);
            command.Parameters.AddWithValue("Zhanr", Zhanr);
            command.Parameters.AddWithValue("Cina_za_odunucyu", Cina_za_odunucyu);
           
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int Kod_Filmu)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Films WHERE Kod_Filmu = {Kod_Filmu}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
