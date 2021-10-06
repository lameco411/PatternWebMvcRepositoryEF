using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.Class;

namespace WebApp.Models.Repository
{
    public class CategoryRepository:BaseRepository
    {
        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
        public Category GetCategoryById(int id)
        {
            Category obj = context.Categories.FirstOrDefault(x => x.CategoryId == id);
            return obj;
        }
        public int Add(Category obj)
        {
            context.Categories.Add(obj);
            return context.SaveChanges();
        }
        public int Edit(Category obj)
        {
            context.Categories.Update(obj);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            var obj = context.Categories.FirstOrDefault(x => x.CategoryId == id);
            context.Categories.Remove(obj);
            return context.SaveChanges();
        }
    }
}
