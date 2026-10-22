
namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new() { Id = 1, Nome = "Cardiologia", Descricao = "Coração e vasos sanguíneos" },
        new() { Id = 2, Nome = "Pediatria", Descricao = "Saúde das crianças" },
        new() { Id = 3, Nome = "Dermatologia", Descricao = "Cuidados com a pele" },
        new() { Id = 4, Nome = "Ortopedia", Descricao = "Ossos e articulações" }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new() { Id = 1, Nome = "Marta Lisboa", Crm = "55307", EspecialidadeId = 1 },
        new() { Id = 2, Nome = "Caio Nunes", Crm = "41880", EspecialidadeId = 2 },
        new() { Id = 3, Nome = "Ana Costa", Crm = "32145", EspecialidadeId = 1 },
        new() { Id = 4, Nome = "Bruno Almeida", Crm = "28764", EspecialidadeId = 3 },
        new() { Id = 5, Nome = "Carla Souza", Crm = "46781", EspecialidadeId = 2 },
        new() { Id = 6, Nome = "Daniel Ferreira", Crm = "39216", EspecialidadeId = 4 }
    };
}
