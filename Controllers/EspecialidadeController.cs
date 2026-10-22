
using Microsoft.AspNetCore.Mvc;
using ClinicaVida.Web.Models;
using System.Linq;

namespace ClinicaVida.Web.Controllers;

public class EspecialidadeController : Controller
{
    public IActionResult Index()
    {
        var contagem = ClinicaEmMemoria.Medicos
            .GroupBy(m => m.EspecialidadeId)
            .ToDictionary(
                grupo => grupo.Key,
                grupo => grupo.Count()
            );

        ViewBag.ContagemMedicos = contagem;

        return View(ClinicaEmMemoria.Especialidades);
    }
}
