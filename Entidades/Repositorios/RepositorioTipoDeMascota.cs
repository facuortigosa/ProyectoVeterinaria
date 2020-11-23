using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Repositorios
{
    public class RepositorioTipoDeMascota
    {

        private readonly SqlConnection cn;


        public RepositorioTipoDeMascota(SqlConnection cn)
        {
            this.cn = cn;

        }
        

        public List<TipoDeMascota> GetLista()
        {
            try
            {
                List<TipoDeMascota> lista = new List<TipoDeMascota>();
                string cadenaComando = "SELECT TipoDeMascotaID, Descripcion FROM TipoDeMascota";
                var comando = new SqlCommand(cadenaComando, cn);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TipoDeMascota tipomas = ConstruirTipoMas(reader);
                    lista.Add(tipomas);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private TipoDeMascota ConstruirTipoMas(SqlDataReader reader)
        {
            return new TipoDeMascota
            {
                TipoDeMascotaId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)

            };
        }

        public void Agregar(TipoDeMascota tipomas)
        {
            try
            {
                string cadenaComando = "INSERT INTO TipoDeMascota VALUES (@tipodemascota)";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@tipodemascota", tipomas.Descripcion);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@Identity";
                comando = new SqlCommand(cadenaComando, cn);
                int id = (int)(decimal)comando.ExecuteScalar();
                tipomas.TipoDeMascotaId = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDeMascota tipomas)
        {
            try
            {
                var cadenaComando = "SELECT TipoDeMascotaID, Descripcion FROM TipoDeMascota WHERE Descripcion=@nombre";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nombre", tipomas.Descripcion);
                var reader = comando.ExecuteReader();
                return reader.HasRows;

            }

            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
           
 
        public void Borrar(TipoDeMascota tipomas)
        {
            try
            {
                string cadenaComando = "DELETE FROM TipoDeMascota WHERE TipoDeMascotaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipomas.TipoDeMascotaId);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public TipoDeMascota GetTipoDeMascotaPorId(int id)
        {
            try
            {
                TipoDeMascota tipomas = null;
                string cadenaComando = "SELECT TipoDeMascotaID, Descripcion FROM TipoDeMascota WHERE TipoDeMascotaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    tipomas = ConstruirTipoMas(reader);
                    
                }
                reader.Close();
                return tipomas;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void Guardar(TipoDeMascota tipomas)
        {
            if (tipomas.TipoDeMascotaId == 0)
            {
                try
                {
                    string cadenaComando = "INSERT INTO TipoDeMascota VALUES (@desc)";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@desc", tipomas.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    tipomas.TipoDeMascotaId = id;
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
                    string cadenaComando = "UPDATE TipoDeMascota SET Descripcion=@desc WHERE TipoDeMascotaID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@desc", tipomas.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipomas.TipoDeMascotaId);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public bool EstaRelacionado(TipoDeMascota tipomas)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Mascotas WHERE TipoDeMascotaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", tipomas.TipoDeMascotaId);
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

