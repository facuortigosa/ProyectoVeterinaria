using Entidades;
using ProyectoVeterinaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioTiposDeDocumentos
    {
         public ServicioTiposDeDocumentos()
        {
        }
        private ConexionBd _conexion;
        private RepositorioTiposDeDocumentos repositorio;

        public void Guardar(TiposDeDocumentos tipodoc)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                repositorio.Guardar(tipodoc);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(TiposDeDocumentos tipodoc)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                repositorio.Agregar(tipodoc);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                var existe = repositorio.Existe(tipodoc);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TiposDeDocumentos tipodoc)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                var estaRelacionado = repositorio.EstaRelacionado(tipodoc);
                _conexion.CerrarConexion();
                return estaRelacionado;
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
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                repositorio.Borrar(tipodoc);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public TiposDeDocumentos GetDocumentoPorId(int id)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                var tipodoc = repositorio.GetTipoDeDocumentoPorId(id);
                _conexion.CerrarConexion();
                return tipodoc;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public List<TiposDeDocumentos> GetLista()
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
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
