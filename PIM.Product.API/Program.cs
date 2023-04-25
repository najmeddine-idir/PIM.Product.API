using PIM.Product.Domain.Converters.Abstractions;
using PIM.Product.Domain.Repositories.Abstractions;
using PIM.Product.Domain.Services.Abstractions;
using PIM.Product.Infrastructure.Configurations;
using PIM.Product.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ProductDatabaseConfiguration>(
    builder.Configuration.GetSection("ProductDatabase"));

builder.Services
    .AddSingleton<IProductRepository, ProductRepository>()
    .AddSingleton<IProductService, ProductService>()
    .AddSingleton<IProductConverter, ProductConverter>();

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
