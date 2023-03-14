using System;
using System.ComponentModel.DataAnnotations;

namespace Contracts.DTO
{
    public class RoleForUpdateDto
    {


        [Required(ErrorMessage = "Description is required")]
        [StringLength(250, ErrorMessage = "Description cannot be loner then 250 characters")]
        public string RoleDescription { get; set; }


        [Required(ErrorMessage = "Permission is required")]
        public Guid permissionsId { get; set; }
    }
}
