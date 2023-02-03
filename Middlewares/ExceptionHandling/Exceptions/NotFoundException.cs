
using System.Net;

namespace s21340_exam.Middlewares.ExceptionHandling.Exceptions;

public class NotFoundException : Exception , IApplicationError
{
    

    public NotFoundException(string message) : base(message)
    {
    }

    public HttpStatusCode getCode()
    {
        return HttpStatusCode.NotFound;
    }
}