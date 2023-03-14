using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Contracts.DTO
{
    public class RoleForCreationDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(120, ErrorMessage = "Name can't be longer than 120 characters")]
        public string RoleName { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(250, ErrorMessage = "Description cannot be loner then 250 characters")]
        public string RoleDescription { get; set; }


        [Required(ErrorMessage = "Permission is required")]
        public Guid permissionsId { get; set; }
    }
}
