using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Models
{
    public class Category
    {
        public int Id { set; get; }
        [Display(Name = "Category")]
        public string CategoryName { set; get; }
        public ICollection<Product> Products { set; get; }
    }
}
