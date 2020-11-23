
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
    public class ServicioProvincias
    {
        private ConexionBd cxn;
        private RepositorioProvincias repositorio;

        public ServicioProvincias()
        {
            try
            {
                cxn = new ConexionBd();
                repositorio = new RepositorioProvincias(cxn.AbrirConexion());
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
                cxn = new ConexionBd();
                repositorio = new RepositorioProvincias(cxn.AbrirConexion());
                var lista = repositorio.GetLista();
                cxn.CerrarConexion();
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
                cxn = new ConexionBd();
                repositorio = new RepositorioProvincias(cxn.AbrirConexion());
                repositorio.Agregar(provincia);
                cxn.CerrarConexion();

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
                cxn = new ConexionBd();
                repositorio = new RepositorioProvincias(cxn.AbrirConexion());
                var existe = repositorio.Existe(provincia);
                cxn.CerrarConexion();
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
                cxn = new ConexionBd();
                repositorio = new RepositorioProvincias(cxn.AbrirConexion());
                repositorio.Borrar(provincia);
                cxn.CerrarConexion();

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
                cxn = new ConexionBd();
                repositorio = new RepositorioProvincias(cxn.AbrirConexion());
                repositorio.Guardar(provincia);
                cxn.CerrarConexion();

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
                cxn = new ConexionBd();
                repositorio = new RepositorioProvincias(cxn.AbrirConexion());
                var relacionado = repositorio.EstaRelacionado(provincia);
                cxn.CerrarConexion();
                return relacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
