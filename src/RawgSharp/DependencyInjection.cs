using Microsoft.Extensions.DependencyInjection;

namespace RawgSharp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRawgClient(this IServiceCollection services)
        {
            services.AddSingleton<IRawgApi, RawgApi>();
            services.AddHttpClient<IRawgApi, RawgApi>(client =>
            {
                client.BaseAddress = new Uri("https://api.rawg.io/api/");
            });

            return services;
        }
    }
}