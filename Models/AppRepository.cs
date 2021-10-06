using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.Repository;

namespace WebApp.Models
{
    public class AppRepository
    {
            
                CategoryRepository category;
                public CategoryRepository Category
                {
                    get
                    {
                        if (category is null)
                        {
                            category = new CategoryRepository();
                        }
                        return category;
                    }
                }
         
    }
}
