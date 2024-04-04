using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

// Identity services
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>(x =>
{
    x.Password.RequireUppercase = false; // Büyük harf mecburiyeti kalkar
    x.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<Context>();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x =>
    {
        x.LoginPath = "/Login/Index";
    });

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie Settings
    options.Cookie.HttpOnly = true; // çerezlerin tarayýcý tarafýndan sadece HTTP istekleri ile eriþilebilir olmasýný saðlar
    options.ExpireTimeSpan = TimeSpan.FromMinutes(100); // çerezlerin ne kadar süre boyunca geçerli alacaðýný belirtir
    options.LoginPath = "/Login/Index"; // kimlik doðrulama iþlemi gerektiðinde kullanýcýnýn yönlendirileceði girip sayfasýnýn yolunu belirtir
    options.SlidingExpiration = true; // çerezin süresinin otomatik olarak uzatýlmasýný saðlar
});

var app = builder.Build();

// Yönlendirme ayarlarý
app.UseRouting();

app.UseAuthentication(); // Burada authentication middleware'ini ekledik

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.Run();
