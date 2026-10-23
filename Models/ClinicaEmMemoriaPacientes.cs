namespace ClinicaVida.Web.Models;

public class ClinicaMemoriaPacientes 
{

public static List<Paciente> Pacientes { get; } = new()
{
    new Paciente { Id = 1, Nome = "Ana Beatriz Rocha", Cpf = "123.456.789-09" },
    new Paciente { Id = 2, Nome = "Carlos Eduardo Lima", Cpf = "987.654.321-00" },
    new Paciente { Id = 3, Nome = "Mariana Tavares", Cpf = "111.222.333-44" },
};

public static List<Consulta> Consultas { get; } = new();
        }