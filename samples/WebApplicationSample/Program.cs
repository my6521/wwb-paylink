using WWB.Paylink.BaoFooPay;
using WWB.Paylink.BaoFooPay.Extensions;
using WWB.Paylink.BaoFooTransfer;
using WWB.Paylink.BaoFooTransfer.Extensions;
using WWB.Paylink.Baofu;

namespace WebApplicationSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.Configure<BaoFooPayOptions>(builder.Configuration.GetSection("BaofooPayConfig"));
            builder.Services.AddBaoFooPayClient();

            builder.Services.Configure<BaoFooTransOptions>(builder.Configuration.GetSection("BaoFooTransConfig"));
            builder.Services.AddBaoFooTransClient();

            builder.Services.Configure<BaofuOptions>(builder.Configuration.GetSection("BaofuConfig"));
            builder.Services.AddBaofuClient();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}