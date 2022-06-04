namespace Domain.Shared
{
    public class ExceptionResponse
    {
        public ExceptionResponse(int httpCode, string message)
        {
            HttpCode = httpCode;
            Message = message;
        }

        public int HttpCode { get; set; }

        public string Message { get; set; }
    }
}