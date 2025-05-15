using Microsoft.EntityFrameworkCore;
using SistemaClinica.Infrastructure.Context;
using SistemaClinica.Domain.Interfaces;
using SistemaClinica.Infrastructure.Repositories;
using SistemaClinica.Application.Services;
using Microsoft.EntityFrameworkCore.InMemory; 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// 💾 Conexión a la base de datos
builder.Services.AddDbContext<ClinicaDbContext>(options =>
    options.UseInMemoryDatabase("ClinicaDb")); 

// 🧩 Inyección de dependencias
builder.Services.AddScoped<IPacienteRepositorio, PacienteRepositorioEF>();
builder.Services.AddScoped<PacienteService>();

// MVC
builder.Services.AddControllersWithViews();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
