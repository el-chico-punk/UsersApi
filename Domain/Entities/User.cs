﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public Guid userIdentifier { get; set; }
        public string userName { get; set; }
        public int userPhone { get; set; }
        public string userPassword { get; set; }
        public string userEmail { get; set; }

        //Many To Many Relactionship
        public ICollection<Role> roles { get; set; }
    }
}
