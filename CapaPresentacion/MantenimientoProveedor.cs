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
    public partial class MantenimientoProveedor : Form
    {
        CapaNegocioBLL.PROVEEDOR gestor = new CapaNegocioBLL.PROVEEDOR();
        public MantenimientoProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoProveedor_Load(object sender, EventArgs e)
        {
            dgvMantProv.DataBindings.Clear();
            dgvMantProv.DataSource = gestor.listar();

        }
    }
}
