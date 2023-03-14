using System;
using System.ComponentModel.DataAnnotations;

namespace Contracts.DTO
{
    public class PermissionForUpdateDto
    {

        [Required(ErrorMessage = "Description is required")]
        [StringLength(250, ErrorMessage = "Description cannot be loner then 250 characters")]
        public string permissionDescription { get; set; }
    }
}
