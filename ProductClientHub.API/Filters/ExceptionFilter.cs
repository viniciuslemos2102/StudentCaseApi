using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductClientHub.Communication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is ProductClientHubException _productClientHubException)
            {
                context.HttpContext.Response.StatusCode = (int)_productClientHubException.GetHttpStatusCode();
                context.Result = new ObjectResult(new ReponseErrorMenssagesJson(_productClientHubException.GetError()));
            }
            else
            {
                ThronUnknowError(context);
            }
            
        }

        private void ThronUnknowError(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(new ReponseErrorMenssagesJson("Erro desconhecido"));
            
        }
    }
}
