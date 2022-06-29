var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute("viewdata", "{controller=Home}/{action=Index}/{Id?}");

app.Run();
