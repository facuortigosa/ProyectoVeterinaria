using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows
{
    public partial class frmProvinciasAE : Form
    {
        public frmProvinciasAE()
        {
            InitializeComponent();
        }
        Provincias provincia;
        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (provincia == null)
                {
                    provincia = new Provincias();
                }

                provincia.NombreProvincia = ProvinciaTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(ProvinciaTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ProvinciaTextBox, "Debe ingresar una provincia.");
            }

            return valido;
        }

        public Provincias GetProvincia()
        {
            return provincia;
        }

        public void SetProvincia(Provincias provincia)
        {
            this.provincia = provincia;
        }

    }
}
