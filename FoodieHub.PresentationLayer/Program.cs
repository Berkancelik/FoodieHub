using FoodieHub.BusinessLayer.Abstract;
using FoodieHub.BusinessLayer.Concrete;
using FoodieHub.DataAccessLayer.Abstract;
using FoodieHub.DataAccessLayer.Context;
using FoodieHub.DataAccessLayer.EntityFramework;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);





builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<ISliderDal, EfSliderDal>();
builder.Services.AddScoped<ISliderService, SliderManager>();

builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IAboutItemDal, EfAboutItemDal>();
builder.Services.AddScoped<IAboutItemService, AboutItemManager>();

builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();
builder.Services.AddScoped<IFeatureService, FeatureManager>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();



app.UseStatusCodePages(async x =>
{
    if (x.HttpContext.Response.StatusCode == 404)
    {
        x.HttpContext.Response.Redirect("/ErrorPages/Index/");
    };
});


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
