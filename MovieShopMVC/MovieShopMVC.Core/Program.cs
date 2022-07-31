using MovieCRM.Core.Contracts.Repository;
using MovieCRM.Core.Contracts.Service;
using MovieCRM.Infrastructure.Data;
using MovieCRM.Infrastructure.Repository;
using MovieCRM.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Connect to my database.
builder.Services.AddSqlServer<MovieShopDbContext>(builder.Configuration.GetConnectionString("MovieShop"));
builder.Services.AddScoped<IActorsRepositoryAsync, ActorsRepositoryAsync>();
builder.Services.AddScoped<IActorServerAsync, ActorsServerAsync>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
