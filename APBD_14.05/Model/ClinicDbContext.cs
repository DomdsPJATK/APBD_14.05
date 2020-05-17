using Microsoft.EntityFrameworkCore;

namespace APBD_14._05.Model
{
    
    public class ClinicDbContext : DbContext
    {
        protected ClinicDbContext()
        {
        }

        public ClinicDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
    
}