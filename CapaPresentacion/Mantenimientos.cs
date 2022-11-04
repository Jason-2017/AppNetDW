using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Mantenimientos : Form
    {
        string Usuario;
        public Mantenimientos(string Usuario)
        {
            InitializeComponent();
        }

        private void Mantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAfiliados_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();

            frm2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenimientoProveedor mantenimientoProveedor = new MantenimientoProveedor();
            mantenimientoProveedor.Show();
        }
    }
}
