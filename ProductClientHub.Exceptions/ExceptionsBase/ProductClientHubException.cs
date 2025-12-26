using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public abstract class ProductClientHubException : SystemException
    {
        public ProductClientHubException(string errorMessage) :base(errorMessage) 
        {
            
        }

        public abstract List<string> GetError();
        public abstract HttpStatusCode GetHttpStatusCode();
    }
}
