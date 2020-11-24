using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorios
{
    public class RepositorioTiposDeMedicamento
    {
        private readonly SqlConnection cn;


        public RepositorioTiposDeMedicamento(SqlConnection cn)
        {
            this.cn = cn;

        }


        public List<TipoDeMedicamento> GetLista()
        {
            try
            {
                List<TipoDeMedicamento> lista = new List<TipoDeMedicamento>();
                string cadenaComando = "SELECT TipoDeMedicamentoID, Descripcion FROM TiposDeMedicamentos";
                var comando = new SqlCommand(cadenaComando, cn);

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TipoDeMedicamento tipomed = ConstruirTipoMed(reader);
                    lista.Add(tipomed);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private TipoDeMedicamento ConstruirTipoMed(SqlDataReader reader)
        {
            return new TipoDeMedicamento
            {
                TipoDeMedicamentoID = reader.GetInt32(0),
                Descripcion = reader.GetString(1)

            };
        }

        public void Agregar(TipoDeMedicamento tipomed)
        {
            try
            {
                string cadenaComando = "INSERT INTO TiposDeMedicamentos VALUES (@tipomed)";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipomed", tipomed.Descripcion);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@Identity";
                comando = new SqlCommand(cadenaComando, cn);
                int id = (int)(decimal)comando.ExecuteScalar();
                tipomed.TipoDeMedicamentoID = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDeMedicamento tipomed)
        {
            try
            {
                var cadenaComando = "SELECT TipoDeMedicamentoID, Descripcion FROM TiposDeMedicamentos WHERE Descripcion=@desc";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@desc", tipomed.Descripcion);
                var reader = comando.ExecuteReader();
                return reader.HasRows;

            }

            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public void Borrar(TipoDeMedicamento tipomed)
        {
            try
            {
                string cadenaComando = "DELETE FROM TiposDeMedicamentos WHERE TipoDeMedicamentoID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipomed.TipoDeMedicamentoID);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public TipoDeMedicamento GetTipoDeMedicamentoPorId(int id)
        {
            try
            {
                TipoDeMedicamento tipomed = null;
                string cadenaComando = "SELECT TipoDeMedicamentoID, Descripcion FROM TiposDeMedicamentos WHERE TipoDeMedicamentoID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    tipomed = ConstruirTipoMed(reader);

                }
                reader.Close();
                return tipomed;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void Guardar(TipoDeMedicamento tipomed)
        {
            if (tipomed.TipoDeMedicamentoID == 0)
            {
                try
                {
                    string cadenaComando = "INSERT INTO TiposDeMedicamentos VALUES (@tipomed)";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@tipomed", tipomed.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    tipomed.TipoDeMedicamentoID = id;
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }

            }
            else
            {

                try
                {
                    string cadenaComando = "UPDATE TiposDeMedicamentos SET Descripcion=@desc WHERE TipoDeMedicamentoID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@desc", tipomed.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipomed.TipoDeMedicamentoID);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public bool EstaRelacionado(TipoDeMedicamento tipomed)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Medicamentos WHERE TipoDeMedicamentoID=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipomed.TipoDeMedicamentoID);
                int cantidadRegistros = (int)comando.ExecuteScalar();
                if (cantidadRegistros > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
