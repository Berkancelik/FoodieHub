using FoodieHub.DataAccessLayer.Abstract;
using FoodieHub.DataAccessLayer.Context;
using FoodieHub.DataAccessLayer.Repositories;
using FoodieHub.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodieHub.DataAccessLayer.EntityFramework
{
    public class EfAboutItemDal : GenericRepository<AboutItem>, IAboutItemDal
    {
        public EfAboutItemDal(AppDbContext context) : base(context)
        {
        }
    }
}