using EticaretAPI.SignalR.HubServices;
using ETicaretAPI.Application.Abstractions.Hubs;
using Microsoft.Extensions.DependencyInjection;

namespace EticaretAPI.SignalR
{
    public static class ServiceRegistration
    {
        public static void AddSignalRServices(this IServiceCollection services)
        {
            services.AddTransient<IProductHubService, ProductHubService>();
            services.AddTransient<IOrderHubService, OrderHubService>();
            services.AddSignalR();
        }
    }
}
