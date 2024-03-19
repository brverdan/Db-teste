using BD_teste.Classes;
using BD_teste.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BD_teste.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlunoController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAlunos()
    {
        using (var context = new EscolaContext())
        {
            var alunos = await context.Alunos
                .Include(a => a.TurmaAlunos)
                .ToListAsync();
            return Ok(alunos);
        }
    }

    [HttpPost("criarAluno")]
    public async Task<IActionResult> CriarAlunos()
    {
        using (var context = new EscolaContext())
        {
            context.Alunos.Add(new Aluno("Bruno"));
            await context.SaveChangesAsync();

            return Created("", null);
        }
    }
}
