var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// DESKTOP-0SH5QUI
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Scaffold-DbContext "Server= DESKTOP-0SH5QUI\SQLEXPRESS; Database = DBLibrary; Trusted_Connection = True;" Microsoft.EntityFrameworkCore.SqlServer
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



/*Scaffold-DbContext "Server= DESKTOP-0SH5QUI\yasma; Database=DBLibrary; Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer*/