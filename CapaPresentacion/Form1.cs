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
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }


            CapaEntidadBE.PACIENTE paciente_ = new CapaEntidadBE.PACIENTE();
            paciente_.Cod = int.Parse(textBox1.Text);
            paciente_.Primer_nombre = textBox2.Text;
            paciente_.Segundo_nombre = textBox3.Text;
            paciente_.Primer_apellido = textBox4.Text;
            paciente_.Segundo_apellido = textBox5.Text;
            paciente_.Fecha_de_nacimiento = textBox6.Text;
            paciente_.Telefono = textBox7.Text;
            paciente_.Fecha_inicio_cobertura = textBox8.Text;
            paciente_.Monto_de_cobertura = textBox9.Text;

            gestor.grabar(paciente_);
            Enlazar();
        }
        public void Enlazar()
        {

            dataGridView1.DataSource = gestor.listar();
            dataGridView1.DataBindings.Clear();
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            CapaEntidadBE.PACIENTE inter = gestor.listar(id);
            gestor.borrar(inter);
            Enlazar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            CapaEntidadBE.PACIENTE inter = gestor.listar(id);

            textBox2.Text = inter.Primer_nombre;
            textBox3.Text = inter.Segundo_nombre;
            textBox4.Text = inter.Primer_apellido;
            textBox5.Text = inter.Segundo_apellido;
            textBox6.Text = inter.Fecha_de_nacimiento;
            textBox7.Text = inter.Telefono;
            textBox8.Text = inter.Fecha_inicio_cobertura;
            textBox9.Text = inter.Monto_de_cobertura;
        }
    }
}
