using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_8_EF.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }


        //contain realtionship betweeen Order and product M-M
     
        public List<ProdOrder> ProdOrderList { get; set; }


        //user places many orders  1-M
        [ForeignKey("user")]
        public int UserID { get; set; }
        public User user { get; set; }

        // each order 1 review   1-1
        public Review review { get; set; }

    }
}
