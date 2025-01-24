using ManipulationImage.Core.Services;
using ManipulationImage.Data;
using ManipulationImage.Interfaces;
using ManipulationImage.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("default"))
);

builder.Services.AddTransient<ApplicationDbContext>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IFileService, FileService>();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader(); ;
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "Uploads")),
    RequestPath = "/Resources"
});

app.UseCors(); 

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

// https://ravindradevrani.medium.com/image-upload-crud-operations-in-net-core-apis-7407f111d2f4
// https://github.com/rd003/ImageManipulation_APIs_DotNetCore/blob/master/ImageManipulation.Data/ImageManipulation.Data.csproj