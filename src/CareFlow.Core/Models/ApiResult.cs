namespace CareFlow.Core.Models
{
    public class ApiResult<T>
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }

        public static ApiResult<T> Ok(T data)
        {
            return new ApiResult<T>
            {
                Success = true,
                Data = data,
                Message = "Operation succeeded",
                ErrorCode = string.Empty
            };
        }

        public static ApiResult<T> Fail(string message, string errorCode = "")
        {
            return new ApiResult<T>
            {
                Success = false,
                Data = default,
                Message = message,
                ErrorCode = errorCode
            };
        }
    }
}
