namespace s21340_exam.Middlewares.TransactionsHandling;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class TransactionalAttribute : Attribute
{
}