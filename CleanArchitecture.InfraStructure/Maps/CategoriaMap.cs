using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CleanArchitecture.InfraStructure.Maps
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("CATEGORIA");
            builder.HasKey(x => x.IdCategoria);
            builder.Property(x => x.IdCategoria).HasColumnName("ID_CATEGORIA")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao).HasColumnName("DESCRICAO");
        }
    }
}
