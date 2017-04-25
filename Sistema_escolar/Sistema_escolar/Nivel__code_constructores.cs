using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_escolar
{
    class Nivel__code_constructores
    {
            public int idNivel { get; set; }
            public string Nombre_nivel { get; set; }

            public Nivel__code_constructores() { }

            public Nivel__code_constructores(int pidNivel,string piNombre_nivel)

            {
                this.idNivel = pidNivel;
                this.Nombre_nivel = piNombre_nivel;
            }

        
    }
}
