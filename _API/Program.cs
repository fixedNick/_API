using _API.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<UsersContext>(opts => 
opts.UseSqlServer(builder.Configuration.GetConnectionString("UsersContext")));


builder.Services.AddDbContext<ArticlesContext>(opts =>
opts.UseSqlServer(builder.Configuration.GetConnectionString("ArticlesContext")));

builder.Services.AddDbContext<AchievmentsContext>(opts =>
opts.UseSqlServer(builder.Configuration.GetConnectionString("AchievmentsContext")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
