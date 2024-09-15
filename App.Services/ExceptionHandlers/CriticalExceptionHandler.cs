using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace App.Services.ExceptionHandlers;

public class CriticalExceptionHandler : IExceptionHandler {
    public ValueTask<bool> TryHandleAsync(HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken) {
        if (exception is CriticalException) Console.WriteLine("send exception for message");

        return ValueTask.FromResult(false);
    }
}