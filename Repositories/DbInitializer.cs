using Microsoft.EntityFrameworkCore;

namespace KR.Repositories
{
    public class DbInitializer
    {
        public static async Task InitializeDataBaseAsync(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();

            var sakilaDbContext = serviceScope.ServiceProvider.GetService<SakilaDbContext>();

            await sakilaDbContext.Database.MigrateAsync();

        }
    }
}
