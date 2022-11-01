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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnIniciarS.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ControlBotones()
        {
            if (Usuario.Text.Trim() != string.Empty && Usuario.Text.All(char.IsLetter))
            {
                btnIniciarS.Enabled = true;
                errorProvider1.SetError(Usuario, "");
            }
            else
            {
                if (!(Usuario.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(Usuario, "El usuario debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(Usuario, "Indicar usuario");
                }
                btnIniciarS.Enabled = false;
                Usuario.Focus();
            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void btnIniciarS_Click(object sender, EventArgs e)
        {
            using (Mantenimientos ventanaMantenimientos = new Mantenimientos(Usuario.Text))
                ventanaMantenimientos.ShowDialog();
        }
    }
}
