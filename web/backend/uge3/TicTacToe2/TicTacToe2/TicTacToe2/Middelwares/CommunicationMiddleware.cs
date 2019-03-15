using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace TicTacToe2.Middelwares
{
    public class CommunicationMiddleware
    {
        //RequestDelegate is from Microsoft.AspNetCore.Http;
        private readonly RequestDelegate _next;
        private readonly Services.IUserServices _userService;
        public CommunicationMiddleware(RequestDelegate next, Services.IUserServices userService)
        {
            _next = next;
            _userService = userService;
        }
        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);
        }


    }
}
