using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodieHub.DTOLayer.DTOs.SliderDtos
{
    public class GetByIdSliderDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
