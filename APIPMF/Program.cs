using APIPMF.Database.Repository;
using APIPMF.Services;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactonsService, TransactionService>();

builder.Services.AddDbContext<TransactionDbContext>(options => {

    options.UseNpgsql(CreateConnectionString(builder.Configuration));
});

 static string CreateConnectionString(IConfiguration configuration)
{
    var username = Environment.GetEnvironmentVariable("DATABASE_USERNAME") ?? configuration["Database:Username"];
    var password = Environment.GetEnvironmentVariable("DATABASE_PASSWORD") ?? configuration["Database:Password"];
    var database = Environment.GetEnvironmentVariable("DATABASE_NAME") ?? configuration["Database:Name"];
    var host = Environment.GetEnvironmentVariable("DATABASE_HOST") ?? configuration["Database:Host"];
    var port = Environment.GetEnvironmentVariable("DATABASE_PORT") ?? configuration["Database:Port"];

    var builder = new NpgsqlConnectionStringBuilder()
    {
        Host= host,
        Port=int.Parse(port),
        Username= username,
        Password= password,
        Database= database,
        Pooling=true
    };
    return builder.ConnectionString;
}

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
