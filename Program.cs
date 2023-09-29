using web_api_crud.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Net;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options=>
{
    options.SwaggerDoc("v1",
    new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title="T-A-G",
        Description="Demo Api Project K",
        Version="v1"
    });
    var filename=Assembly.GetExecutingAssembly().GetName().Name+".xml";
    var filepath=Path.Combine(AppContext.BaseDirectory,filename);
    options.IncludeXmlComments(filepath);
});
builder.Services.AddDbContext<ApiStudentDatabaseContext>(options=>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("constring"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())//commented 29
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
app.UseSwagger();
app.UseSwaggerUI(options=>
{
    options.DocumentTitle="T_A_G Demo Crud Api";
}); //added 29 at 11:11
// options=>{
//     options.SwaggerEndpoint("/swagger/v1/swagger.json","v1");
//     options.RoutePrefix=string.Empty;
//     options.DocumentTitle="T_A_G Demo Crud Api";
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
