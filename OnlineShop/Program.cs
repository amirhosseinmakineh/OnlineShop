using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Application.Service.Services;
using OnlineShop.ApplicationService.Contract.IServices;
using OnlineShop.Domain;
using OnlineShop.Domain.IRepository;
using OnlineShop.InfraStructure.Context;
using OnlineShop.InfraStructure.Repository;
using OnlineShop.InfraStructure.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);
#region AutoFact
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(x =>
{
    x.RegisterType<UnitOfWorkInterceptor>();
    x.RegisterType<ProductService>().As<IProductService>().EnableClassInterceptors().InterceptedBy(typeof(UnitOfWorkInterceptor));
}));
#endregion
builder.Services.AddDbContext<OnlineShopContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineShop"));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
#region RegisterRepository
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISliderRepository, SliderRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IEmailRepository, EmailRepository>();
#endregion
#region RegisterService
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IEmailService, EmailService>();
#endregion

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();
app.MapControllers();
app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
