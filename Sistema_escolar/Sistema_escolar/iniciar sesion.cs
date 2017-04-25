using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Sistema_escolar
{
    public partial class Frm_principal_usuarios : Form
    {
        MySqlConnection Cn = new MySqlConnection("Server= localhost; Uid=root; Password=root; Database=sistema_escolar; Port=3306; ");
        MySqlCommand Cmd = new MySqlCommand();
        public Frm_principal_usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cn.Open();
            Cmd.Connection = Cn;
            try
            {
                Cmd.CommandText = "Select count(*) from session_admin where Administrador_idAdministrador= '" + txtidentificador.Text + "'and contra='" + Txtcontra.Text + "'";
                int valor = int.Parse(Cmd.ExecuteScalar().ToString());
                //CONFIRMA CON UN VALOR 1 , SI EXISTE O NO 
                if (valor == 1)
                {
                    lblmensaje.Text = "Bienvenido";
                    Form menu_admin = new frm_menu_admin();
                    menu_admin.Show();
                    this.Hide();
                }
                else
                {
                    lblmensaje.Text = "no existe";
                }
            }
            catch (Exception ex)
            {
                lblmensaje.Text = "error siguiente" + ex;
            }
            Cn.Close();
        }

        private void Frm_principal_usuarios_Load(object sender, EventArgs e)
        {

        }

        private void cmbseleccion_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cmbseleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion;
            seleccion = cmbseleccion.Text;
            switch (seleccion)
            {
                case "Alumno":
                    {
                        //
                        txtcurp.Visible = true;
                        txtcontra3.Visible = true;
                        lblcurp.Visible = true;
                        lblcontra3.Visible = true;
                        btm_acceso_admin3.Visible = true;
                        //
                        txtcedula.Visible = false;
                        txtcontra2.Visible = false;
                        lblcontra2.Visible = false;
                        lblcedula.Visible = false;
                        btm_acceso_admin2.Visible = false;
                        //
                        txtidentificador.Visible = false;
                        Txtcontra.Visible = false;
                        lblcontra1.Visible = false;
                        lblidentificador.Visible = false;
                        btm_acceso_admin.Visible = false;
                        //
                        txtid.Visible = false;
                        txtcontra4.Visible = false;
                        lblidentificador2.Visible = false;
                        lblcontra4.Visible = false;
                        btm_acceso_admin4.Visible = false;
                        break;
                    }
                case "Maestro":
                    {
                        txtcedula.Visible = true;
                        txtcontra2.Visible = true;
                        lblcontra2.Visible = true;
                        lblcedula.Visible = true;
                        btm_acceso_admin2.Visible = true;
                        //
                        txtcurp.Visible = false;
                        txtcontra3.Visible = false;
                        lblcurp.Visible = false;
                        lblcontra3.Visible = false;
                        btm_acceso_admin3.Visible = false;
                        //
                        txtidentificador.Visible = false;
                        Txtcontra.Visible = false;
                        lblcontra1.Visible = false;
                        lblidentificador.Visible = false;
                        btm_acceso_admin.Visible = false;
                        //
                        txtid.Visible = false;
                        txtcontra4.Visible = false;
                        lblidentificador2.Visible = false;
                        lblcontra4.Visible = false;
                        btm_acceso_admin4.Visible = false;
                        break;
                    }
                case "Administrador":
                    {
                        txtidentificador.Visible = true;
                        Txtcontra.Visible = true;
                        lblcontra1.Visible = true;
                        lblidentificador.Visible = true;
                        btm_acceso_admin.Visible = true;
                      
                        //
                        txtcedula.Visible = false;
                        txtcontra2.Visible = false;
                        lblcontra2.Visible = false;
                        lblcedula.Visible = false;
                        btm_acceso_admin2.Visible = false;
                        // 
                        txtcurp.Visible = false;
                        txtcontra3.Visible = false;
                        lblcurp.Visible = false;
                        lblcontra3.Visible = false;
                        btm_acceso_admin3.Visible = false;
                        //
                        txtid.Visible = false;
                        txtcontra4.Visible = false;
                        lblidentificador2.Visible = false;
                        lblcontra4.Visible = false;
                        btm_acceso_admin4.Visible = false;
                        break;
                    }
                case "Secretario":
                    {
                        txtid.Visible = true;
                        txtcontra4.Visible= true;
                        lblidentificador2.Visible = true;
                        lblcontra4.Visible = true;
                        btm_acceso_admin4.Visible = true;
                      
                        txtcurp.Visible = false;
                        txtcontra3.Visible = false;
                        lblcurp.Visible = false;
                        lblcontra3.Visible = false;
                        btm_acceso_admin3.Visible = false;
                        //
                        txtidentificador.Visible = false;
                        Txtcontra.Visible = false;
                        lblcontra1.Visible = false;
                        lblidentificador.Visible = false;
                        btm_acceso_admin.Visible = false;
                        //
                        txtcedula.Visible = false;
                        txtcontra2.Visible = false;
                        lblcontra2.Visible = false;
                        lblcedula.Visible = false;
                        btm_acceso_admin2.Visible = false;
                        break;
                    }
            }
        }

        private void btm_acceso_admin2_Click(object sender, EventArgs e)
        {
            Cn.Open();
            Cmd.Connection = Cn;
            try
            {
                Cmd.CommandText = "Select count(*) from sesion_docente where Docentes_Cedula= '" + txtcedula.Text + "'and password_doce='" + txtcontra2.Text + "'";
                int valor = int.Parse(Cmd.ExecuteScalar().ToString());
                //CONFIRMA CON UN VALOR 1 , SI EXISTE O NO 
                if (valor == 1)
                {
                    lblmensaje.Text = "Bienvenido";
                  


                }
                else
                {
                    lblmensaje.Text = "no existe";
                }
            }
            catch (Exception ex)
            {
                lblmensaje.Text = "error siguiente" + ex;
            }
            Cn.Close();
        }

        private void btm_acceso_admin3_Click(object sender, EventArgs e)
        {

            Cn.Open();
            Cmd.Connection = Cn;
            try
            {
                Cmd.CommandText = "Select count(*) from session_alumno where Alumno_CURP= '" + txtcurp.Text + "'and contra='" +txtcontra3.Text + "'";
                int valor = int.Parse(Cmd.ExecuteScalar().ToString());
                //CONFIRMA CON UN VALOR 1 , SI EXISTE O NO 
                if (valor == 1)
                {
                    lblmensaje.Text = "Bienvenido";
                }
                else
                {
                    lblmensaje.Text = "no existe";
                }
            }
            catch (Exception ex)
            {
                lblmensaje.Text = "error siguiente" + ex;
            }
            Cn.Close();
        }

        private void btm_acceso_admin4_Click(object sender, EventArgs e)
        {
            Cn.Open();
            Cmd.Connection = Cn;
            try
            {
                Cmd.CommandText = "Select count(*) from session_secretario where Secretarario_idSecretarario= '" + txtid.Text + "'and Contra='" + txtcontra4.Text + "'";
                int valor = int.Parse(Cmd.ExecuteScalar().ToString());
                //CONFIRMA CON UN VALOR 1 , SI EXISTE O NO 
                if (valor == 1)
                {
                    lblmensaje.Text = "Bienvenido";
                }
                else
                {
                    lblmensaje.Text = "no existe";
                }
            }
            catch (Exception ex)
            {
                lblmensaje.Text = "error siguiente" + ex;
            }
            Cn.Close();
        }

        private void txtcontra4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontra4_Click(object sender, EventArgs e)
        {

        }

        private void lblidentificador2_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontra3_Click(object sender, EventArgs e)
        {

        }

        private void lblcurp_Click(object sender, EventArgs e)
        {

        }

        private void txtcurp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontra2_Click(object sender, EventArgs e)
        {

        }

        private void lblcedula_Click(object sender, EventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }

        private void Txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontra1_Click(object sender, EventArgs e)
        {

        }

        private void lblidentificador_Click(object sender, EventArgs e)
        {

        }

        private void txtidentificador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


