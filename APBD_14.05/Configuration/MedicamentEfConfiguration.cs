using System.Collections.Generic;
using APBD_14._05.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_14._05.Configuration
{
    public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
    {
        private List<Medicament> dictMedicament;

        public MedicamentEfConfiguration()
        {
            dictMedicament = new List<Medicament>()
            {
                new Medicament()
                {
                    IdMedicament = 1,
                    Name = "Paracetamol",
                    Description = "Super lek, nie przedawkujesz mordo!",
                    Type = "Przeciwbólowy/Przeciwgorączkowy"
                }
            };
        }

        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(e => e.IdMedicament);
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Type).HasMaxLength(100).IsRequired();
            builder.HasData(dictMedicament);
        }
    }
}