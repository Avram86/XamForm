using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamForm.Contracts
{
    public interface IGenericRepository
    {
        Task<T> GetAsync<T>(string uri, string authToken = "");
        Task<T> PostAsync<T>(string uri, T data, string authToken = "");
        Task<T> PutAsync<T>(string uri, T data, string authToken = "");
        Task DeleteAsync(string uri, string authToken = "");
        Task<TR> PostAsync<T, TR>(string uri, T data, string authToken = "");
    }
}
