using Library.WebApi.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Library.WebApi.Filter;

public class CustomExceptionFilter: IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        
        context.Result = new ObjectResult(exception.Message)
        {
            StatusCode = (int)exception.GetStatusCode()
        };
        context.ExceptionHandled = true;
    }
}