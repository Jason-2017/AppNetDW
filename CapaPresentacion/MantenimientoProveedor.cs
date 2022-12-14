using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            lblMantProvAccError.Text = (DateTime.Now).ToString();

        }

        private void btnMantProvAgregar_Click(object sender, EventArgs e)
        {
            CapaEntidadBE.PROVEEDOR proveedor = new CapaEntidadBE.PROVEEDOR();
            proveedor.nit = txtMantProvNIT.Text;
            proveedor.nombreRazonSocial = txtMantProvNomRazSocial.Text;
            int val = gestor.ExisteProveedor(proveedor);
            if (val == 1) lblMantProvAccError.Text = "Proveedor ya existe";
            else {
                int res = gestor.grabar(proveedor);
                var x= res == -1 ? "Proveedor grabado con exito" : String.Empty;
                lblMantProvAccError.Text = x.ToString();
                dgvMantProv.DataBindings.Clear();
                dgvMantProv.DataSource = gestor.listar();
            }
        }

        private void dgvMantProv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CapaEntidadBE.PROVEEDOR proveedor = new CapaEntidadBE.PROVEEDOR();
            proveedor.idProveedor = Convert.ToInt32(dgvMantProv["idProveedor", e.RowIndex].Value);
            proveedor.nit = dgvMantProv["nit", e.RowIndex].Value.ToString();
            proveedor.nombreRazonSocial = Convert.ToString(dgvMantProv["nombreRazonSocial", e.RowIndex].Value);
            proveedor.estado = dgvMantProv["estado", e.RowIndex].Value.ToString();
            gestor.actualizar(proveedor);
            dgvMantProv.DataBindings.Clear();
            dgvMantProv.DataSource = gestor.listar();
        }

        private void btnMantProvEliminar_Click(object sender, EventArgs e)
        {
            int idProveedor = Convert.ToInt32(dgvMantProv["idProveedor", dgvMantProv.CurrentCell.RowIndex].Value);
            int res = gestor.eliminar(idProveedor);
            var x = res == -1 ? "Proveedor eliminado con exito" : String.Empty;
            lblMantProvAccError.Text = x.ToString();
            dgvMantProv.DataBindings.Clear();
            dgvMantProv.DataSource = gestor.listar();
        }
    }
}
