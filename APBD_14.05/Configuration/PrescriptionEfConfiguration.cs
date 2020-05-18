using System;
using System.Collections.Generic;
using APBD_14._05.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_14._05.Configuration
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        private List<Prescription> dictPrescription;

        public PrescriptionEfConfiguration()
        {
            dictPrescription = new List<Prescription>()
            {
                new Prescription()
                {
                    IdPrescription = 1,
                    Date = Convert.ToDateTime("13.05.1981"),
                    DueDate = Convert.ToDateTime("18.05.2020"),
                    IdPatient = 1,
                    IdDoctor = 1
                }
            };
        }

        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(e => e.IdPrescription);
            builder.Property(e => e.Date).IsRequired();
            builder.Property(e => e.DueDate).IsRequired();
            builder.HasOne<Patient>().WithMany().HasForeignKey(e => e.IdPatient).IsRequired();
            builder.HasOne<Doctor>().WithMany().HasForeignKey(e => e.IdDoctor).IsRequired();
            builder.HasData(dictPrescription);
        }
    }
}