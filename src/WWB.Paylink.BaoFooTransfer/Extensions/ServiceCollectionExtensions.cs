namespace WWB.Paylink.BaoFooTransfer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBaofPay(this IServiceCollection services)
        {
            services.AddHttpClient(BaoFooTransClient.Name);
            services.AddSingleton<IBaoFooTransClient, BaoFooTransClient>();
            services.AddSingleton<IBaoFooTransNotifyClient, BaoFooTransNotifyClient>();
        }
    }
}