using BD_teste.Classes;
using BD_teste.Database.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BD_teste.Database;

public class EscolaContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Turma> Turmas { get; set; }
    public DbSet<TurmaAlunos> TurmaAlunos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=escolaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AlunoMapping());
        modelBuilder.ApplyConfiguration(new TurmaMapping());
        modelBuilder.ApplyConfiguration(new TurmaAlunosMapping());

        base.OnModelCreating(modelBuilder);
    }

}
