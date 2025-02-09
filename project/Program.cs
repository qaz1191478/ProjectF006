var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseWebRoot("wwwroot"); // ตรวจสอบว่า wwwroot มีอยู่หรือไม่

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization(); // เพิ่มบริการ Authorization

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization(); // เรียกใช้ Authorization ที่เพิ่มบริการไว้ก่อนหน้า

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
