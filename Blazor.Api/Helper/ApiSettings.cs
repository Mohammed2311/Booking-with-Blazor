using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Api.Helper
{
    public class ApiSettings
    {
        public string SecretKey { get; set; }
        public string ValidAudience { get; set; }
        public string ValidIssuer { get; set; }
    }
}
