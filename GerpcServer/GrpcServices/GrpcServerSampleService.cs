using Google.Protobuf.WellKnownTypes; //Empty tipi gRPC protokolüne ait bir tiptir. Bu Tipi kullanabilmek için eklememiz gerekiyor.
using Grpc.Core; // Grpc istekleri karşılayabilmemiz için eklememiz gerekiyor.
using SampleGrpcServer; // Proto dosyamızın namespacesi

namespace GrpcServer.GrpcServices;

//Proto dosyamız için auto generated kodun partial class'ının miras alıyoruz.
public class GrpcServerSampleService : SampleGrpc.SampleGrpcBase
{
    // Burada projemize inject etmek istediğimiz herşeyi tanımlayıp kullanabiliriz.
    private readonly ILogger<GrpcServerSampleService> _logger;

    public GrpcServerSampleService(ILogger<GrpcServerSampleService> logger)
    {
        _logger = logger;
    }

    // Proto dosyamız içerisinde tanımladığımız 'SampleGrpcMethod' metodunu eziyoruz.
    // Auto generated partial class içinde tanımladığımız 'SampleGrpcMethod' metodunu eziyoruz.
    // Client'ın erişeceği metodumuzu tanımlıyoruz.
    public override async Task<SampleGrpcResponseModel> SampleGrpcMethod(Empty request, ServerCallContext context)
    {
        // Bu metodu iş yapmak için kullanabilirsiniz fakat önermem.
        // Tercih ettiğiniz mimariye göre burada MediatR, Factory metot gibi yöntemleri kullanabilirsiniz.
        
        _logger.LogInformation("Hi guys!");

        var response = new SampleGrpcResponseModel //Proto dosyamız içinde tanımladığımız modeli oluşturuyoruz.
        {
            // Şimdi ilginç bir yere geldik.
            // Proto dosyamızın içinde snack_case ile tanımladığımız property isimleri burada PascalCase olarak geldi.
            // Bunun için makalede gRPC naming convension ile ilgili olarak bir kaynak bırakcağım.
            SampleStringProperty = "Hello" 
        };

        return response;
    }
}
