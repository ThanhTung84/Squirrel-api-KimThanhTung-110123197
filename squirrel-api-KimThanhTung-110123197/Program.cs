var builder = WebApplication.CreateBuilder(args);

// Đăng ký dịch vụ Controller
builder.Services.AddControllers();

var app = builder.Build();

// Cấu hình đọc file index.html mặc định và bật tài nguyên tĩnh
app.UseDefaultFiles(); 
app.UseStaticFiles();  

app.UseAuthorization();
app.MapControllers();

app.Run();