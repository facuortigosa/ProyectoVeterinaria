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
    public partial class frmTipoDeMascotaAE : Form
    {
        public frmTipoDeMascotaAE()
        {
            InitializeComponent();
        }

        TipoDeMascota tipomas;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipomas != null)
            {
                TipoDeMascotaTextBox.Text = tipomas.Descripcion;
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(TipoDeMascotaTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TipoDeMascotaTextBox, "Debe ingresar un tipo de mascota.");
            }

            return valido;
        }
        public TipoDeMascota GetTipoDeMascota()
        {
            return tipomas;
        }

        public void SetTipoDeMascota(TipoDeMascota tipomas)
        {
            this.tipomas = tipomas;
        }



        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipomas == null)
                {
                    tipomas = new TipoDeMascota();
                }

                tipomas.Descripcion = TipoDeMascotaTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
