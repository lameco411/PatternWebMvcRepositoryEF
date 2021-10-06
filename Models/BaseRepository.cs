using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.Configs;

namespace WebApp.Models
{
    public class BaseRepository
    {       
        protected static WebAppContext context;
        public BaseRepository()
        {            
            context = new WebAppContext();
        } 
    }
}
