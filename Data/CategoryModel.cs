using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.server2.Data
{
    public class CategoryModel 
    {
        [Key]
        public int Id { get; set; }
        public string CateName { get; set; }    
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<ProductModel> ProductList { get; set; }

        public CategoryModel()
        {
            this.ProductList = new HashSet<ProductModel>();
            this.CreatedDate = DateTime.Now;
        }
    }
}