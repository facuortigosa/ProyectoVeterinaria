using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RepositorioProvincias
    {
        private readonly SqlConnection cn;


        public RepositorioProvincias(SqlConnection cn)
        {
            this.cn = cn;

        }


        public List<Provincias> GetLista()
        {
            try
            {
                List<Provincias> lista = new List<Provincias>();
                string cadenaComando = "SELECT ProvinciaID, NombreProvincia FROM Provincias";
                var comando = new SqlCommand(cadenaComando, cn);

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Provincias provincia = ConstruirProvincia(reader);
                    lista.Add(provincia);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Provincias ConstruirProvincia(SqlDataReader reader)
        {
            return new Provincias
            {
                ProvinciaID = reader.GetInt32(0),
                NombreProvincia = reader.GetString(1)

            };
        }

        public void Agregar(Provincias provincia)
        {
            try
            {
                string cadenaComando = "INSERT INTO Provincias VALUES (@nombre)";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nombre", provincia.NombreProvincia);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@Identity";
                comando = new SqlCommand(cadenaComando, cn);
                int id = (int)(decimal)comando.ExecuteScalar();
                provincia.ProvinciaID = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Provincias provincia)
        {
            try
            {
                var cadenaComando = "SELECT ProvinciaID, NombreProvincia FROM Provincias WHERE NombreProvincia=@nombre";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nombre", provincia.NombreProvincia);
                var reader = comando.ExecuteReader();
                return reader.HasRows;

            }

            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public void Borrar(Provincias provincia)
        {
            try
            {
                string cadenaComando = "DELETE FROM Provincias WHERE ProvinciaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", provincia.ProvinciaID);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public Provincias GetProvinciaPorId(int id)
        {
            try
            {
                Provincias provincia = null;
                string cadenaComando = "SELECT ProvinciaID, NombreProvincia FROM Provincias WHERE ProvinciaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    provincia = ConstruirProvincia(reader);

                }
                reader.Close();
                return provincia;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void Guardar(Provincias provincia)
        {
            if (provincia.ProvinciaID == 0)
            {
                try
                {
                    string cadenaComando = "INSERT INTO Provincias VALUES (@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nombre", provincia.NombreProvincia);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    provincia.ProvinciaID = id;
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
                    string cadenaComando = "UPDATE Provincias SET NombreProvincias=@nombre WHERE ProvinciaID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nombre", provincia.NombreProvincia);
                    comando.Parameters.AddWithValue("@id", provincia.ProvinciaID);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public bool EstaRelacionado(Provincias provincia)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Clientes WHERE ProvinciaID=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", provincia.ProvinciaID);
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
