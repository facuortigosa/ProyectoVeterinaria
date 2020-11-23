using ProyectoVeterinaria;
using Servicios;
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
    public partial class frmProvincias : Form
    {
        public frmProvincias()
        {
            InitializeComponent();
        }
        private ServicioProvincias servicioProvincia;
        private List<Provincias> lista;

        private void frmProvincias_Load(object sender, EventArgs e)
        {
        }
        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var provincia in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, provincia);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Provincias provincia)
        {
            r.Cells[cmnProvincias.Index].Value = provincia.NombreProvincia;
            r.Tag = provincia;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            frmProvinciasAE frm = new frmProvinciasAE();
            frm.Text = "Agregar Provincia";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Provincias provincia1 = frm.GetProvincia();
                    if (!servicioProvincia.Existe(provincia1))
                    {
                        servicioProvincia.Agregar(provincia1);
                        var r = ConstruirFila();
                        SetearFila(r, provincia1);
                        AgregarFila(r);
                        MessageBox.Show("Provincia agregada", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Provincia repetida... Alta denegada", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                Provincias provincia = (Provincias)r.Tag;

                frmProvinciasAE frm = new frmProvinciasAE();
                frm.Text = "Editar Provincia";
                frm.SetProvincia(provincia);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        provincia = frm.GetProvincia();
                        if (!servicioProvincia.Existe(provincia))
                        {
                            servicioProvincia.Guardar(provincia);
                            SetearFila(r, provincia);
                            MessageBox.Show("Provincia Editada", "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Provincia Duplicada... Alta denegada", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                Provincias provincia = (Provincias)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea borrar de la lista a {provincia.NombreProvincia}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!servicioProvincia.EstaRelacionado(provincia))
                        {
                            servicioProvincia.Borrar(provincia);
                            dgvDatos.Rows.Remove(r);
                            MessageBox.Show("Provincia Borrada", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Provincia con registros asociados \nBaja Denegada", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProvincias_Load_1(object sender, EventArgs e)
        {

            try
            {
                servicioProvincia = new ServicioProvincias();
                lista = servicioProvincia.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
