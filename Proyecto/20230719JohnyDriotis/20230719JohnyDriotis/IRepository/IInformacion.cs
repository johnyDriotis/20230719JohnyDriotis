using _20230719JohnyDriotis.Models;
using _20230719JohnyDriotis.Models.ModelsOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20230719JohnyDriotis.IRepository
{
    public interface IInformacion
    {
        List<AllDepartamentos> GetAllEmpresas();
        Empresa GetInformacionBasicaEmpresa(int idConsultar);
        List<DepartamentosPorEmpresa> GetDepartamentosPorEmpresa(int idConsultar);
    }
}
