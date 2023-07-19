using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20230719JohnyDriotis.Models.ModelsOut
{
    public class DepartamentosPorEmpresa
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public int NumeroEmpleados { get; set; }
        public string NivelOrganizacion { get; set; }
        public int CodEmpresa { get; set; }
        public string Empresa { get; set; }
    }
}
