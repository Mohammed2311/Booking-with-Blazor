using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Client.Model
{
    public class HomeVM
    {
        public int NoOfNeights { get; set; } = 1;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
    }
}
