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
    public class ServicioFormaFarmaceutica
    {
        public ServicioFormaFarmaceutica()
        {
        }
        private ConexionBd _conexion;
        private RepositorioFormaFarmaceutica repositorio;

        public void Guardar(FormaFarmaceutica forma)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioFormaFarmaceutica(_conexion.AbrirConexion());
                repositorio.Guardar(forma);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(FormaFarmaceutica forma)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioFormaFarmaceutica(_conexion.AbrirConexion());
                repositorio.Agregar(forma);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioFormaFarmaceutica(_conexion.AbrirConexion());
                var existe = repositorio.Existe(forma);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(FormaFarmaceutica forma)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioFormaFarmaceutica(_conexion.AbrirConexion());
                var estaRelacionado = repositorio.EstaRelacionado(forma);
                _conexion.CerrarConexion();
                return estaRelacionado;
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
                _conexion = new ConexionBd();
                repositorio = new RepositorioFormaFarmaceutica(_conexion.AbrirConexion());
                repositorio.Borrar(forma);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioFormaFarmaceutica(_conexion.AbrirConexion());
                var forma = repositorio.GetFormaPorId(id);
                _conexion.CerrarConexion();
                return forma;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public List<FormaFarmaceutica> GetLista()
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioFormaFarmaceutica(_conexion.AbrirConexion());
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
