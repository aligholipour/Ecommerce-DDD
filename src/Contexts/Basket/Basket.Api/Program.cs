using Basket.Application.ShoppingCarditems.UseCases.Commands;
using Basket.Domain.Contracts;
using Basket.Infrastructure.Data;
using Basket.Infrastructure.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlServer<ShoppingDbContext>(builder.Configuration.GetConnectionString("DefaultConnection"));

builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddMediatR(typeof(CreateShoppingCartItemCommand));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
