namespace BD_teste.Classes;

public class Turma
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<TurmaAlunos> TurmaAlunos { get; set; }

    public Turma(string nome)
    {
        Nome = nome;
    }
}
