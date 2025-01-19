using FoodieHub.BusinessLayer.Abstract;
using FoodieHub.DataAccessLayer.Abstract;
using FoodieHub.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodieHub.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TDelete(int id)
        {
            _aboutDal.Delete(id);
        }
        public List<About> TGetAll()
        {
            return _aboutDal.GetAll();
        }
        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }
        public void TInsert(About entity)
        {
            _aboutDal.Insert(entity);
        }
        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}