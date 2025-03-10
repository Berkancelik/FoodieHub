﻿using FoodieHub.BusinessLayer.Abstract;
using FoodieHub.DataAccessLayer.Abstract;
using FoodieHub.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodieHub.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal FeatureDal)
        {
            _featureDal = FeatureDal;
        }
        public void TDelete(int id)
        {
            _featureDal.Delete(id);
        }

        public List<Feature> TFeatureListByStatusTrue()
        {
            return _featureDal.FeatureListByStatusTrue();
        }

        public List<Feature> TGetAll()
        {
            return _featureDal.GetAll();
        }
        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }
        public void TInsert(Feature entity)
        {
            _featureDal.Insert(entity);
        }
        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}