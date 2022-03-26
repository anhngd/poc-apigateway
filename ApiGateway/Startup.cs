using Microsoft.Extensions.DependencyInjection;
using Ocelot.Administration;
using Ocelot.DependencyInjection;

namespace ApiGateway;

public class Startup
{
    public virtual void ConfigureServices(IServiceCollection services)
    {
        services
            .AddOcelot()
            .AddAdministration("/administration", "secret");
    }
}