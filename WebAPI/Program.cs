using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

        builder.Host.ConfigureContainer<ContainerBuilder>(options =>
        {
            options.RegisterModule(new AutofacBusinessModule());
        });

        // Add services to the container.
        builder.Services.AddControllers();

      


        //builder.Services.AddSingleton <IProductService,ProductManager>();
        //builder.Services.AddSingleton<IProductDal, EfProductDal>();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

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

//using Autofac;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Hosting;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        CreateHostBuilder(args).Build().Run();
//    }

//    public static IHostBuilder CreateHostBuilder(string[] args) =>
//        Host.CreateDefaultBuilder(args)
//            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
//            .ConfigureContainer<ContainerBuilder>(builder =>
//            {
//                builder.RegisterModule(new AutofacBusinessModule());
//            })
//            .ConfigureWebHostDefaults(webBuilder =>
//            {
//                webBuilder.UseStartup<Startup>();
//            });
//}
