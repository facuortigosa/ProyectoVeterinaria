using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RepositorioTiposDeDocumentos
    {
        private readonly SqlConnection cn;


        public RepositorioTiposDeDocumentos(SqlConnection cn)
        {
            this.cn = cn;

        }


        public List<TiposDeDocumentos> GetLista()
        {
            try
            {
                List<TiposDeDocumentos> lista = new List<TiposDeDocumentos>();
                string cadenaComando = "SELECT TipoDeDocumentoID, Descripcion FROM TiposDeDocumento";
                var comando = new SqlCommand(cadenaComando, cn);
                
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TiposDeDocumentos tipodoc = ConstruirTipoDoc(reader);
                    lista.Add(tipodoc);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private TiposDeDocumentos ConstruirTipoDoc(SqlDataReader reader)
        {
            return new TiposDeDocumentos
            {
                TipoDocumentoID = reader.GetInt32(0),
                Descripcion = reader.GetString(1)

            };
        }

        public void Agregar(TiposDeDocumentos tipodoc)
        {
            try
            {
                string cadenaComando = "INSERT INTO TiposDeDocumento VALUES (@tipodoc)";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipodoc", tipodoc.Descripcion);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@Identity";
                comando = new SqlCommand(cadenaComando, cn);
                int id = (int)(decimal)comando.ExecuteScalar();
                tipodoc.TipoDocumentoID = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(TiposDeDocumentos tipodoc)
        {
            try
            {
                var cadenaComando = "SELECT TipoDeDocumentoID, Descripcion FROM TiposDeDocumento WHERE Descripcion=@nombre";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nombre", tipodoc.Descripcion);
                var reader = comando.ExecuteReader();
                return reader.HasRows;

            }

            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public void Borrar(TiposDeDocumentos tipodoc)
        {
            try
            {
                string cadenaComando = "DELETE FROM TiposDeDocumento WHERE TipoDeDocumentoID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipodoc.TipoDocumentoID);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public TiposDeDocumentos GetTipoDeDocumentoPorId(int id)
        {
            try
            {
                TiposDeDocumentos tipodoc = null;
                string cadenaComando = "SELECT TipoDeDocumentoID, Descripcion FROM TiposDeDocumento WHERE TipoDeDocumentoID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    tipodoc = ConstruirTipoDoc(reader);

                }
                reader.Close();
                return tipodoc;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void Guardar(TiposDeDocumentos tipodoc)
        {
            if (tipodoc.TipoDocumentoID == 0)
            {
                try
                {
                    string cadenaComando = "INSERT INTO TiposDeDocumento VALUES (@tipodoc)";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@tipodoc", tipodoc.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    tipodoc.TipoDocumentoID = id;
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
                    string cadenaComando = "UPDATE TiposDeDocumento SET Descripcion=@desc WHERE TipoDeDocumentoID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@desc", tipodoc.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipodoc.TipoDocumentoID);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public bool EstaRelacionado(TiposDeDocumentos tipodoc)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Clientes WHERE TipoDeDocumentoID=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipodoc.TipoDocumentoID);
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
