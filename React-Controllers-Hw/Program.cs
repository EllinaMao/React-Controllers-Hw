using React_Controllers_Hw.Models.Courses;
using React_Controllers_Hw.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICourceRepository, CourceRepository>();
builder.Services.AddSingleton<CourceServices>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
