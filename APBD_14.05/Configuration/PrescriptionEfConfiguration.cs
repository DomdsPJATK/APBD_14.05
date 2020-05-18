using APBD_14._05.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_14._05.Configuration
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(e => e.IdPrescription);
            builder.Property(e => e.Date).IsRequired();
            builder.Property(e => e.DueDate).IsRequired();
            builder.HasOne<Patient>().WithMany().HasForeignKey(e => e.IdPatient).IsRequired();
            builder.HasOne<Doctor>().WithMany().HasForeignKey(e => e.IdDoctor).IsRequired();
        }
    }
}