using Microsoft.AspNetCore.Mvc;  // Adicione esta diretiva
using Microsoft.AspNetCore.Authorization;  // Adicione esta diretiva

[Authorize(Roles = "Manager")]
public class DoctorController : Controller
{
    // Métodos para listar médicos, criar conta, fazer login, etc.
}
