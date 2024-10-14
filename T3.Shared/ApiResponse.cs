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

        public HttpStatusCode Code { get; set; } = HttpStatusCode.OK;

        public object Message { get; set; } = string.Empty;

        public string Error { get; set; } = string.Empty;

        public T Data { get; set; } = default(T);

    }
}
