using SPWebAPI.Repository;
using SPWebAPI.Repository.IRepositoryn;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


app.UseHttpsRedirection();

app.MapControllers();

app.Run();