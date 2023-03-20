using Microsoft.Extensions.DependencyInjection;

namespace WWB.Paylink.BaoFooTransfer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBaoFooTransPay(this IServiceCollection services)
        {
            services.AddHttpClient(BaoFooTransClient.Name);
            services.AddSingleton<IBaoFooTransClient, BaoFooTransClient>();
            services.AddSingleton<IBaoFooTransNotifyClient, BaoFooTransNotifyClient>();
        }
    }
}