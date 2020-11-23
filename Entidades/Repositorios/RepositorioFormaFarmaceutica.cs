using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorios
{
    public class RepositorioFormaFarmaceutica
    {
        private readonly SqlConnection cn;


        public RepositorioFormaFarmaceutica(SqlConnection cn)
        {
            this.cn = cn;

        }


        public List<FormaFarmaceutica> GetLista()
        {
            try
            {
                List<FormaFarmaceutica> lista = new List<FormaFarmaceutica>();
                string cadenaComando = "SELECT FormaFarmaceuticaID, Descripcion FROM FormasFarmaceuticas";
                var comando = new SqlCommand(cadenaComando, cn);

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    FormaFarmaceutica forma = ConstruirForma(reader);
                    lista.Add(forma);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private FormaFarmaceutica ConstruirForma(SqlDataReader reader)
        {
            return new FormaFarmaceutica
            {
                FormaFarmaceuticaID = reader.GetInt32(0),
                Descripcion = reader.GetString(1)

            };
        }

        public void Agregar(FormaFarmaceutica forma)
        {
            try
            {
                string cadenaComando = "INSERT INTO FormasFarmaceuticas VALUES (@forma)";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@forma", forma.Descripcion);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@Identity";
                comando = new SqlCommand(cadenaComando, cn);
                int id = (int)(decimal)comando.ExecuteScalar();
                forma.FormaFarmaceuticaID = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(FormaFarmaceutica forma)
        {
            try
            {
                var cadenaComando = "SELECT FormaFarmaceuticaID, Descripcion FROM FormasFarmaceuticas WHERE Descripcion=@nombre";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nombre", forma.Descripcion);
                var reader = comando.ExecuteReader();
                return reader.HasRows;

            }

            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public void Borrar(FormaFarmaceutica forma)
        {
            try
            {
                string cadenaComando = "DELETE FROM FormasFarmaceuticas WHERE FormaFarmaceuticaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", forma.FormaFarmaceuticaID);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public FormaFarmaceutica GetFormaPorId(int id)
        {
            try
            {
                FormaFarmaceutica forma = null;
                string cadenaComando = "SELECT FormaFarmaceuticaID, Descripcion FROM FormasFarmaceuticas WHERE FormaFarmaceuticaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    forma = ConstruirForma(reader);

                }
                reader.Close();
                return forma;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void Guardar(FormaFarmaceutica forma)
        {
            if (forma.FormaFarmaceuticaID == 0)
            {
                try
                {
                    string cadenaComando = "INSERT INTO FormasFarmaceuticas VALUES (@forma)";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@forma", forma.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    forma.FormaFarmaceuticaID = id;
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
                    string cadenaComando = "UPDATE FormasFarmaceuticas SET Descripcion=@desc WHERE FormaFarmaceuticaID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@desc", forma.Descripcion);
                    comando.Parameters.AddWithValue("@id", forma.FormaFarmaceuticaID);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public bool EstaRelacionado(FormaFarmaceutica forma)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Medicamentos WHERE FormaFarmaceuticaID=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", forma.FormaFarmaceuticaID);
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
