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
    public class ServicioTiposDeMedicamentos
    {
        public ServicioTiposDeMedicamentos()
        {
        }
        private ConexionBd _conexion;
        private RepositorioTiposDeMedicamento repositorio;

        public void Guardar(TipoDeMedicamento tipomed)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeMedicamento(_conexion.AbrirConexion());
                repositorio.Guardar(tipomed);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(TipoDeMedicamento tipomed)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeMedicamento(_conexion.AbrirConexion());
                repositorio.Agregar(tipomed);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeMedicamento(_conexion.AbrirConexion());
                var existe = repositorio.Existe(tipomed);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDeMedicamento tipomed)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeMedicamento(_conexion.AbrirConexion());
                var estaRelacionado = repositorio.EstaRelacionado(tipomed);
                _conexion.CerrarConexion();
                return estaRelacionado;
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
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeMedicamento(_conexion.AbrirConexion());
                repositorio.Borrar(tipomed);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeMedicamento(_conexion.AbrirConexion());
                var tipomed = repositorio.GetTipoDeMedicamentoPorId(id);
                _conexion.CerrarConexion();
                return tipomed;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public List<TipoDeMedicamento> GetLista()
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeMedicamento(_conexion.AbrirConexion());
                var lista = repositorio.GetLista();

                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
