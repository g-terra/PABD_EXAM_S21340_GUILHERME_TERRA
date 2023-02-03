using System.Net;

namespace s21340_exam.Middlewares.ExceptionHandling;

public interface IApplicationError 
{
    HttpStatusCode getCode();
}