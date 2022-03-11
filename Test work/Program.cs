using Microsoft.EntityFrameworkCore;
using Test_work;
using Test_work.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration.Bind("Project", new Config());

builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(Config.ConnectionString.DefaultConnection);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
