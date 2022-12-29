using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Bell_sekolah
{
    internal class database
    {
        public OleDbConnection koneksi;

        public database ()
        {
            string strkon = "Provider=Microsoft.Ace.OleDB.12.0;Data Source = DBBell.accdb";

            koneksi = new OleDbConnection (strkon);
            koneksi.Open ();
        }
        public void Execute (string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = koneksi;
            cmd.CommandText = sql;
        }
        public DataTable GetData(string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = koneksi;
            cmd.CommandText = sql;

            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable ();
            dt.Load (reader);
            return dt;
            
        }
    }
}
