using GrpcServer.GrpcServices;

var builder = WebApplication.CreateBuilder(args);

// gRPC servislerimizi kullanabilmek i�in gRPC servislerini ekliyoruz.
builder.Services.AddGrpc(options => { options.EnableDetailedErrors = true; });

// Add services to the container.
var app = builder.Build();

//Servisimizi tan�ml�yoruz.
app.MapGrpcService<GrpcServerSampleService>();

app.Run();
