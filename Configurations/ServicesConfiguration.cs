using s21340_exam.Services;

namespace s21340_exam.Configurations;

public static class BusinessServicesConfiguration
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<DoctorService>();
    }
}