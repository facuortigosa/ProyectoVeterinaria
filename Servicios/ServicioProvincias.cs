using Entidades;
using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioProvincias
    {
        private ConexionBd conexion;
        private RepositorioProvincias repositorio;

        public ServicioProvincias()
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(conexion.AbrirConexion());
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public List<Provincias> GetLista()
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(conexion.AbrirConexion());
                var lista = repositorio.GetLista();
                conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(Provincias provincia)
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(conexion.AbrirConexion());
                repositorio.Agregar(provincia);
                conexion.CerrarConexion();

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
                conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(conexion.AbrirConexion());
                var existe = repositorio.Existe(provincia);
                conexion.CerrarConexion();
                return existe;
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
                conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(conexion.AbrirConexion());
                repositorio.Borrar(provincia);
                conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(Provincias provincia)
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(conexion.AbrirConexion());
                repositorio.Guardar(provincia);
                conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Provincias provincia)
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(conexion.AbrirConexion());
                var relacionado = repositorio.EstaRelacionado(provincia);
                conexion.CerrarConexion();
                return relacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
