using Microsoft.AspNetCore.Authorization;  // Adicione esta diretiva
using Microsoft.AspNetCore.Mvc;  // Adicione esta diretiva

[Authorize(Roles = "Manager,Patient")]
public class PatientController : Controller
{
    // Métodos para registrar, fazer login, agendar/desmarcar consultas, etc.
}
