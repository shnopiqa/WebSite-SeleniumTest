using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlashAsh.Models;
using WebFlashAsh.Services.IServices;

namespace WebFlashAsh.Services
{
    public class BaseService : IBaseService
    {
        public ResponseDto responseModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            throw new NotImplementedException();
        }
    }
}
