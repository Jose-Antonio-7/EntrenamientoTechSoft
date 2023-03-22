using Contracts;
using Entities;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace AccountOwnerServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {
            });
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();//Una vez que se crean utiliza el mismo cuando se requiere
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();//Una vez que se crean utiliza el mismo por usuario, si llega uno nuevo se crea uno nuevo
            //services.AddTransient<IRepositoryWrapper, RepositoryWrapper>(); Se crea uno nuevo cada vez que el usuario interactua 
        }
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            //var connectionString = config["sqlserverconnection:connectionString"];

            //options.UseSqlServer(@"Server = DESKTOP-RQBKGG3; Database = accountowner; Trusted_connection = yes");

            var connectionString = config["sqlserverconnection:connectionString"];
            services.AddDbContext<RepositoryContext>(o => o.UseSqlServer(connectionString));
        }
    }
}
