using BD_teste.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BD_teste.Database.Mapping;

public class TurmaMapping : IEntityTypeConfiguration<Turma>
{
    public void Configure(EntityTypeBuilder<Turma> builder)
    {
        builder.ToTable("Turmas");
        builder.HasKey(t => t.Id);

        builder.Property(a => a.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Property(a => a.Nome).IsRequired().HasMaxLength(255);
    }
}
