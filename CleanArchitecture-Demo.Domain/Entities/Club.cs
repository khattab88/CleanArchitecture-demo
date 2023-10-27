using CleanArchitecture_Demo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture_Demo.Domain.Entities
{
    public class Club : BaseAuditableEntity
    {
        public string Name { get; set; }
    }
}
