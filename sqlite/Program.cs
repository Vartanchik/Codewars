using System;
using System.Data.SQLite;
using System.Data;
using System.Text;
using System.Security;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace sqlite
{
    class Program
    {
        static void Main(string[] args)
        {/*
            string filename = @"D:\MyChromePass.html";
            StreamWriter Writer = new StreamWriter(filename, false, Encoding.UTF8);
            string db_way = @"C:\Users\HAVG\AppData\Local\Google\Chrome\User Data\Default\Login Data";
            string db_field = "logins";
            Byte[] entropy = null;

            string description;
            DataTable DB = new DataTable();
            string sql = string.Format("SELECT * FROM {0} {1} {2}", db_field, "", "");
            
            using(SQLiteConnection connect = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(sql, connect);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(DB);
            }

            int rows = DB.Rows.Count;
            for(int i = 0; i < rows; i++)
            {
                Writer.Write(i + 1 + ") ");
                Writer.WriteLine(DB.Rows[i][1] + "<br>");
                Writer.WriteLine(DB.Rows[i][3] + "<br>");

                byte[] byteArray = (byte[])DB.Rows[i][5];
                byte[] decrypted = DPAPI.Decrypt(byteArray, entropy, out description);
                string password = new UTF8Encoding(true).GetString(decrypted);
                Writer.WriteLine(password + "<br><br>");
            }*/
        }
    }
}
