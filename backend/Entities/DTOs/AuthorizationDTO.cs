using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AuthorizationDTO : IDTO
    {
        public string AuthorizationName { get; set; }
        public bool[] Authorizations { get; set; }
    }
}
