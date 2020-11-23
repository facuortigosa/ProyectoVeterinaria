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
    public partial class frmFormaFarmaceutica : Form
    {
        public frmFormaFarmaceutica()
        {
            InitializeComponent();
        }

        private ServicioFormaFarmaceutica servicio;
        private List<FormaFarmaceutica> lista;
        private void frmFormaFarmaceutica_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioFormaFarmaceutica();
                lista = servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var forma in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, forma);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, FormaFarmaceutica forma)
        {
            r.Cells[cmnFormaFarmaceutica.Index].Value = forma.Descripcion;
            r.Tag = forma;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmFormaFarmaceuticaAE frm = new frmFormaFarmaceuticaAE();
            frm.Text = "Agregar Forma Farmaceutica";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    FormaFarmaceutica forma = frm.GetFormaFarmaceutica();
                    if (!servicio.Existe(forma))
                    {
                        servicio.Agregar(forma);
                        var r = ConstruirFila();
                        SetearFila(r, forma);
                        AgregarFila(r);
                        MessageBox.Show("Forma farmaceutica agregada", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Forma farmaceutica repetida... Alta denegada", "Error",
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
                FormaFarmaceutica forma = (FormaFarmaceutica)r.Tag;

                frmFormaFarmaceuticaAE frm = new frmFormaFarmaceuticaAE();
                frm.Text = "Editar Tipo De Documento";
                frm.SetFormaFarmaceutica(forma);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        forma = frm.GetFormaFarmaceutica();
                        if (!servicio.Existe(forma))
                        {
                            servicio.Guardar(forma);
                            SetearFila(r, forma);
                            MessageBox.Show("Forma Farmaceutica Editada", "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Forma Farmaceutica Duplicada... Alta denegada", "Error",
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
                FormaFarmaceutica forma = (FormaFarmaceutica)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea borrar de la lista a {forma.Descripcion}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!servicio.EstaRelacionado(forma))
                        {
                            servicio.Borrar(forma);
                            dgvDatos.Rows.Remove(r);
                            MessageBox.Show("Forma farmaceutica Borrada", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Forma farmaceutica con registros asociados \nBaja Denegada", "Error",
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

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
