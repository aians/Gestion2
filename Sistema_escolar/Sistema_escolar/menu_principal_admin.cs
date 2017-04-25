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
    public partial class frm_menu_admin : Form
    {
        public frm_menu_admin()
        {
            InitializeComponent();
        }

        private void aGREGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form datosalumno = new frm_datos_alumno();
             datosalumno.Show();
        }

        private void eLIMINARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form busquedaalumno = new frm_busqueda_alumno();
            busquedaalumno.Show();
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form busquedaalumno = new frm_busqueda_alumno();
            busquedaalumno.Show();
        }

        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form datosprofesor= new frm_datos_profesor();
            datosprofesor.Show();
        }

        private void cONSULTARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form busquedaprofesor = new frm_busqueda_profesores();
            busquedaprofesor.Show();
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form busquedaprofesor = new frm_busqueda_profesores();
            busquedaprofesor.Show();
        }

        private void aGREGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form datosadmi = new frm_datos_admi();
            datosadmi.Show();

        }

        private void cONSULTARToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
