namespace WWB.Paylink.BaoFooTransfer.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddBaofPay(this IServiceCollection services)
    {
        services.AddHttpClient(BaofPayClient.Name);
        services.AddSingleton<IBaofPayClient, BaofPayClient>();
        services.AddSingleton<IBaofPayNotifyClient, BaofPayNotifyClient>();
    }
}