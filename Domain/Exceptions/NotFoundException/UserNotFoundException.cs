﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.NotFoundException
{
    public sealed class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(Guid userId)
            : base($"The user with the identifier {userId} was not found.")
        {
        }
    }
}
