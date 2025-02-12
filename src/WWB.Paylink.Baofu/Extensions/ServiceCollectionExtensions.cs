using WWB.Paylink.Baofu;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBaofuClient(this IServiceCollection services)
        {
            services.AddHttpClient(BaofuClient.Name);
            services.AddSingleton<IBaofuClient, BaofuClient>();
            services.AddSingleton<IBaofuNotifyClient, BaofuNotifyClient>();
        }
    }
}