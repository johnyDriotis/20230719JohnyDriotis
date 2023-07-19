using _20230719JohnyDriotis.Data;
using _20230719JohnyDriotis.Models;
using _20230719JohnyDriotis.Models.ModelsOut;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace _20230719JohnyDriotis.IRepository.Repository
{
    public class Informacion : IInformacion
    {

        public List<AllDepartamentos> GetAllEmpresas()
        {
            Conexion cnx = new Conexion();
            List<AllDepartamentos> lstEmpresas = new List<AllDepartamentos>();

            try
            {
                SqlConnection con = cnx.Conectar();
                SqlCommand cmd = new SqlCommand("DepartamentosEmpresa", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    AllDepartamentos empresas = new AllDepartamentos();
                    empresas.CodDepartamento = Convert.ToInt32(sdr["IDDepartamento"]);
                    empresas.Departamento = sdr["Nombres"].ToString();
                    empresas.NumeroEmpleados = Convert.ToInt32(sdr["NumeroEmpleados"]);
                    empresas.NivelOrganizacion = sdr["NivelOrganizacion"].ToString();
                    empresas.IdEmpresa = Convert.ToInt32(sdr["IDEmpresa"]);
                    empresas.Empresa = sdr["Nombre"].ToString();

                    lstEmpresas.Add(empresas);
                }

                cnx.Desconectar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return lstEmpresas;
        }

        

        public List<DepartamentosPorEmpresa> GetDepartamentosPorEmpresa(int idConsultar)
        {
            Conexion cnx = new Conexion();
            List<DepartamentosPorEmpresa> lstDepartamentos = new List<DepartamentosPorEmpresa>();

            try
            {
                SqlConnection con = cnx.Conectar();
                SqlCommand cmd = new SqlCommand("DepartamentosPorEmpresa", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdConsultar", idConsultar);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    DepartamentosPorEmpresa empresas = new DepartamentosPorEmpresa();
                    empresas.IdDepartamento = Convert.ToInt32(sdr["IDDepartamento"].ToString());
                    empresas.Nombre = sdr["Nombres"].ToString();
                    empresas.NumeroEmpleados = Convert.ToInt32(sdr["NumeroEmpleados"]);
                    empresas.NivelOrganizacion = sdr["NivelOrganizacion"].ToString();
                    empresas.CodEmpresa = Convert.ToInt32(sdr["IDEmpresa"].ToString());
                    empresas.Empresa = sdr["Nombre"].ToString();

                    lstDepartamentos.Add(empresas);
                }

                cnx.Desconectar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return lstDepartamentos;
        }

        public Empresa GetInformacionBasicaEmpresa(int idConsultar)
        {
            Conexion cnx = new Conexion();
            Empresa infoBasicaEmpresa = new Empresa();

            try
            {
                SqlConnection con = cnx.Conectar();
                SqlCommand cmd = new SqlCommand("InfoBasicaEmpresa", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdConsultar", idConsultar);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    infoBasicaEmpresa.IdEmpresa = Convert.ToInt32(sdr["IDEmpresa"]);
                    infoBasicaEmpresa.Nombre = sdr["Nombre"].ToString();
                    infoBasicaEmpresa.RazonSocial = sdr["RazonSocial"].ToString();
                    infoBasicaEmpresa.FechaRegistro = Convert.ToDateTime(sdr["FechaRegistro"]);
                }

                cnx.Desconectar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return infoBasicaEmpresa;
        }
    }
}
