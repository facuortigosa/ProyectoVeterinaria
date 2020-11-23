using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RepositorioLocalidades
    {
        private readonly SqlConnection cn;


        public RepositorioLocalidades(SqlConnection cn)
        {
            this.cn = cn;

        }


        public List<Localidades> GetLista()
        {
            try
            {
                List<Localidades> lista = new List<Localidades>();
                string cadenaComando = "SELECT LocalidadID, NombreLocalidad, ProvinciaID FROM Localidades";
                var comando = new SqlCommand(cadenaComando, cn);

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Localidades localidad = ConstruirLocalidad(reader);
                    lista.Add(localidad);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Localidades ConstruirLocalidad(SqlDataReader reader)
        {
            return new Localidades
            {
                LocalidadID = reader.GetInt32(0),
                NombreLocalidad = reader.GetString(1),
                ProvinciaID =reader.GetInt32(3)

            };
        }

        public void Agregar(Localidades localidad)
        {
            try
            {
                string cadenaComando = "INSERT INTO Localidades VALUES (@nombre, @prov)";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nombre", localidad.NombreLocalidad);
                comando.Parameters.AddWithValue("@prov", localidad.ProvinciaID);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@Identity";
                comando = new SqlCommand(cadenaComando, cn);
                int id = (int)(decimal)comando.ExecuteScalar();
                localidad.LocalidadID = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Localidades localidad)
        {
            try
            {
                var cadenaComando = "SELECT LocalidadID, NombreLocalidad, ProvinciaID FROM Localidades WHERE NombreLocalidad=@nombre";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nombre", localidad.NombreLocalidad);
                var reader = comando.ExecuteReader();
                return reader.HasRows;

            }

            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public void Borrar(Localidades localidad)
        {
            try
            {
                string cadenaComando = "DELETE FROM Localidades WHERE LocalidadID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", localidad.LocalidadID);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public Localidades GetLocalidadPorId(int id)
        {
            try
            {
                Localidades localidad = null;
                string cadenaComando = "SELECT LocalidadID, NombreLocalidad FROM Localidades WHERE LocalidadID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    localidad = ConstruirLocalidad(reader);

                }
                reader.Close();
                return localidad;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void Guardar(Localidades localidad)
        {
            if (localidad.LocalidadID == 0)
            {
                try
                {
                    string cadenaComando = "INSERT INTO Localidades VALUES (@nombre, @prov)";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nombre", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@prov", localidad.ProvinciaID);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    localidad.LocalidadID = id;
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
                    string cadenaComando = "UPDATE Localidades SET NombreLocalidad=@nombre, ProvinciaID=@prov WHERE LocalidadID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nombre", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@prov", localidad.ProvinciaID);
                    comando.Parameters.AddWithValue("@id", localidad.ProvinciaID);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public bool EstaRelacionado(Localidades localidad)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Provincias WHERE LocalidadID=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", localidad.LocalidadID);
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
