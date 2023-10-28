using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDeUsuario
{
    public partial class Form1 : Form
    {
        private int intentos = 0;
        private const int maxIntentos = 3;
        private const string usuarioCorrecto = "caro";
        private const string contrasenaCorrecta = "123";

        public Form1()
        {
            InitializeComponent();
        }


        private void entrar_Click(object sender, EventArgs e)
        {


            string usuario = usuarioo.Text;
            string contrasena = contraseñaa.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                }
                else if (usuario.Length < 4)
                {
                    MessageBox.Show("El nombre de usuario debe contener al menos 4 caracteres.");
                }
                else if (intentos >= maxIntentos)
                {
                    MessageBox.Show("Te has pasado del limite de intentos");
                    Application.Exit();
                }
                else if (usuario == usuarioCorrecto && contrasena != contrasenaCorrecta)
                {
                    MessageBox.Show("Contraseña incorrecta. Oportunidades sobrantes: " + (maxIntentos - intentos));
                    intentos++;
                }
                else if (usuario != usuarioCorrecto && contrasena == contrasenaCorrecta)
                {
                    MessageBox.Show("Usuario incorrecto. Oportunidades restantes: " + (maxIntentos - intentos));
                    intentos++;
                }
                else if (usuario == usuarioCorrecto && contrasena == contrasenaCorrecta)
                {
                    Form2 estudiantes = new Form2();
                    estudiantes.Show();
                    Hide();
                    MessageBox.Show("¡Bienvenidx!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 registro = new Form3();
            registro.Show();
            Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
   
