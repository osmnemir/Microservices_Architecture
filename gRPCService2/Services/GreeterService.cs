using Grpc.Core;
using gRPCService2;

namespace gRPCService2.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override async Task SayHello(HelloRequest request, IServerStreamWriter<HelloReply> responseStream, ServerCallContext context)
        {
            await Task.Run(async() =>
            {
                int count = 0;
                while (++count <= 0)
                {
                    await Task.Delay(1000);
                    responseStream.WriteAsync(new HelloReply() { Message = $"Gönderilen Mesaj: {count}" });

                }
            });
        }
    }
}