using APBD_14._05.DTO.Request;
using APBD_14._05.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_14._05.Controllers
{
    
    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {
        private readonly IServiceDataBase _service;
        
        public DoctorsController(IServiceDataBase service)
        {
            _service = service;
        }

        [HttpGet("{index}")]
        public IActionResult GetDoctor(int index)
        {
            return _service.GetDoctor(index);
        }

        [HttpPost("enroll")]
        public IActionResult EnrollDoctor(EnrollDoctorRequest request)
        {
            return _service.EnrollDoctor(request);
        }

        [HttpPost("modify")]
        public IActionResult ModifyDoctor(ModiefiedDoctorRequest request)
        {
            return _service.ModifyDoctor(request);
        }

        [HttpPost("remove/{index}")]
        public IActionResult RemoveDoctor(int index)
        {
            return _service.RemoveDoctor(index);
        }

    }
    
}