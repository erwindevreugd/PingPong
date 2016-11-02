using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PingPong
{
    public class PingPongMiddleware
    {
        private readonly RequestDelegate _next;

        public PingPongMiddleware(RequestDelegate next)
        {
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Request.Path.StartsWithSegments("/ping"))
            {
                await context.Response.WriteAsync("pong");
            }

            await _next(context);
        }
    }
}
