using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    internal class CervezaBD
    {
        private string connectionString
            = "Data Source=BLADNET\\SQLEXPRESS; Initial Catalog=FundamentosCSharp;"+
            "User ID=soporte;Password=julio500";
        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "SELECT nombre, marca, alcohol, cantidad "+
                "from cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int Cantidad = reader.GetInt32(3);
                    String Nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(Nombre, Cantidad);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);

                    cervezas.Add(cerveza);
                }
                reader.Close();


                connection.Close();
            }

                return cervezas;
        }
    }
}
