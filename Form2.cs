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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox3.Text;
                renglon.Cells[2].Value = textBox2.Text;
                renglon.Cells[3].Value = textBox4.Text;
                renglon.Cells[4].Value = textBox5.Text;
                renglon.Cells[5].Value = textBox6.Text;
                renglon.Cells[6].Value = textBox7.Text;
                renglon.Cells[7].Value = textBox8.Text;
                dataGridView1.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "incorporando producto",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Estas seguro de eliminar la informacion de este producto?";
            string titulo = "Eliminar datos";
            if (!(dataGridView1.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Informacion borrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tienes que selecionar un renglon", "producto borrado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("selecciona un renglon", "modificaciones", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["paisdeorigen"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["fabricante"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["año"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["vencimiento"].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells["marca"].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingresa los datos de el producto y el trabajador, " +
"usa los botones que te ayudaran en poner columnas, " +
"eliminar estas columnas y modificarlas :)", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("adioooooooos ", "¡ATENCION!");
            Application.Exit();
            Hide();

        }
    }
    
}
