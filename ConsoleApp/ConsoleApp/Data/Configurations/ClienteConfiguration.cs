using ConsoleApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApbuilder.Data.Configurations
{
    class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(builder => builder.Id);
            builder.Property(builder => builder.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(builder => builder.Telefone).HasColumnType("CHAR(11)");
            builder.Property(builder => builder.CEP).HasColumnType("CHAR(8)").IsRequired();
            builder.Property(builder => builder.Estado).HasColumnType("CHAR(2)").IsRequired();
            builder.Property(builder => builder.Cidade).HasMaxLength(60).IsRequired();

            builder.HasIndex(i => i.Telefone).HasDatabaseName("idx_cliente_telefone"); //Index for telefone search
        }
    }
}
