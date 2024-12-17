using System.Net;
using System.Text.Json;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ErrorHandlingMiddleware> _logger;

    public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
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
            await HandleExceptionAsync(context, ex);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        _logger.LogError(exception.Message, exception.StackTrace);


        context.Response.ContentType = "application/json";
        context.Response.StatusCode = exception switch
        {
            InvalidOperationException => (int)HttpStatusCode.NotFound,
            KeyNotFoundException => (int)HttpStatusCode.NotFound,
            FluentValidation.ValidationException => (int)HttpStatusCode.BadRequest,
            ArgumentException => (int)HttpStatusCode.BadRequest,
            _ => (int)HttpStatusCode.InternalServerError,
        };

        var response = new
        {
            StatusCode = context.Response.StatusCode,
            Message = exception.Message,
            Detail = exception.InnerException?.Message
        };

        await context.Response.WriteAsync(JsonSerializer.Serialize(response));
    }


}
