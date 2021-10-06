using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Class
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(100)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }           
        public virtual Category Category { get; set; } 
        public void PrintInfo()
        {
            Console.WriteLine($"Id= {ProductId}, Name ={ProductName}, Price ={Price} category 1:{Category.CategoryName}");
        }  
    }
}
