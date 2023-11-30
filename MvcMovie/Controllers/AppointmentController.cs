using Microsoft.AspNetCore.Mvc;  // Adicione esta diretiva
using Microsoft.AspNetCore.Authorization;  // Adicione esta diretiva

[Authorize(Roles = "Manager,Patient")]
public class AppointmentController : Controller
{
    // Métodos para gerenciar o agendamento de consultas, como listar, agendar, cancelar, etc.
}
