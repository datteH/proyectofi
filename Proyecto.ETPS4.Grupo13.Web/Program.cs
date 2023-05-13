using AspNetCoreHero.ToastNotification;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Proyecto.ETPS4.Grupo13.Web.extensions;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.
services.ConfigureRepositoryManager();
services.AddRouting(options => options.LowercaseUrls = true);
services.ConfigureSqlContext(builder.Configuration);
services.ConfigureServiceManager();
services.AddAuthentication();
services.ConfigureIdentity();
services.AddMemoryCache();
services.AddHttpContextAccessor();
services.AddAutoMapper(typeof(Program));
services.AddNotyf(config => {
    config.DurationInSeconds = 10;
    config.IsDismissable = true;
    config.Position = NotyfPosition.TopCenter;
});
services.AddControllersWithViews();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();