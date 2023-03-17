using WWB.Paylink.BaofPay;
using WWB.Paylink.BaofPay.Extensions;
using WWB.Paylink.HsqPay;
using WWB.Paylink.HsqPay.Extensions;

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

            builder.Services.Configure<HsqPayOptions>(builder.Configuration.GetSection("HsqPayConfig"));
            builder.Services.AddHsqPay();

            builder.Services.Configure<BaofPayOptions>(builder.Configuration.GetSection("BaofPayConfig"));
            builder.Services.AddBaofPay();

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