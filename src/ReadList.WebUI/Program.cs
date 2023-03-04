using ReadList.Data.Configuration;
using ReadList.Data.Models;
using ReadList.Services.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ReadListDatabaseSettings>(
    builder.Configuration.GetSection("ReadListDatabase"));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddReadListData(builder.Configuration);

builder.Services.AddReadListServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

await app.CreateDatabaseIfNotExistsAsync();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
