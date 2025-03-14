using System.Net;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using lemonPharmacy.Common.Domain;
using lemonPharmacy.Common.Utils.Extensions;

namespace lemonPharmacy.Common.Infrastructure.Kestrel
{
    public static class Extensions
    {
        public static KestrelServerOptions ListenHttpAndGrpcProtocols(
            this KestrelServerOptions options,
            IConfiguration config)
        {
            options.Limits.MinRequestBodyDataRate = null;

            // todo: do a better way, instead of based on PORT env variable (Tye generated)
            var ports = config.GetValue<string>("PORT").Split(";");
            if (ports.Length != 2)
            {
                throw new DomainException("Wrong binding port and protocols");
            }

            // rest
            options.Listen(IPAddress.Any, ports[0].ConvertTo<int>());

            // grpc
            options.Listen(IPAddress.Any,
                ports[1].ConvertTo<int>(),
                listenOptions => { listenOptions.Protocols = HttpProtocols.Http2; });

            return options;
        }
    }
}
