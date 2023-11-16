using Ecommerce_API.Models;
using Ecommerce_API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<Game_DBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ChuoiKetNoi"));
});
builder.Services.AddScoped<ICategoriesRepo,CategoriesRepo>();
builder.Services.AddScoped<IDevRepo,DevRepo>();
builder.Services.AddScoped<IClientRepo,ClientRepo>();
builder.Services.AddScoped<IAdminRepo,AdminRepo>();
builder.Services.AddScoped<IOrderRepo,OrderRepo>();



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
