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
    public partial class frmTiposDeDocumentosAE : Form
    {
        public frmTiposDeDocumentosAE()
        {
            InitializeComponent();
        }

        TiposDeDocumentos tipodoc;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipodoc != null)
            {
                TipoDeDocumentoTextBox.Text = tipodoc.Descripcion;
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(TipoDeDocumentoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TipoDeDocumentoTextBox, "Debe ingresar un tipo de documento.");
            }

            return valido;
        }
        public TiposDeDocumentos GetTipoDeDocumento()
        {
            return tipodoc;
        }

        public void SetTipoDeDocumento(TiposDeDocumentos tipodoc)
        {
            this.tipodoc = tipodoc;
        }



        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipodoc == null)
                {
                    tipodoc = new TiposDeDocumentos();
                }

                tipodoc.Descripcion = TipoDeDocumentoTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private void Okbtn_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipodoc == null)
                {
                    tipodoc = new TiposDeDocumentos();
                }

                tipodoc.Descripcion = TipoDeDocumentoTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }

        }

        private void Cancelarbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TipoDeDocumentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTiposDeDocumentosAE_Load(object sender, EventArgs e)
        {

        }
    }
}
