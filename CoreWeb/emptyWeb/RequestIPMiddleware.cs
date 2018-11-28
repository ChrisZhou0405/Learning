using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace emptyWeb
{
    public class RequestIPMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _loogger;
        public RequestIPMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _loogger = loggerFactory.CreateLogger<RequestIPMiddleware>();
        }
        public async Task Invoke(HttpContext context)
        {
            _loogger.LogInformation("User IP:"+context.Connection.RemoteIpAddress.ToString());
            await _next.Invoke(context);
        }

    }
}
