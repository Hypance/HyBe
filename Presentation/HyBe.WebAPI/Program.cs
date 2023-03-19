
using HyBe.Application;
using HyBe.Persistence;
using HyBe.Infrastructure;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddInfrastructureServices();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(m=> m.SwaggerDoc("v1",new Microsoft.OpenApi.Models.OpenApiInfo()
{
    Title = "Hypance Backend Project",
    Version = "v1",
    License = new Microsoft.OpenApi.Models.OpenApiLicense() { Name ="Hypance"}
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

