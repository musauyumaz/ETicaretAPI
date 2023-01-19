using EticaretAPI.SignalR.Hubs;
using Microsoft.AspNetCore.Builder;

namespace EticaretAPI.SignalR
{
    public static class HubRegistration
    {
        public static void MapHubs(this WebApplication webApplication)
        {
            webApplication.MapHub<ProductHub>("/products-hub");
            webApplication.MapHub<OrderHub>("/orders-hub");
        }
    }
}
