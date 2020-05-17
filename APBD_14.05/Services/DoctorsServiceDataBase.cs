using APBD_14._05.DTO.Request;
using Microsoft.AspNetCore.Mvc;

namespace APBD_14._05.Services
{
    public class DoctorsServiceDataBase : IServiceDataBase
    {
        public IActionResult GetDoctor(int index)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult EnrollDoctor(EnrollDoctorRequest request)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult ModifyDoctor(ModiefiedDoctorRequest request)
        {
            throw new System.NotImplementedException();
        }

        public IActionResult RemoveDoctor(int index)
        {
            throw new System.NotImplementedException();
        }
    }
}