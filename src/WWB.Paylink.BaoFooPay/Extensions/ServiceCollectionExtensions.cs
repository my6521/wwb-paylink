namespace WWB.Paylink.BaoFooPay.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddHsqPay(this IServiceCollection services)
    {
        services.AddHttpClient(HsqPayClient.Name);
        services.AddSingleton<IHsqPayClient, HsqPayClient>();
        services.AddSingleton<IHsqPayNotifyClient, HsqPayNotifyClient>();
    }
}