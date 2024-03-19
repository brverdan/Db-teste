using BD_teste.Classes;
using BD_teste.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BD_teste.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TurmaController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTurmas()
    {
        using (var context = new EscolaContext())
        {
            var turmas = await context.Turmas
                .Include(a => a.TurmaAlunos)
                .ToListAsync();
            return Ok(turmas);
        }
    }

    [HttpPost("criarTurma")]
    public async Task<IActionResult> CriarAlunos()
    {
        using (var context = new EscolaContext())
        {
            context.Turmas.Add(new Turma("Turma 1"));
            await context.SaveChangesAsync();

            return Created("", null);
        }
    }
}
