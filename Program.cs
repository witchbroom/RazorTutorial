using ContosoPets.Ui.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

/*
IServiceCollection collection = new ServiceCollection();
collection.AddRazorPages();
collection.AddDbContext<ContosoPetsContext>(options =>
options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ContosoPets; Integrated Security = True; ConnectRetryCount = 0"));
*/

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ContosoPetsContext>(options =>
options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ContosoPets; Integrated Security = True; ConnectRetryCount = 0"));

var app = builder.Build();

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
