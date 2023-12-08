namespace Car_Whisperer.Middleware;

public class TestMiddleware
{
    RequestDelegate _next;
    TestMiddlewareOptions _options;

    public TestMiddleware(RequestDelegate next, TestMiddlewareOptions options)

    {
        _next = next;
        _options = options;

    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Implement TEstMiddleware logic
        // request

        var filename = _options.LogFilename;

        var ip =  context.Request.HttpContext.Connection.RemoteIpAddress?.ToString;

        var fullFilePath = @$"*Code Location*"
        //Example: C:\\Users\\Cobbl\\Downloads\\seng-3000-group-project\\Car Whisperer\\Logs\\{filename}>

        File.WriteAllTest(filename, $"Request IP is:{ip}" );

        var stop = "Here";
        await _next(context);
        var stop2 = "Here";

        //Response

    }


}
