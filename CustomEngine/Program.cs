using Microsoft.AspNetCore.Mvc;
using CustomEngine.Utils;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<MvcViewOptions>(options =>
{
    options.ViewEngines.Clear();
    options.ViewEngines.Add(new CustomViewEngine());
});
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");

app.Run();
