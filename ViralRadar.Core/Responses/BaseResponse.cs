using System;
namespace ViralRadar.Core.Common.Responses
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }
        public T? Data { get; set; }

        public static BaseResponse<T> SuccessResponse(T data, string? message = null)
        {
            return new BaseResponse<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static BaseResponse<T> Failure(string message, List<string>? errors = null)
        {
            return new BaseResponse<T>
            {
                Success = false,
                Message = message,
                Errors = errors
            };
        }
    }
}

