using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GamePickerWeb.Data;
using GamePickerWeb.Models;
using GamePickerWeb.Pages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<GamePickerWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GamePickerWebContext") ?? throw new InvalidOperationException("Connection string 'GamePickerWebContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedDataModel.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
