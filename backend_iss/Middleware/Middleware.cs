using Microsoft.AspNetCore.Http;

namespace Middleware
{
    public class Middleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);

            }
            catch (Exception ex)
            {
                GlobalResponse response = new GlobalResponse();


                StatusCode statusCode = new StatusCode();
                statusCode.code = 1;
                statusCode.message = "Something went wrong,please try again";
                response.statusCode = statusCode;
                await context.Response.WriteAsJsonAsync(response);

            }
        }

        public class GlobalResponse
        {
            public StatusCode statusCode { get; set; } = new StatusCode();
        }
        public class StatusCode
        {
            public int code { get; set; }
            public string message { get; set; }
        }
    }
}
