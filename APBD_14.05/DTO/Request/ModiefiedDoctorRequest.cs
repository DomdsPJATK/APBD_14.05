using System.ComponentModel.DataAnnotations;

namespace APBD_14._05.DTO.Request
{
    public class ModiefiedDoctorRequest
    {
        [Required]
        public int IdDoctor { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}