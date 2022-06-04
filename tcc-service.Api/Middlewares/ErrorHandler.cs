using Domain.Shared;

using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;

using System;
using System.Net;
using System.Threading.Tasks;

namespace tcc_service.Api.Middlewares
{
    public class ErrorHandler
    {
        private readonly RequestDelegate next;

        public ErrorHandler(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var exception = new ExceptionResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro na aplicação, tente novamente mais tarde.");

            var result = JsonConvert.SerializeObject(exception);
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(result);
        }
    }
}