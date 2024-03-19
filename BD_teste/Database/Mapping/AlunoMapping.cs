using BD_teste.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BD_teste.Database.Mapping;

public class AlunoMapping : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("Alunos");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Property(a => a.Nome).IsRequired().HasMaxLength(255);
    }
}
