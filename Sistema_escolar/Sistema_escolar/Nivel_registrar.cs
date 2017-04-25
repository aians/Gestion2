using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Sistema_escolar
{
    class Nivel_registrar
    {
        public static int Agregar(Nivel__code_constructores variable)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Nivel (idNivel,Nombre_Nivel) values ('{0}','{1}')",
                variable.idNivel, variable.Nombre_nivel), Bdconexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
