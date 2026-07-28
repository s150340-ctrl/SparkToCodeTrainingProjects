using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task_8_EF.Models
{
    [PrimaryKey(nameof(ReviewId), nameof(OrderId))]
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewComment{ get; set; }
        public double ReviewRating { get; set; }

        //each review has 1 order  1-1
        [ForeignKey("order")]

        public int OrderId { get; set; }
        public Order order { get; set; }

    }
}
