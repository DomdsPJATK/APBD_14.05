using System;
using System.Collections.Generic;
using APBD_14._05.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_14._05.Configuration
{
    public class PatientEfConfiguration : IEntityTypeConfiguration<Patient>
    {
        private List<Patient> dictPatient;

        public PatientEfConfiguration()
        {
            dictPatient = new List<Patient>()
            {
                new Patient()
                {
                    IdPatient = 1,
                    FirstName = "Kacper",
                    LastName = "Bolinoga",
                    Birthdate = Convert.ToDateTime("11.09.2001")
                }
            };
        }

        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.IdPatient);
            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Birthdate).IsRequired();
            builder.HasData(dictPatient);
        }
    }
}