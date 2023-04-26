using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using proj_andre_turismo_api_EF.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<proj_andre_turismo_api_EFContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("proj_andre_turismo_api_EFContext") ?? throw new InvalidOperationException("Connection string 'proj_andre_turismo_api_EFContext' not found.")));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
