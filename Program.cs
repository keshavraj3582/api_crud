using web_api_crud.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Net;
using web_api_crud.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

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


app.UseSwagger();
app.UseSwaggerUI(options=>
{
    options.DocumentTitle="T_A_G Demo Crud Api";
}); 

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseExceptionHandler("/error");
app.UseMiddleware<ExceptionHandlingMiddleware>();


app.MapControllers();

app.Run();
