using System.Net;
using Library.BLL.Exceptions;

namespace Library.WebApi.Extensions;

public static class ExceptionFilterExtensions
{
    public static HttpStatusCode GetStatusCode(this Exception exception)
    {
        return exception switch
        {
            NotFoundException => HttpStatusCode.NotFound,
            _ => HttpStatusCode.InternalServerError
        };
    }
}