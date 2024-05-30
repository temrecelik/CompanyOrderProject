using CompanyOrderProject.DataAccessLayer.Concrete;
using CompanyOrderProject.DataAccessLayer.Abstract;
using CompanyOrderProject.BusinessLayer.Abstract;
using CompanyOrderProject.DataAccessLayer.EntityFramework;
using CompanyOrderProject.BusinessLayer.Concrete;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped< ICompanyDal,EfCompanyDal>();
builder.Services.AddScoped<ICompanyService, CompanyManager>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();


builder.Services.AddScoped<IOrderDal, EfOrderDal>();
builder.Services.AddScoped<IOrderService, IOrderManager>();

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
