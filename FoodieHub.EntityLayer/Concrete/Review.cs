using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodieHub.EntityLayer.Concrete
{
    public class Review
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public bool CustomerTitle { get; set; }
        public bool Comment { get; set; }
        public bool ImageUrl { get; set; }
    }
}
