using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop_Haumova.Data.DataBase;
using Shop_Haumova.Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICategorys, DBCategory>();
builder.Services.AddTransient<IItems, DBItems>();
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Items}/{action=List}/{id?}");

app.Run();