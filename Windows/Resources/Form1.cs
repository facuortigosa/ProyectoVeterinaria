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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTipoDeMascota frm = new frmTipoDeMascota();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTiposDeDocumentos frma = new frmTiposDeDocumentos();
            frma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLocalidades frml = new frmLocalidades();
            frml.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProvincias frmp = new frmProvincias();
            frmp.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmFormaFarmaceutica frmf = new frmFormaFarmaceutica();
            frmf.Show();
        }

        private void TiposDeMascotatsb_Click(object sender, EventArgs e)
        {
            frmTipoDeMascota frmm = new frmTipoDeMascota();
            frmm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmTiposDeMedicamentos frmtm = new frmTiposDeMedicamentos();
            frmtm.Show();
        }
    }
}
