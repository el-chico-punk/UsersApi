using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.NotFoundException
{
    public sealed class RoleNotFoundException : NotFoundException
    {
        public RoleNotFoundException(Guid roleId)
            : base($"The role with the identifier {roleId} was not found.")
        {
        }
    }
}
