using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace license_desktop.Data.Models
{
    public class WebResult<T> 
    {
        public WebResult(T? result)
        {
            Result = result;
            IsSuccess = true;
        }

        public WebResult(string error)
        {
            Error = new Error() { Detail = error };
            IsSuccess = false;
        }

        public WebResult(bool success)
        {
            IsSuccess = success;
        }

        public T? Result { get; set; }
        public Error? Error { get; set; }
        public bool IsSuccess { get; set; }
    }
}
