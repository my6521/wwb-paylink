using Microsoft.Extensions.DependencyInjection;

namespace WWB.Paylink.JoinPay.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddJoinPay(this IServiceCollection services)
        {
            services.AddHttpClient(JoinPayClient.Name);
            services.AddSingleton<IJoinPayClient, JoinPayClient>();
            services.AddSingleton<IJoinPayNotifyClient, JoinPayNotifyClient>();
        }
    }
}