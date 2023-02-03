namespace s21340_exam.Middlewares.TransactionsHandling;

public static class MiddlewareExtension
{
    public static void UseTransactionHandler(this IApplicationBuilder app)
    {
        app.UseMiddleware<TransactionHandlerMiddleware>();
    }
}