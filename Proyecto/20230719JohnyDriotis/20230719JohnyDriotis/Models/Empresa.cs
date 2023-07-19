using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20230719JohnyDriotis.Models
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
