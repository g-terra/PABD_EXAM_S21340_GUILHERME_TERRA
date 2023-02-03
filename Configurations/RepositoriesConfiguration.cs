using s21340_exam.Repositories;

namespace s21340_exam.Configurations;

public static class RepositoriesConfiguration
{
    public static void RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped<DoctorRepository>();
    }
}