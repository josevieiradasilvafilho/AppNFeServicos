using System;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace App.DAL
{
    public class Banco
    {

        //SQLiteConnection oConnection = new SQLiteConnection(@"Data Source=" + Environment.CurrentDirectory.Replace(@"\", @"\\") + @"\\DBs\\AppDb.s3db" + @"; Version=3");
        SQLiteConnection oConnection = new SQLiteConnection(@"Data Source=" + Directory.GetCurrentDirectory().Replace(@"\bin\Debug", "").Replace(@"\", @"\\") + @"\\Resources"+ @"\\AppDb.s3db" + @"; Version=3");

        public void ComandoSQL(string SQL)
        {
            oConnection.Open();
            SQLiteCommand oCommand = new SQLiteCommand(oConnection);
            oCommand.CommandText = SQL;
            oCommand.ExecuteNonQuery();
            oConnection.Close();
        }

        public DataTable GetDatatable(string SQL)
        {
            oConnection.Open();
            SQLiteDataAdapter oAdapter = new SQLiteDataAdapter(SQL, oConnection);
            DataTable oDataTable = new DataTable();
            oAdapter.Fill(oDataTable);
            oConnection.Close();
            return oDataTable;
        }

    }
}
