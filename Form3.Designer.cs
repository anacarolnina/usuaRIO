
namespace InterfazDeUsuario
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.registrarme = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.nacimiento = new System.Windows.Forms.DateTimePicker();
            this.estadocivil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iniciosesion = new System.Windows.Forms.LinkLabel();
            this.atras = new System.Windows.Forms.Button();
            this.condiciones = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 144);
            this.label4.MaximumSize = new System.Drawing.Size(71, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña:";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.BackColor = System.Drawing.SystemColors.Control;
            this.correo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.correo.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(49, 175);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(50, 21);
            this.correo.TabIndex = 5;
            this.correo.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de \r\nNacimiento:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefono:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado Civil:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrarme
            // 
            this.registrarme.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarme.Location = new System.Drawing.Point(17, 410);
            this.registrarme.Name = "registrarme";
            this.registrarme.Size = new System.Drawing.Size(308, 33);
            this.registrarme.TabIndex = 9;
            this.registrarme.Text = "Registrarme";
            this.registrarme.UseVisualStyleBackColor = true;
            this.registrarme.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(130, 61);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(195, 25);
            this.nombre.TabIndex = 10;
            // 
            // apellidos
            // 
            this.apellidos.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidos.Location = new System.Drawing.Point(130, 103);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(195, 25);
            this.apellidos.TabIndex = 11;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(130, 173);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(195, 25);
            this.email.TabIndex = 12;
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(130, 210);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(195, 25);
            this.contraseña.TabIndex = 13;
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(130, 298);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(195, 25);
            this.telefono.TabIndex = 14;
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.sexo.Location = new System.Drawing.Point(130, 144);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(195, 21);
            this.sexo.TabIndex = 15;
            // 
            // nacimiento
            // 
            this.nacimiento.Location = new System.Drawing.Point(130, 254);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(195, 20);
            this.nacimiento.TabIndex = 16;
            // 
            // estadocivil
            // 
            this.estadocivil.FormattingEnabled = true;
            this.estadocivil.Items.AddRange(new object[] {
            "Solter@",
            "Comprometid@",
            "Casad@",
            "Viud@",
            "Union Libre"});
            this.estadocivil.Location = new System.Drawing.Point(130, 336);
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.Size = new System.Drawing.Size(195, 21);
            this.estadocivil.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(90, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "¿Ya Eres Miembro?";
            // 
            // iniciosesion
            // 
            this.iniciosesion.AutoSize = true;
            this.iniciosesion.BackColor = System.Drawing.Color.Transparent;
            this.iniciosesion.Location = new System.Drawing.Point(195, 455);
            this.iniciosesion.Name = "iniciosesion";
            this.iniciosesion.Size = new System.Drawing.Size(70, 13);
            this.iniciosesion.TabIndex = 19;
            this.iniciosesion.TabStop = true;
            this.iniciosesion.Text = "Iniciar Sesion";
            this.iniciosesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.Color.Transparent;
            this.atras.BackgroundImage = global::InterfazDeUsuario.Properties.Resources.atras;
            this.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.atras.Location = new System.Drawing.Point(-1, 0);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(49, 36);
            this.atras.TabIndex = 20;
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // condiciones
            // 
            this.condiciones.AutoSize = true;
            this.condiciones.Location = new System.Drawing.Point(69, 387);
            this.condiciones.Name = "condiciones";
            this.condiciones.Size = new System.Drawing.Size(209, 17);
            this.condiciones.TabIndex = 21;
            this.condiciones.Text = "Acepto Las Condiciones de Privacidad";
            this.condiciones.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfazDeUsuario.Properties.Resources.nuevo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 535);
            this.Controls.Add(this.condiciones);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.iniciosesion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.estadocivil);
            this.Controls.Add(this.nacimiento);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.email);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.registrarme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(404, 574);
            this.Name = "Form3";
            this.Text = "Registrate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button registrarme;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.DateTimePicker nacimiento;
        private System.Windows.Forms.ComboBox estadocivil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel iniciosesion;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.CheckBox condiciones;
    }
}