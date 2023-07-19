using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20230719JohnyDriotis.Models
{
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public int NumeroEmpleados { get; set; }
        public string NivelOrganizacion { get; set; } 
        public int IdEmpresa { get; set; }
    }
}
