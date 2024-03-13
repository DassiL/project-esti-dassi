using Bl;
using Bl.BlApi;
using Bl.BlImplemntion;
using Bl.BlObject;
using Dal;
//using Dal.DalImplemntion;
//using Dal.DalObject;
using DataAccessLayer;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<BlManger >();

builder.Services.AddControllers();
//DBActions actions = new DBActions(builder.Configuration);

//DbConnection connection = new SqlConnection(String.Format(@"Data Source=.\SQLEXPRESS; Integrated Security=SSPI; AttachDbFilename={0}; User Instance=True; Initial Catalog=IPDatabase;", Location));

//var connString = actions.GetConnectionString("DB");
//builder.Services.AddDbContext<LibraryContext>(opt => opt.UseSqlServer(connString));builder.Services.AddMapster()

//builder.Services.AddScoped<IRepo<ProfessionalsMan>, ProfessionalsManRepo>();
//builder.Services.AddScoped<IRepo<AddressToClient>, AddressForClientRepo>();

var app = builder.Build();

//app.UseHttpsRedirection();
app.MapControllers();
app.MapGet("/", () => "Hello World!");
app.Run();
