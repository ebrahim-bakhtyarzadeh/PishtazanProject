using Microsoft.EntityFrameworkCore;
using Project_Infrastructure.Persistent.Ef;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Project_EFContext>(option =>
{
    option.UseSqlServer("Data Source =.; Initial Catalog=Pishtazan_DB; Integrated security =true; TrustServerCertificate=true");
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
