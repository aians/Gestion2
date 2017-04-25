using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Sistema_escolar
{
    class Bdconexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("Server= localhost; Uid=root; Password=root; Database=sistema_escolar; Port=3306; ");
            conectar.Open();
            return conectar;
        }
    }
}
