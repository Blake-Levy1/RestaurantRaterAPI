using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterAPI.Properties.Models
{
    public class RatingEdit
    {
        public float Score { get; set; }
        public int RestaurantId { get; set; }
    }
}