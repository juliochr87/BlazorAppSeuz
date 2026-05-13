using System.Data;
using BlazorAppSeuz.Data;
using BlazorAppSeuz.IServices;
using BlazorAppSeuz.Services;
using BlazorAppZeuz.Components;
using BlazorAppZeuz.Data;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMudServices();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICamionService,CamionService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration
            .GetConnectionString("MariaDb"),
        ServerVersion.AutoDetect(
            builder.Configuration
                .GetConnectionString("MariaDb")
        )
    ));

builder.Services.AddDbContext<ZeuzDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("ZeuzDb"),
        ServerVersion.AutoDetect(
            builder.Configuration.GetConnectionString("ZeuzDb")
        )
    ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();