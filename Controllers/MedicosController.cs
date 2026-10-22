
using Microsoft.AspNetCore.Mvc;
using ClinicaVida.Web.Models;

namespace ClinicaVida.Web.Controllers;

public class MedicosController : Controller
{
    public IActionResult Index(int? especialidadeId)
    {
        var medicos = ClinicaEmMemoria.Medicos
            .Select(m => new Medico
            {
                Id = m.Id,
                Nome = m.Nome,
                Crm = m.Crm,
                EspecialidadeId = m.EspecialidadeId,
                Especialidade = ClinicaEmMemoria.Especialidades
                    .FirstOrDefault(e => e.Id == m.EspecialidadeId)
            });

        if (especialidadeId.HasValue)
        {
            medicos = medicos.Where(
                m => m.EspecialidadeId == especialidadeId.Value
            );
        }

        return View(medicos.OrderBy(m => m.Nome).ToList());
    }

    public IActionResult Details(int id)
    {
        var medico = ClinicaEmMemoria.Medicos
            .FirstOrDefault(m => m.Id == id);

        if (medico == null)
        {
            return NotFound();
        }

        medico.Especialidade = ClinicaEmMemoria.Especialidades
            .FirstOrDefault(e => e.Id == medico.EspecialidadeId);

        return View(medico);
    }
}
