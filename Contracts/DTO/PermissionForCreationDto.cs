using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Contracts.DTO
{
    public class PermissionForCreationDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(120, ErrorMessage = "Name can't be longer than 120 characters")]
        public string permissionName { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(250, ErrorMessage = "Description cannot be loner then 250 characters")]
        public string permissionDescription { get; set; }
    }
}
