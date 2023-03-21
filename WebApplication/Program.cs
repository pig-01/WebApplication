using Microsoft.AspNetCore.Authentication.Cookies;
using WebApplication1.CookieAuthentication;
using WebApplication1.DataAccess.ContosoModels;
using Serilog;
using Serilog.Events;
using WebApplication1.Service.Repositories;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.Seq("http://localhost:5341", apiKey: "qeM7XTAcMHJeWomPVYtF")
    .CreateLogger();

try
{
    Log.Information("Starting web application");

    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog(); // TODO: Move this line to after 'var builder = ...' line

    // Add services to the container.
    builder.Services.AddControllersWithViews();

    builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.EventsType = typeof(CustomCookieAuthenticationEvents);
        });

    builder.Services.AddSqlServer<ContosoUniversityContext>(builder.Configuration.GetConnectionString("DefaultConnection"));

    builder.Services.AddScoped<IUserRepository, UserRepository>();
    builder.Services.AddScoped<CustomCookieAuthenticationEvents>();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    
    app.UseAuthentication();
    app.UseAuthorization();

    app.UseStaticFiles();
    app.UseRouting();

    app.MapControllerRoute(
        name: "MyArea",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();

}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}

