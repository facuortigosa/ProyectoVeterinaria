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
    public partial class frmTipoDeMascota : Form
    {
        public frmTipoDeMascota()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private ServicioTipoDeMascota servicio;
        private List<TipoDeMascota> lista;

        private void frmTipoDeMascota_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioTipoDeMascota();
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
            foreach (var tipoDeMascota in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tipoDeMascota);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoDeMascota tipomas)
        {
            r.Cells[cmnTipoDeMascota.Index].Value = tipomas.Descripcion;
            r.Tag = tipomas;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmTipoDeMascotaAE frm = new frmTipoDeMascotaAE();
            frm.Text = "Agregar Tipo De Mascota";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TipoDeMascota tipoDeMascota = frm.GetTipoDeMascota();
                    if (!servicio.Existe(tipoDeMascota))
                    {
                        servicio.Agregar(tipoDeMascota);
                        var r = ConstruirFila();
                        SetearFila(r, tipoDeMascota);
                        AgregarFila(r);
                        MessageBox.Show("Tipo de mascota agregado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Tipo de mascota repetida... Alta denegada", "Error",
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
                TipoDeMascota tipomas = (TipoDeMascota)r.Tag;

                frmTipoDeMascotaAE frm = new frmTipoDeMascotaAE();
                frm.Text = "Editar Tipo De Mascota";
                frm.SetTipoDeMascota(tipomas);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tipomas = frm.GetTipoDeMascota();
                        if (!servicio.Existe(tipomas))
                        {
                            servicio.Guardar(tipomas);
                            SetearFila(r, tipomas);
                            MessageBox.Show("Tipo de mascota Editada", "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tipo de mascota Duplicada... Alta denegada", "Error",
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
                TipoDeMascota tipomas = (TipoDeMascota)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea borrar de la lista a {tipomas.Descripcion}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!servicio.EstaRelacionado(tipomas))
                        {
                            servicio.Borrar(tipomas);
                            dgvDatos.Rows.Remove(r);
                            MessageBox.Show("Tipo de mascota Borrado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Tipo de mascota con registros asociados \nBaja Denegada", "Error",
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
    }
}
