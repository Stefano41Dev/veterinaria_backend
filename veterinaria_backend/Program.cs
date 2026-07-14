using Microsoft.EntityFrameworkCore;
using veterinaria_backend.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
// Configure Connection String
var cn = builder.Configuration.GetConnectionString("DefaultConnection")?? throw new InvalidOperationException("La cadena de conexión no se encontró.");


builder.Services.AddDbContext<DbVeterinarySjlContext>(
    options => options.UseSqlServer(cn)
    );
// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
