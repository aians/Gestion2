using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_escolar
{
    public partial class frm_datos_alumno : Form
    {
        public frm_datos_alumno()
        {
            InitializeComponent();
        }

        private void gb_edadAlumno_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nivel__code_constructores variables = new Nivel__code_constructores();
           
                        variables.Nombre_nivel = Cmbnivel.Text.Trim();


                        int resultado = Nivel_registrar.Agregar(variables);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Alumno Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el Alumno", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                        }
                      
        }

        private void Cmbnivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
