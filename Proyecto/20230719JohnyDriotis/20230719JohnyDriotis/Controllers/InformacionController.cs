using _20230719JohnyDriotis.IRepository;
using _20230719JohnyDriotis.Models;
using _20230719JohnyDriotis.Models.ModelsOut;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20230719JohnyDriotis.Controllers
{
    public class InformacionController : Controller
    {
        private readonly IInformacion _informacion;

        public InformacionController(IInformacion informacion)
        {
            this._informacion = informacion;
        }

        public IActionResult Index()
        {
            List<AllDepartamentos> empresas = new List<AllDepartamentos>();

            empresas = _informacion.GetAllEmpresas();

            return View("~/Views/Informacion/Index.cshtml", empresas);
        }

        [HttpGet]
        public ActionResult GetInfEmpresa(int idEmpresa)
        {
            Empresa empresa = new Empresa();

            if (idEmpresa != 0)
            {
                empresa = _informacion.GetInformacionBasicaEmpresa(idEmpresa);
            }
            else
            {
                return NotFound("El CodEmpresa enviado es inválido");
            }

            return View("~/Views/Informacion/InformacionEmpresa.cshtml", empresa);
        }

        [HttpGet]
        public ActionResult GetDepartamentosEmp(int idEmpresaCons)
        {
            List<DepartamentosPorEmpresa> empleados = new List<DepartamentosPorEmpresa>();

            if (idEmpresaCons != 0)
            {
                empleados = _informacion.GetDepartamentosPorEmpresa(idEmpresaCons);
            }
            else
            {
                return NotFound("El CodEmpresa enviado es inválido");
            }

            return View("~/Views/Informacion/DepartamentosPorEmpresa.cshtml", empleados);
        }
    }
}
