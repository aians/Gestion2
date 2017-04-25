namespace Sistema_escolar
{
    partial class Frm_principal_usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtidentificador = new System.Windows.Forms.TextBox();
            this.lblidentificador = new System.Windows.Forms.Label();
            this.lblcontra1 = new System.Windows.Forms.Label();
            this.Txtcontra = new System.Windows.Forms.TextBox();
            this.btm_acceso_admin = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.cmbseleccion = new System.Windows.Forms.ComboBox();
            this.btm_acceso_admin2 = new System.Windows.Forms.Button();
            this.txtcontra2 = new System.Windows.Forms.TextBox();
            this.lblcontra2 = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.btm_acceso_admin3 = new System.Windows.Forms.Button();
            this.txtcontra3 = new System.Windows.Forms.TextBox();
            this.lblcontra3 = new System.Windows.Forms.Label();
            this.lblcurp = new System.Windows.Forms.Label();
            this.txtcurp = new System.Windows.Forms.TextBox();
            this.btm_acceso_admin4 = new System.Windows.Forms.Button();
            this.txtcontra4 = new System.Windows.Forms.TextBox();
            this.lblcontra4 = new System.Windows.Forms.Label();
            this.lblidentificador2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtidentificador
            // 
            this.txtidentificador.Location = new System.Drawing.Point(155, 162);
            this.txtidentificador.Name = "txtidentificador";
            this.txtidentificador.Size = new System.Drawing.Size(100, 20);
            this.txtidentificador.TabIndex = 0;
            this.txtidentificador.Visible = false;
            this.txtidentificador.TextChanged += new System.EventHandler(this.txtidentificador_TextChanged);
            // 
            // lblidentificador
            // 
            this.lblidentificador.AutoSize = true;
            this.lblidentificador.Location = new System.Drawing.Point(75, 169);
            this.lblidentificador.Name = "lblidentificador";
            this.lblidentificador.Size = new System.Drawing.Size(65, 13);
            this.lblidentificador.TabIndex = 1;
            this.lblidentificador.Text = "Identificador";
            this.lblidentificador.Visible = false;
            this.lblidentificador.Click += new System.EventHandler(this.lblidentificador_Click);
            // 
            // lblcontra1
            // 
            this.lblcontra1.AutoSize = true;
            this.lblcontra1.Location = new System.Drawing.Point(75, 222);
            this.lblcontra1.Name = "lblcontra1";
            this.lblcontra1.Size = new System.Drawing.Size(61, 13);
            this.lblcontra1.TabIndex = 2;
            this.lblcontra1.Text = "Contraseña";
            this.lblcontra1.Visible = false;
            this.lblcontra1.Click += new System.EventHandler(this.lblcontra1_Click);
            // 
            // Txtcontra
            // 
            this.Txtcontra.Location = new System.Drawing.Point(155, 219);
            this.Txtcontra.Name = "Txtcontra";
            this.Txtcontra.PasswordChar = '*';
            this.Txtcontra.Size = new System.Drawing.Size(100, 20);
            this.Txtcontra.TabIndex = 3;
            this.Txtcontra.Visible = false;
            this.Txtcontra.TextChanged += new System.EventHandler(this.Txtcontra_TextChanged);
            // 
            // btm_acceso_admin
            // 
            this.btm_acceso_admin.Location = new System.Drawing.Point(78, 281);
            this.btm_acceso_admin.Name = "btm_acceso_admin";
            this.btm_acceso_admin.Size = new System.Drawing.Size(177, 41);
            this.btm_acceso_admin.TabIndex = 4;
            this.btm_acceso_admin.Text = "Acceso";
            this.btm_acceso_admin.UseVisualStyleBackColor = true;
            this.btm_acceso_admin.Visible = false;
            this.btm_acceso_admin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(71, 45);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 39);
            this.lblmensaje.TabIndex = 5;
            this.lblmensaje.Click += new System.EventHandler(this.lblmensaje_Click);
            // 
            // cmbseleccion
            // 
            this.cmbseleccion.FormattingEnabled = true;
            this.cmbseleccion.Items.AddRange(new object[] {
            "Alumno",
            "Maestro",
            "Secretario",
            "Administrador"});
            this.cmbseleccion.Location = new System.Drawing.Point(78, 107);
            this.cmbseleccion.Name = "cmbseleccion";
            this.cmbseleccion.Size = new System.Drawing.Size(177, 21);
            this.cmbseleccion.TabIndex = 6;
            this.cmbseleccion.Text = "Seleccionar";
            this.cmbseleccion.SelectedIndexChanged += new System.EventHandler(this.cmbseleccion_SelectedIndexChanged);
            this.cmbseleccion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbseleccion_MouseClick);
            // 
            // btm_acceso_admin2
            // 
            this.btm_acceso_admin2.Location = new System.Drawing.Point(78, 281);
            this.btm_acceso_admin2.Name = "btm_acceso_admin2";
            this.btm_acceso_admin2.Size = new System.Drawing.Size(177, 41);
            this.btm_acceso_admin2.TabIndex = 11;
            this.btm_acceso_admin2.Text = "Acceso";
            this.btm_acceso_admin2.UseVisualStyleBackColor = true;
            this.btm_acceso_admin2.Visible = false;
            this.btm_acceso_admin2.Click += new System.EventHandler(this.btm_acceso_admin2_Click);
            // 
            // txtcontra2
            // 
            this.txtcontra2.Location = new System.Drawing.Point(155, 219);
            this.txtcontra2.Name = "txtcontra2";
            this.txtcontra2.PasswordChar = '*';
            this.txtcontra2.Size = new System.Drawing.Size(100, 20);
            this.txtcontra2.TabIndex = 10;
            this.txtcontra2.Visible = false;
            this.txtcontra2.TextChanged += new System.EventHandler(this.txtcontra2_TextChanged);
            // 
            // lblcontra2
            // 
            this.lblcontra2.AutoSize = true;
            this.lblcontra2.Location = new System.Drawing.Point(75, 222);
            this.lblcontra2.Name = "lblcontra2";
            this.lblcontra2.Size = new System.Drawing.Size(61, 13);
            this.lblcontra2.TabIndex = 9;
            this.lblcontra2.Text = "Contraseña";
            this.lblcontra2.Visible = false;
            this.lblcontra2.Click += new System.EventHandler(this.lblcontra2_Click);
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Location = new System.Drawing.Point(75, 169);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(40, 13);
            this.lblcedula.TabIndex = 8;
            this.lblcedula.Text = "Cedula";
            this.lblcedula.Visible = false;
            this.lblcedula.Click += new System.EventHandler(this.lblcedula_Click);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(155, 162);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 7;
            this.txtcedula.Visible = false;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // btm_acceso_admin3
            // 
            this.btm_acceso_admin3.Location = new System.Drawing.Point(78, 281);
            this.btm_acceso_admin3.Name = "btm_acceso_admin3";
            this.btm_acceso_admin3.Size = new System.Drawing.Size(177, 41);
            this.btm_acceso_admin3.TabIndex = 16;
            this.btm_acceso_admin3.Text = "Acceso";
            this.btm_acceso_admin3.UseVisualStyleBackColor = true;
            this.btm_acceso_admin3.Visible = false;
            this.btm_acceso_admin3.Click += new System.EventHandler(this.btm_acceso_admin3_Click);
            // 
            // txtcontra3
            // 
            this.txtcontra3.Location = new System.Drawing.Point(155, 219);
            this.txtcontra3.Name = "txtcontra3";
            this.txtcontra3.PasswordChar = '*';
            this.txtcontra3.Size = new System.Drawing.Size(100, 20);
            this.txtcontra3.TabIndex = 15;
            this.txtcontra3.Visible = false;
            this.txtcontra3.TextChanged += new System.EventHandler(this.txtcontra3_TextChanged);
            // 
            // lblcontra3
            // 
            this.lblcontra3.AutoSize = true;
            this.lblcontra3.Location = new System.Drawing.Point(75, 222);
            this.lblcontra3.Name = "lblcontra3";
            this.lblcontra3.Size = new System.Drawing.Size(61, 13);
            this.lblcontra3.TabIndex = 14;
            this.lblcontra3.Text = "Contraseña";
            this.lblcontra3.Visible = false;
            this.lblcontra3.Click += new System.EventHandler(this.lblcontra3_Click);
            // 
            // lblcurp
            // 
            this.lblcurp.AutoSize = true;
            this.lblcurp.Location = new System.Drawing.Point(75, 169);
            this.lblcurp.Name = "lblcurp";
            this.lblcurp.Size = new System.Drawing.Size(29, 13);
            this.lblcurp.TabIndex = 13;
            this.lblcurp.Text = "Curp";
            this.lblcurp.Visible = false;
            this.lblcurp.Click += new System.EventHandler(this.lblcurp_Click);
            // 
            // txtcurp
            // 
            this.txtcurp.Location = new System.Drawing.Point(155, 162);
            this.txtcurp.Name = "txtcurp";
            this.txtcurp.Size = new System.Drawing.Size(100, 20);
            this.txtcurp.TabIndex = 12;
            this.txtcurp.Visible = false;
            this.txtcurp.TextChanged += new System.EventHandler(this.txtcurp_TextChanged);
            // 
            // btm_acceso_admin4
            // 
            this.btm_acceso_admin4.Location = new System.Drawing.Point(78, 281);
            this.btm_acceso_admin4.Name = "btm_acceso_admin4";
            this.btm_acceso_admin4.Size = new System.Drawing.Size(177, 41);
            this.btm_acceso_admin4.TabIndex = 21;
            this.btm_acceso_admin4.Text = "Acceso";
            this.btm_acceso_admin4.UseVisualStyleBackColor = true;
            this.btm_acceso_admin4.Visible = false;
            this.btm_acceso_admin4.Click += new System.EventHandler(this.btm_acceso_admin4_Click);
            // 
            // txtcontra4
            // 
            this.txtcontra4.Location = new System.Drawing.Point(155, 219);
            this.txtcontra4.Name = "txtcontra4";
            this.txtcontra4.PasswordChar = '*';
            this.txtcontra4.Size = new System.Drawing.Size(100, 20);
            this.txtcontra4.TabIndex = 20;
            this.txtcontra4.Visible = false;
            this.txtcontra4.TextChanged += new System.EventHandler(this.txtcontra4_TextChanged);
            // 
            // lblcontra4
            // 
            this.lblcontra4.AutoSize = true;
            this.lblcontra4.Location = new System.Drawing.Point(75, 222);
            this.lblcontra4.Name = "lblcontra4";
            this.lblcontra4.Size = new System.Drawing.Size(61, 13);
            this.lblcontra4.TabIndex = 19;
            this.lblcontra4.Text = "Contraseña";
            this.lblcontra4.Visible = false;
            this.lblcontra4.Click += new System.EventHandler(this.lblcontra4_Click);
            // 
            // lblidentificador2
            // 
            this.lblidentificador2.AutoSize = true;
            this.lblidentificador2.Location = new System.Drawing.Point(75, 169);
            this.lblidentificador2.Name = "lblidentificador2";
            this.lblidentificador2.Size = new System.Drawing.Size(65, 13);
            this.lblidentificador2.TabIndex = 18;
            this.lblidentificador2.Text = "Identificador";
            this.lblidentificador2.Visible = false;
            this.lblidentificador2.Click += new System.EventHandler(this.lblidentificador2_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(155, 162);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 17;
            this.txtid.Visible = false;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // Frm_principal_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 367);
            this.Controls.Add(this.btm_acceso_admin4);
            this.Controls.Add(this.txtcontra4);
            this.Controls.Add(this.lblcontra4);
            this.Controls.Add(this.lblidentificador2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btm_acceso_admin3);
            this.Controls.Add(this.txtcontra3);
            this.Controls.Add(this.lblcontra3);
            this.Controls.Add(this.lblcurp);
            this.Controls.Add(this.txtcurp);
            this.Controls.Add(this.btm_acceso_admin2);
            this.Controls.Add(this.txtcontra2);
            this.Controls.Add(this.lblcontra2);
            this.Controls.Add(this.lblcedula);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.cmbseleccion);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btm_acceso_admin);
            this.Controls.Add(this.Txtcontra);
            this.Controls.Add(this.lblcontra1);
            this.Controls.Add(this.lblidentificador);
            this.Controls.Add(this.txtidentificador);
            this.Name = "Frm_principal_usuarios";
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.Frm_principal_usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidentificador;
        private System.Windows.Forms.Label lblidentificador;
        private System.Windows.Forms.Label lblcontra1;
        private System.Windows.Forms.TextBox Txtcontra;
        private System.Windows.Forms.Button btm_acceso_admin;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.ComboBox cmbseleccion;
        private System.Windows.Forms.Button btm_acceso_admin2;
        private System.Windows.Forms.TextBox txtcontra2;
        private System.Windows.Forms.Label lblcontra2;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Button btm_acceso_admin3;
        private System.Windows.Forms.TextBox txtcontra3;
        private System.Windows.Forms.Label lblcontra3;
        private System.Windows.Forms.Label lblcurp;
        private System.Windows.Forms.TextBox txtcurp;
        private System.Windows.Forms.Button btm_acceso_admin4;
        private System.Windows.Forms.TextBox txtcontra4;
        private System.Windows.Forms.Label lblcontra4;
        private System.Windows.Forms.Label lblidentificador2;
        private System.Windows.Forms.TextBox txtid;
    }
}

