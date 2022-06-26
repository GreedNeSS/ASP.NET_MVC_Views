using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITimeService, TimeService>();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");

app.Run();
