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
    public class ServicioTipoDeMascota
    {
        private ConexionBd conexion;
        private RepositorioTipoDeMascota repositorio;

        public ServicioTipoDeMascota()
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioTipoDeMascota(conexion.AbrirConexion());
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public List<TipoDeMascota> GetLista()
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioTipoDeMascota(conexion.AbrirConexion());
                var lista = repositorio.GetLista();
                conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(TipoDeMascota tipomas)
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioTipoDeMascota(conexion.AbrirConexion());
                repositorio.Agregar(tipomas);
                conexion.CerrarConexion();

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
                conexion = new ConexionBd();
                repositorio = new RepositorioTipoDeMascota(conexion.AbrirConexion());
                var existe = repositorio.Existe(tipomas);
                conexion.CerrarConexion();
                return existe;
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
                conexion = new ConexionBd();
                repositorio = new RepositorioTipoDeMascota(conexion.AbrirConexion());
                repositorio.Borrar(tipomas);
                conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(TipoDeMascota tipomas)
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioTipoDeMascota(conexion.AbrirConexion());
                repositorio.Guardar(tipomas);
                conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDeMascota tipomas)
        {
            try
            {
                conexion = new ConexionBd();
                repositorio = new RepositorioTipoDeMascota(conexion.AbrirConexion());
                var relacionado = repositorio.EstaRelacionado(tipomas);
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
