using FoodieHub.DataAccessLayer.Abstract;
using FoodieHub.DataAccessLayer.Context;
using FoodieHub.DataAccessLayer.Repositories;
using FoodieHub.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodieHub.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly AppDbContext _context;
        public EfProductDal(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            var values = _context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public List<Product> ProductListWithCategoryAndLast12Items()
        {
            var values = _context.Products.OrderByDescending(x => x.Id).Take(12).Include(y => y.Category).ToList();
            return values;
        }
    }
}