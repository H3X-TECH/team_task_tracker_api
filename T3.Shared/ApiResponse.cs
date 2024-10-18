using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace T3.Shared
{
    public class ApiResponse<T>
    {

        public HttpStatusCode Code { get; set; }

        public string Message { get; set; } 

        public object Errors { get; set; }

        public T Data { get; set; }

        public ApiResponse(HttpStatusCode code = HttpStatusCode.OK,
                           string message = null ,
                           T data = default ,
                           object errors = null)
        {
            Code = code;
            Message = message;
            Errors = errors;
            Data = data;
        }

        public static ApiResponse<T> Success(T data, string message = "Operation completed successfully")
        {
            return new ApiResponse<T>(HttpStatusCode.OK, message, data);
        }

        public static ApiResponse<T> Created(T data, string message = "Created successfully")
        {
            return new ApiResponse<T>(HttpStatusCode.Created, message, data);
        }

        public static ApiResponse<T> Error (string message = "An error occurred",object error = null)
        {
            return new ApiResponse<T>(HttpStatusCode.InternalServerError, message, default,error);
        }

        public static ApiResponse<T> NotFound (string message = "Resource not found")
        {
            return new ApiResponse<T> (HttpStatusCode.NotFound, message);
        }
    }
}
