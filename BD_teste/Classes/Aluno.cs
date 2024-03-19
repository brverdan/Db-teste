namespace BD_teste.Classes;

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<TurmaAlunos> TurmaAlunos { get; set; }

    public Aluno(string nome)
    {
        Nome = nome;
    }
}
