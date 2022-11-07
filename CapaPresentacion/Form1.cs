using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CapaNegocioBLL.PACIENTE gestor = new CapaNegocioBLL.PACIENTE();
        public Form1()
        {
            InitializeComponent();
            Enlazar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CapaEntidadBE.PACIENTE paciente_ = new CapaEntidadBE.PACIENTE();
            paciente_.Primer_nombre = textBox2.Text;
            paciente_.Segundo_nombre = textBox3.Text;
            paciente_.Primer_apellido = textBox4.Text;
            paciente_.Segundo_apellido = textBox5.Text;
            paciente_.Fecha_de_nacimiento = textBox6.Text;
            paciente_.Telefono = textBox7.Text;
            paciente_.Fecha_inicio_cobertura = textBox8.Text;
            paciente_.Monto_de_cobertura = textBox9.Text;
            paciente_.Estado = "Activo";
            gestor.insertar(paciente_);
            MessageBox.Show("se inserto correctamente");
            Enlazar();
        }
        public void Enlazar()
        {
            CapaNegocioBLL.PACIENTE gestor = new CapaNegocioBLL.PACIENTE();
            dataGridView1.DataSource = gestor.listar();
        }

        public void Limpiar()
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            textBox1.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int cod_paciente = int.Parse(codigo);
                CapaEntidadBE.PACIENTE inter = gestor.listar(cod_paciente);
                gestor.borrar(inter);
                MessageBox.Show("Eliminado correctamente");
                Enlazar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {


                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Enabled = false;
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila...");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapaEntidadBE.PACIENTE paciente_ = new CapaEntidadBE.PACIENTE();
            textBox1.Enabled = true;
            paciente_.Cod = int.Parse(textBox1.Text);
            paciente_.Primer_nombre = textBox2.Text;
            paciente_.Segundo_nombre = textBox3.Text;
            paciente_.Primer_apellido = textBox4.Text;
            paciente_.Segundo_apellido = textBox5.Text;
            paciente_.Fecha_de_nacimiento = textBox6.Text;
            paciente_.Telefono = textBox7.Text;
            paciente_.Fecha_inicio_cobertura = textBox8.Text;
            paciente_.Monto_de_cobertura = textBox9.Text;
            paciente_.Estado = "Activo";
            gestor.editar(paciente_);
            MessageBox.Show("se inserto correctamente");
            Limpiar();
            Enlazar();
        }
    }
}
