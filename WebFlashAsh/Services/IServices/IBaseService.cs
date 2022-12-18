using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlashAsh.Models;

namespace WebFlashAsh.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
