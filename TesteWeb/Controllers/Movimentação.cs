using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteWeb.Enumerador;
using TesteWeb.Models; // Certifique-se de importar o namespace que contém suas classes de modelo

public class MovimentacaoController : Controller
{
    private readonly Contexto _dbContext;

    public MovimentacaoController(Contexto dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {

        return View();
    }
}