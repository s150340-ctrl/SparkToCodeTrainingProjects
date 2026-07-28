using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_8_EF.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }


        //(has) 1 category  1-M
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        //contain realtionship betweeen Order and product M-M
    

        public List<ProdOrder> ProdOrderList { get; set; }
    }
}
