using System.Text.Json.Serialization;

namespace BD_teste.Classes;

public class TurmaAlunos
{
    public int IdAluno { get; set; }

    [JsonIgnore]
    public Aluno Aluno { get; set; }

    public int IdTurma { get; set; }

    [JsonIgnore]
    public Turma Turma{ get; set; }

    public TurmaAlunos(int idAluno, int idTurma)
    {
        IdAluno = idAluno;
        IdTurma = idTurma;
    }
}
