using AutoMapper;
using BusinessLayer.Manager;
using BusinessLayer.Mapping;
using BusinessLayer.Services;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IProductService, ProductManager>();
builder.Services.AddTransient<ICategoryService, CategoryManager>();
builder.Services.AddTransient<IProductDal, EfProductRepository>();
builder.Services.AddTransient<ICategoryDal, EfCategoryRepository>();

builder.Services.AddDbContext<Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Connectionstring")));
builder.Services.AddMemoryCache();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
