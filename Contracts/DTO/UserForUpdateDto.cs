using System;
using System.ComponentModel.DataAnnotations;

namespace Contracts.DTO
{
    public class UserForUpdateDto
    {

        [Required(ErrorMessage = "phone is required")]
        public int userPhone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email is not in a rigth format")]
        [StringLength(250, ErrorMessage = "Email cannot be loner then 250 characters")]
        public string userEmail { get; set; }


        [Required(ErrorMessage = "Role is required")]
        public Guid roleId { get; set; }
    }
}
