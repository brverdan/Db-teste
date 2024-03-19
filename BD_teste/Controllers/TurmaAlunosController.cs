using BD_teste.Classes;
using BD_teste.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BD_teste.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TurmaAlunosController : ControllerBase
{
    [HttpPost("vincularTurmaAluno")]
    public async Task<IActionResult> VincularTurmaAluno(int idAluno, int idTurma)
    {
        using (var context = new EscolaContext())
        {
            context.TurmaAlunos.Add(new TurmaAlunos(idAluno, idTurma));
            await context.SaveChangesAsync();

            return Created("", null);
        }
    }

    [HttpDelete("deleteTurmaAluno")]
    public async Task<IActionResult> deleteTurmaAluno(int idAluno)
    {
        using (var context = new EscolaContext())
        {
            var turmasAlunos = context.TurmaAlunos.Where(ta => ta.IdAluno == idAluno);

            context.TurmaAlunos.RemoveRange(turmasAlunos);
            
            await context.SaveChangesAsync();

            return Created("", null);
        }
    }
}
