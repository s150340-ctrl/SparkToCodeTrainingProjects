using System;
using System.Collections.Generic;
using System.Text;

namespace Task_8_EF.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewComment{ get; set; }
        public double ReviewRating { get; set; }
    }
}
