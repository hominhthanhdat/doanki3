using Microsoft.EntityFrameworkCore;
using ProjectSemester3;
using ProjectSemester3.Models;
using ProjectSemester3.Services;

var builder = WebApplication.CreateBuilder(args);

//cấp quyền để gọi api tới angular 
builder.Services.AddCors();


builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.Converters.Add(new DateConverter());
});

builder.Services.AddScoped<CareerService, CareerServiceImpl>();

//mapping db vào file databaseContext
var connString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<DatabaseContext>(options => options.UseLazyLoadingProxies().UseSqlServer(connString));

var app = builder.Build();

app.UseRouting();
//cấp quyền để gọi api tới angular
app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );

app.MapControllers();
app.Run();
