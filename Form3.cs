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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 iniciarsesion = new Form1();
            iniciarsesion.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre1 = nombre.Text;
            string apellidos1 = apellidos.Text;
            string sexo1 = sexo.Text;
            string email1 = email.Text;
            string contraseña1 = contraseña.Text;
            string estadocivil1 = estadocivil.Text;
            string fechadenacimiento = nacimiento.Text;
            string telefono1 = telefono.Text;
            string condiciones1 = condiciones.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(nombre1) || string.IsNullOrWhiteSpace(email1) || string.IsNullOrWhiteSpace(fechadenacimiento)
                || string.IsNullOrWhiteSpace(apellidos1) || string.IsNullOrWhiteSpace(contraseña1) || string.IsNullOrWhiteSpace(telefono1)
                || string.IsNullOrWhiteSpace(sexo1) || string.IsNullOrWhiteSpace(estadocivil1) || string.IsNullOrWhiteSpace(condiciones1))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                }
                else
                {
                    Form2 forma33 = new Form2();
                    forma33.Show();
                    Hide();
                    MessageBox.Show("¡Bienvenido!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {
            Form1 iniciosesion = new Form1();
            iniciosesion.Show();
            Hide();
        }
    }
}
