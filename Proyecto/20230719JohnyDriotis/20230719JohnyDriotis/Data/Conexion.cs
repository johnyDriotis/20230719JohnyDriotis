using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace _20230719JohnyDriotis.Data
{
    public class Conexion
    {
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-1KC49PC; Initial Catalog=dbpruebaafp; Integrated security=true");

        public SqlConnection Conectar()
        {
            cnx.Open();
            Console.WriteLine("Conectado");
            return cnx;
        }

        public void Desconectar()
        {
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
                Console.WriteLine("Desconectado");
            }
        }
    }
}
