using Microsoft.OpenApi.Models;
using Todo_List_Manager___BE.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("https://localhost:4200")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddSingleton<MongoDbService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Todo_List_Manager_BE", Version = "v1" });
});

var app = builder.Build();

// swagger url = https://localhost:7018/swagger/index.html
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo_List_Manager_BE v1");
    c.RoutePrefix = "swagger";
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run("https://localhost:7018");