using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Configs
{
    public class ConnectionString
    {
        public string DefaultConnection { get; set; }
        public string WebAppConnection { get; set; }
        public string HangfireConnection { get; set; }
    }
}
