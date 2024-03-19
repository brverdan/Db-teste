using BD_teste.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BD_teste.Database.Mapping;

public class TurmaAlunosMapping : IEntityTypeConfiguration<TurmaAlunos>
{
    public void Configure(EntityTypeBuilder<TurmaAlunos> builder)
    {
        builder.ToTable("TurmaAlunos");
        builder.HasKey(ta => new {ta.IdTurma, ta.IdAluno});

        builder.HasOne(ta => ta.Aluno)
            .WithMany(a => a.TurmaAlunos)
            .HasForeignKey(ta => ta.IdAluno)
            .OnDelete(DeleteBehavior.Cascade);


        builder.HasOne(ta => ta.Turma)
            .WithMany(a => a.TurmaAlunos)
            .HasForeignKey(ta => ta.IdTurma)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
