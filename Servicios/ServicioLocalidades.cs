using Entidades;
using Entidades.Repositorios;
using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioLocalidades
    {
        private ConexionBd conexion;
        private RepositorioLocalidades repositorio;

        public ServicioLocalidades()
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexion.AbrirConexion());
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public List<Localidades> GetLista()
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexion.AbrirConexion());
                var lista = repositorio.GetLista();
                conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(Localidades localidad)
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexion.AbrirConexion());
                repositorio.Agregar(localidad);
                conexion.CerrarConexion();

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
                conexion = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexion.AbrirConexion());
                var existe = repositorio.Existe(localidad);
                conexion.CerrarConexion();
                return existe;
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
                conexion = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexion.AbrirConexion());
                repositorio.Borrar(localidad);
                conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(Localidades localidad)
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexion.AbrirConexion());
                repositorio.Guardar(localidad);
                conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Localidades localidad)
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexion.AbrirConexion());
                var relacionado = repositorio.EstaRelacionado(localidad);
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
