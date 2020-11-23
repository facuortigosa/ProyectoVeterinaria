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
    public partial class frmTiposDeDocumentos : Form
    {
        public frmTiposDeDocumentos()
        {
            InitializeComponent();
        }
        private ServicioTiposDeDocumentos servicio;
        private List<TiposDeDocumentos> lista;

        private void frmTiposDeDocumentos_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioTiposDeDocumentos();
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
            foreach (var tipoDocumento in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tipoDocumento);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TiposDeDocumentos tipodoc)
        {
            r.Cells[cmnTipoDeDocumento.Index].Value = tipodoc.Descripcion;
            r.Tag = tipodoc;
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
            frmTiposDeDocumentosAE frm = new frmTiposDeDocumentosAE();
            frm.Text = "Agregar Tipo De Documento";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TiposDeDocumentos tipodoc = frm.GetTipoDeDocumento();
                    if (!servicio.Existe(tipodoc))
                    {
                        servicio.Agregar(tipodoc);
                        var r = ConstruirFila();
                        SetearFila(r, tipodoc);
                        AgregarFila(r);
                        MessageBox.Show("Tipo de documento agregado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Tipo de documento repetido... Alta denegada", "Error",
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

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                TiposDeDocumentos tipodoc = (TiposDeDocumentos)r.Tag;

                frmTiposDeDocumentosAE frm = new frmTiposDeDocumentosAE();
                frm.Text = "Editar Tipo De Documento";
                frm.SetTipoDeDocumento(tipodoc);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tipodoc = frm.GetTipoDeDocumento();
                        if (!servicio.Existe(tipodoc))
                        {
                            servicio.Guardar(tipodoc);
                            SetearFila(r, tipodoc);
                            MessageBox.Show("Tipo de documento Editada¡o", "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tipo de documento Duplicado... Alta denegada", "Error",
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

        private void tsbBorrar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                TiposDeDocumentos tipodoc = (TiposDeDocumentos)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea borrar de la lista a {tipodoc.Descripcion}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!servicio.EstaRelacionado(tipodoc))
                        {
                            servicio.Borrar(tipodoc);
                            dgvDatos.Rows.Remove(r);
                            MessageBox.Show("Tipo de documento Borrado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Tipo de documento con registros asociados \nBaja Denegada", "Error",
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
