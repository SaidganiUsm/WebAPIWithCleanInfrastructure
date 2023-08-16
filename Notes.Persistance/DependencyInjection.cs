using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Notes.Persistance
{
    public static class DependencyInjection 
    {
        public static IServiceCollection AddPersistance(this IServiceCollection service, 
            IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            service.AddDbContext<NotesDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            service.AddScoped<NotesDbContext>(provider => 
                provider.GetService<NotesDbContext>());
            return service;
        }
    }
}
