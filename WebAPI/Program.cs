
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IProductService, ProductManager>(); 
            builder.Services.AddSingleton<IProductDal, EfProductDal>();
            builder.Services.AddSingleton<ICategoryService, CategoryManager>();
            builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();
            builder.Services.AddSingleton<ICustomerService, CustomerManager>();
            builder.Services.AddSingleton<ICustomerDal, EfCustomerDal>();
            builder.Services.AddSingleton<IOrderService, OrderManager>();
            builder.Services.AddSingleton<IOrderDal, EfOrderDal>();





            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
