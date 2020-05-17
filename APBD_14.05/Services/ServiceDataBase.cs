using APBD_14._05.DTO.Request;
using Microsoft.AspNetCore.Mvc;

namespace APBD_14._05.Services
{
    public interface IServiceDataBase
    {
        public IActionResult GetDoctor(int index);
        public IActionResult EnrollDoctor(EnrollDoctorRequest request);
        public IActionResult ModifyDoctor(ModiefiedDoctorRequest request);
        public IActionResult RemoveDoctor(int index);
    }
}