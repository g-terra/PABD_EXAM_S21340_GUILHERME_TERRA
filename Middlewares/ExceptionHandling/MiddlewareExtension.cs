namespace s21340_exam.Middlewares.ExceptionHandling;

public static class MiddlewareExtension
{
    public static void UseGlobalErrorHandler(this IApplicationBuilder app)
    {
        app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
    }
}