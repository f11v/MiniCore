using Microsoft.EntityFrameworkCore;
using MiniCore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MinicoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IngenieriaWebConnection")));

// Agregar soporte para sesiones
builder.Services.AddDistributedMemoryCache(); // Utiliza el caché en memoria. Para producción, considera otras implementaciones.
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Configura el tiempo de expiración de la sesión.
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; // Marca la cookie de sesión como esencial.
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
