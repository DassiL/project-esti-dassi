using Dal.DalApi;
using Dal.DalImplemntion;
using Dal.Models;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("DB");
builder.Services.AddDbContext<LibraryContext>(opt => opt.UseSqlServer(connString));

builder.Services.AddScoped<IProfessionalsManRepo, ProfessionalsManRepo>();

var app = builder.Build();
//app.UseHttpsRedirection();
app.MapControllers();
app.MapGet("/", () => "Hello World!");
app.Run();
