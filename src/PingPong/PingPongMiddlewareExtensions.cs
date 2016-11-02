using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace PingPong
{
    public static class PingPongMiddlewareExtensions
    {
        public static IApplicationBuilder UsePingPong(this IApplicationBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            return builder.UseMiddleware<PingPongMiddleware>();
        }
    }
}
