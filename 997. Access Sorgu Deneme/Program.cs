using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _997.Access_Sorgu_Deneme
{
    class Program
    {
        static void Main()
        {
            // Not: Access 2016 ve sonrası için ACE.OLEDB.16, öncesinde ACE.OLEDB.12 kullanıyoruz.
            string connString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=E:\proje_adi\Northwind.accdb;";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();    // Not: Access x64'te çalıştığından Properties > Build > Platform Target'i x86 seçmem gerekti (Önceki değeri Any Cpu)
                string query = "SELECT * FROM Müşteriler";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["Ad"]+" "+reader["Soyadı"]+" -- "+reader["Şirket"] ); // Müşterinin adı ve soyadını yazdırdım
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }

}




