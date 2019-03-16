using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
namespace TicTacToe2.Extensions
{
    public static class CommunicationMiddlewareExtension
    {
        //IApplicationBuilder is from Microsoft.AspNetCore.Builder
        public static IApplicationBuilder UseCommunicationMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<Middelwares.CommunicationMiddleware>();
        }
    }
}
