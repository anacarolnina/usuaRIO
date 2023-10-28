
namespace InterfazDeUsuario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioo = new System.Windows.Forms.TextBox();
            this.contraseñaa = new System.Windows.Forms.TextBox();
            this.entrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.registro = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa al Sistema";
            // 
            // usuarioo
            // 
            this.usuarioo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.usuarioo.Location = new System.Drawing.Point(138, 130);
            this.usuarioo.Name = "usuarioo";
            this.usuarioo.Size = new System.Drawing.Size(244, 39);
            this.usuarioo.TabIndex = 2;
            // 
            // contraseñaa
            // 
            this.contraseñaa.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.contraseñaa.Location = new System.Drawing.Point(138, 230);
            this.contraseñaa.Name = "contraseñaa";
            this.contraseñaa.PasswordChar = '*';
            this.contraseñaa.Size = new System.Drawing.Size(244, 39);
            this.contraseñaa.TabIndex = 4;
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.Transparent;
            this.entrar.BackgroundImage = global::InterfazDeUsuario.Properties.Resources.acceder;
            this.entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.entrar.ForeColor = System.Drawing.Color.Transparent;
            this.entrar.Location = new System.Drawing.Point(252, 327);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(96, 55);
            this.entrar.TabIndex = 5;
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "¿No tienes cuenta?";
            // 
            // registro
            // 
            this.registro.AutoSize = true;
            this.registro.BackColor = System.Drawing.Color.Transparent;
            this.registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Location = new System.Drawing.Point(206, 405);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(65, 13);
            this.registro.TabIndex = 8;
            this.registro.TabStop = true;
            this.registro.Text = "Registrate";
            this.registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registro_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(1, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña:";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.BackgroundImage = global::InterfazDeUsuario.Properties.Resources.salir;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.ForeColor = System.Drawing.Color.Transparent;
            this.salir.Location = new System.Drawing.Point(33, 327);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(96, 55);
            this.salir.TabIndex = 6;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click_1);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.BackColor = System.Drawing.Color.Transparent;
            this.no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.no.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.ForeColor = System.Drawing.SystemColors.Desktop;
            this.no.Location = new System.Drawing.Point(12, 438);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(175, 52);
            this.no.TabIndex = 11;
            this.no.Text = "usuario: caro\r\n contraseña:123";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfazDeUsuario.Properties.Resources._1fdd3b3a10568c4c9f157b0073cefda6__1_;
            this.ClientSize = new System.Drawing.Size(384, 531);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.contraseñaa);
            this.Controls.Add(this.usuarioo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(404, 574);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuarioo;
        private System.Windows.Forms.TextBox contraseñaa;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel registro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label no;
    }
}

