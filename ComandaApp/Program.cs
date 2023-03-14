using ComandaMVC.Repositories;
using ComandaMVC.Repositories.Impl;
using ComandaMVC.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IComandaRepository, ComandaRepositoriesFake>();
builder.Services.AddSingleton<ComandaService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Comanda}/{action=Index}/{id?}");

app.Run();
