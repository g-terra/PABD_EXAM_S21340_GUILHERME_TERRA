using System.Net;
using Newtonsoft.Json;

namespace s21340_exam.Middlewares.ExceptionHandling;

public class GlobalExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<GlobalExceptionHandlerMiddleware> _logger;

    public GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }

        catch (Exception ex)
        {
            _logger.LogError("Error: {m}", ex.Message);
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(
        HttpContext context,
        Exception ex
    )
    {
        var code = HttpStatusCode.InternalServerError;

        if (ex is IApplicationError error)
        {
            code = error.getCode();
        }

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;
        return context.Response.WriteAsync(new ErrorDetails
        {
            StatusCode = code,
            Message = ex.Message,
            StackTrace = ex.StackTrace
        }.ToString());
    }

    public class ErrorDetails
    {
        public HttpStatusCode StatusCode { get; set; }
        public string? Message { get; set; }
        public string? StackTrace { get; set; }
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}