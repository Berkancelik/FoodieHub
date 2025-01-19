using FoodieHub.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodieHub.DataAccessLayer.Abstract
{
    public interface IFeatureDal : IGenericDal<Feature>
    {
        List<Feature> FeatureListByStatusTrue();
    }
}