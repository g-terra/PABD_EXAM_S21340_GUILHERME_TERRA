using System.Net;

namespace s21340_exam.Middlewares.ExceptionHandling.Exceptions;

public class BadRequestException : Exception , IApplicationError
{

    public BadRequestException(string? message) : base(message)
    {
        
    }

    public HttpStatusCode getCode()
    {
        return HttpStatusCode.BadRequest;
    }
}