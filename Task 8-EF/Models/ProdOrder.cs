using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_8_EF.Models
{
    [PrimaryKey(nameof(ProductId),nameof(OrderId))]
    public class ProdOrder
    {
        //contain realtionship betweeen Order and product M-M
        [ForeignKey("product")]
        public int ProductId { get; set; }
        public Product product { get; set; }

        [ForeignKey("order")]
        public int OrderId { get; set; }
        public Order order { get; set; }

        public int Quantity { get; set; }
    }
}
