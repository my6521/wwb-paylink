namespace WWB.Paylink.BaoFooPay.Extensions
{
public static class ServiceCollectionExtensions
{
    public static void AddHsqPay(this IServiceCollection services)
    {
            services.AddHttpClient(BaoFooPayClient.Name);
            services.AddSingleton<IBaoFooPayClient, BaoFooPayClient>();
            services.AddSingleton<IBaoFooPayNotifyClient, BaoFooPayNotifyClient>();
        }
    }
}