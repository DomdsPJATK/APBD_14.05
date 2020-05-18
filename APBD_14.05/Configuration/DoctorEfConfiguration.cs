using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using APBD_14._05.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_14._05.Configuration
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {

        private List<Doctor> dictDoctors;

        public DoctorEfConfiguration()
        {
            dictDoctors = new List<Doctor>
            {
                new Doctor()
                {
                    IdDoctor = 1,
                    FirstName = "Paweł",
                    LastName = "Lekarski",
                    Email = "pawel.lekarski@gmail.com"
                }
            };
        }

        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor);
            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.HasData(dictDoctors);
        }
    }
}