using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebFlashAsh.SD;

namespace WebFlashAsh.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
