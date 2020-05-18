using System.Collections.Generic;
using APBD_14._05.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_14._05.Configuration
{
    public class PrescriptionMedicamentEfConfiguration : IEntityTypeConfiguration<PrescriptionMedicament>
    {
        private List<PrescriptionMedicament> dictPrescriptionMedicaments;

        public PrescriptionMedicamentEfConfiguration()
        {
            dictPrescriptionMedicaments = new List<PrescriptionMedicament>()
            {
                new PrescriptionMedicament()
                {
                    IdMecidament = 1,
                    IdPrescription = 1,
                    Dose = 50,
                    Details = "Tylko na pusty żołądek"
                }
            };
        }

        public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
        {
            builder.HasKey(e => e.IdMecidament);
            builder.HasKey(e => e.IdPrescription);
            builder.HasOne<Medicament>().WithMany().HasForeignKey(e => e.IdMecidament).IsRequired();
            builder.HasOne<Prescription>().WithMany().HasForeignKey(e => e.IdPrescription).IsRequired();
            builder.Property(e => e.Dose).IsRequired();
            builder.Property(e => e.Details).HasMaxLength(100).IsRequired();
            builder.HasData(dictPrescriptionMedicaments);
        }
    }
}