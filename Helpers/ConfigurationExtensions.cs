namespace s21340_exam.Helpers;

public static class ConfigurationExtensions
{
    public static string GetDefaultConnection(this IConfiguration configuration)
    {
        return configuration.GetConnectionString("PjatkConnection");
    } 
    
   
}