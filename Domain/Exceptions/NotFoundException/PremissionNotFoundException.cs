using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.NotFoundException
{
    public sealed class PremissionNotFoundException : NotFoundException
    {
        public PremissionNotFoundException(Guid permissionId)
            : base($"The permission with the identifier {permissionId} was not found.")
        {
        }
    }
}
