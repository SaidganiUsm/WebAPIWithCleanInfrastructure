using Microsoft.Extensions.DependencyInjection;

namespace Notes.Application
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
