
namespace ClinicaVida.Web.Models;

public class Consulta
{
    public int Id {get; set; }
    public int PacienteId {get; set; }
    public int MedicoId {get; set; }
    public DateTime Data {get; set; }
    public TimeSpan Horario {get; set; }
    public string? Observacoes {get; set; }
}