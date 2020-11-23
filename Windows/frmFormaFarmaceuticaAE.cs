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
    public partial class frmFormaFarmaceuticaAE : Form
    {
        public frmFormaFarmaceuticaAE()
        {
            InitializeComponent();
        }

        FormaFarmaceutica forma;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (forma != null)
            {
                FormaFarmaceuticaTextBox.Text = forma.Descripcion;
            }
        }
        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (forma == null)
                {
                    forma = new FormaFarmaceutica();
                }

                forma.Descripcion = FormaFarmaceuticaTextBox.Text.Trim();
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
            if (string.IsNullOrEmpty(FormaFarmaceuticaTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(FormaFarmaceuticaTextBox, "Debe ingresar una forma farmaceutica.");
            }

            return valido;
        }

        public FormaFarmaceutica GetFormaFarmaceutica()
        {
            return forma;
        }

        public void SetFormaFarmaceutica(FormaFarmaceutica forma)
        {
            this.forma = forma;

        }
    }
}
