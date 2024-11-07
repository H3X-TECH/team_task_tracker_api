using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



namespace T3.Shared.Helper
{
    public static class ApiResponseHelper<T> where T : class
    {
        public static ActionResult GenerateResponse(ApiResponse<T> response)
        {
            var jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };

            var jsonString = JsonSerializer.Serialize(response, jsonSerializerOptions);

            return new ContentResult
            {
                Content = jsonString,
                StatusCode = (int)response.Code,
                ContentType = "application/json"
            };
        }
    }
}
