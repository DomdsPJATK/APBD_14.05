using System.Linq;
using APBD_14._05.DTO.Request;
using APBD_14._05.Model;
using Microsoft.AspNetCore.Mvc;

namespace APBD_14._05.Services
{
    public class DoctorsServiceDataBase : IServiceDataBase
    {
        private readonly ClinicDbContext _context;

        public DoctorsServiceDataBase(ClinicDbContext context)
        {
            _context = context;
        }

        public IActionResult GetDoctor(int index)
        {
            var result = _context.Doctor.SingleOrDefault(e => e.IdDoctor == index);
            return new OkObjectResult(result);
        }

        public IActionResult EnrollDoctor(EnrollDoctorRequest request)
        {
            var doctorExist = _context.Doctor.Any(doctor => doctor.IdDoctor == request.IdDoctor);
            if (doctorExist) return new BadRequestResult();

            var result = _context.Doctor.Add(new Doctor()
            {
                IdDoctor = request.IdDoctor,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            });
            _context.SaveChanges();
            return new OkObjectResult(result);
        }

        public IActionResult ModifyDoctor(ModiefiedDoctorRequest request)
        {
            var result = _context.Doctor.FirstOrDefault(student => student.IdDoctor == request.IdDoctor);
            if (result != null)
            {
                result.FirstName = request.FirstName;
                result.LastName = request.LastName;
                result.Email = request.Email;
            }

            _context.SaveChanges();
            return new OkObjectResult(result);
        }

        public IActionResult RemoveDoctor(int index)
        {
            var toDelete = _context.Doctor.Where(doctor => doctor.IdDoctor == index);

            if (!toDelete.Any()) return new NotFoundResult();

            _context.Doctor.Remove(toDelete.First());
            _context.SaveChanges();
            return new OkResult();
        }
    }
}