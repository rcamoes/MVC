using Microsoft.AspNetCore.Mvc;  // Adicione esta diretiva
using MvcMovie.Models;  // Adicione esta diretiva

public class AccountController : Controller
{
    // Outros métodos

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        // Lógica de autenticação aqui
        // Você pode usar ASP.NET Identity ou outra lógica personalizada

        // Se o login for bem-sucedido, redirecione para a página desejada
        return RedirectToAction("Dashboard", "Home"); // Altere "Dashboard" e "Home" conforme necessário
    }
}
