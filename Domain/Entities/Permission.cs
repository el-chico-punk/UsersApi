﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Permission
    {
        [Key]
        public Guid permissionIdentifier { get; set; }
        public string permissionName { get; set; }
        public string permissionDescription { get; set; }

        //Many To Many Relationship
        public ICollection<Role> roles { get; set; }
    }
}
