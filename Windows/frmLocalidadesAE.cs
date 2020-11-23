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
    public partial class frmLocalidadesAE : Form
    {
        public frmLocalidadesAE()
        {
            InitializeComponent();
        }

        Localidades localidad;
        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (localidad == null)
                {
                    localidad = new Localidades();
                }

                localidad.NombreLocalidad = LocalidadTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(LocalidadTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(LocalidadTextBox, "Debe ingresar una localidad.");
            }

            return valido;
        }
        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Localidades GetLocalidad()
        {
            return localidad;
        }

        public void SetLocalidad(Localidades localidad)
        {
            this.localidad = localidad;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (localidad != null)
            {
                LocalidadTextBox.Text = localidad.NombreLocalidad;
            }
        }
    }
}
