using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterAPI.Controllers
{
    public class RestaurantListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public float AverageScore { get; set; }
    }
}