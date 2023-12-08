namespace Car_Whisperer.Middleware;

public class TestMiddleware
{
    RequestDelegate _next;

    public TestMiddleware(RequestDelegate next)

    {
        _next = next;

    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Implement TEstMiddleware logic
        // request
        var stop = "Here";
        await _next(context);
        var stop2 = "Here";

        //Response

    }


}
