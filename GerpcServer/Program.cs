using GrpcServer.GrpcServices;

var builder = WebApplication.CreateBuilder(args);

// gRPC servislerimizi kullanabilmek için gRPC servislerini ekliyoruz.
builder.Services.AddGrpc(options => { options.EnableDetailedErrors = true; });

// Add services to the container.
var app = builder.Build();

//Servisimizi tanýmlýyoruz.
app.MapGrpcService<GrpcServerSampleService>();

app.Run();
