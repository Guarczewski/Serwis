using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serwis.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ServiceContext>(options => options.UseSqlServer("" +
    "Data Source=DESKTOP-A7OQ6QG;" +
    "Database=Warehouse;" +
    "User ID=Bazownik;" +
    "Password=q;" +
    "Integrated Security=True;" +
    "Connect Timeout=30;" +
    "Encrypt=True;" +
    "Trust Server Certificate=True;" +
    "Application Intent=ReadWrite;" +
    "Multi Subnet Failover=False;" 
    ));


builder.Services.AddCors(options => {
    options.AddPolicy("CorsPolicy", builder =>
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddIdentity<Worker, IdentityRole>().AddEntityFrameworkStores<ServiceContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseCors("CorsPolicy");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
