using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Models
{
    public class Product
    {
        public int Id { set; get; }
    
        [Display(Name = "Name")]
        [Required(ErrorMessage="prodcut name required")]
        [StringLength(50, ErrorMessage="Max lenght 50 chars")]
        public string ProductName { set; get; }
        public int CategoryId { set; get; }
        public Category Category { set; get; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price required")]
        [DataType(DataType.Currency)]
        public decimal UintPrice { set; get; }
    }
}