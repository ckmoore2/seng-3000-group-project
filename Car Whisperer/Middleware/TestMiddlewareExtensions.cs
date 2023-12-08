using Car_Whisperer.Middleware;
namespace Car_Whisperer.Middleware;


public static class TestMiddlewareExtensions
{
    public static IApplicationBuilder UseTestMiddleware(this IApplicationBuilder app, IpLoggingOptions ipLoggingOptions)
    {
                return app.UseMiddleware<TestMiddleware>(ipLoggingOptions);

    }
}
