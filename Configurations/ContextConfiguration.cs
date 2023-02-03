using Microsoft.EntityFrameworkCore;
using s21340_exam.EFConfigurations.Contexts;
using s21340_exam.Helpers;

namespace s21340_exam.Configurations;

public static class ContextConfiguration
{
    public static void RegisterContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DefaultDbContext>(builder =>
        {
            builder.UseSqlServer(configuration.GetDefaultConnection());
        });
    }
}