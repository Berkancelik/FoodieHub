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
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(AppDbContext context) : base(context)
        {
        }
    }
}