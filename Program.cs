using ArmadaBackend.Data;
using ArmadaBackend.StringBotanBuilders;
using ArmadaBackend.StringDecoders;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;


//homokozó:
string fleetCode = "F1#TesztNév#S:3[1,30,17,20];5[35,2,7]#Q:10;10;10;35;42#O:A=10;D=40;N=99;";
SeparateForTypes s = new SeparateForTypes(fleetCode);
Console.WriteLine($"({s.Version}), ({s.Name}), ({s.Ships}), ({s.Squadrons}), ({s.Objectives})");
Console.WriteLine(s.Version);
Console.WriteLine(s.Name);
ShipDecoder sd = new ShipDecoder(s.Ships);

Console.WriteLine($"{sd.Ships[0]}, {sd.Cards[0].Count}");
foreach(int elem in sd.Cards[0])
{
    Console.WriteLine(elem);
}
Console.WriteLine($"{sd.Ships[1]}, {sd.Cards[1].Count}");
foreach (int elem in sd.Cards[1])
{
    Console.WriteLine(elem);
}

SquadronDecoder qd = new SquadronDecoder(s.Squadrons);
foreach (int o in qd.Squadrons)
{
    Console.WriteLine(o);
}

ObjectiveDecoder ob = new ObjectiveDecoder(s.Objectives);
foreach(int obj in ob.Objectives)
{
    Console.WriteLine(obj);
}
//-----------------visszafelé-------------------//
List<(int ShipId, List<int> CardIds)> ships =
[
    (30, [1, 20, 80, 20]),
    (40, [90, 105, 10, 11, 12]),
    (5, [1, 2, 3, 4, 5])
];

ShipBuilder sb = new ShipBuilder(ships);

List<int> squadrons = new List<int> { 60,60,60,60,65 };
SquadronBuilder qb = new SquadronBuilder(squadrons);

List<int> objectives = new List<int> { 1,2,3 };
ObjectiveBuilder objBuilder = new ObjectiveBuilder(objectives);

BuilderOfBuilders bb = new BuilderOfBuilders("Laci cuca", sb.ShipString, qb.SquadronString, objBuilder.ObjectivesString);
Console.WriteLine($"({bb.FleetString})");


//-----|||-----//

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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





//connection string: "DefaultConnection": "Data Source=RESTASPC\\SQLEXPRESS;Database=Armada01;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=False"
