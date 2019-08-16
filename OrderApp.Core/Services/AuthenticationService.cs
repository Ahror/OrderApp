using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OrderApp.Core.Services
{
    public class AuthenticationService
    {
        private readonly HttpClient _httpClient;
        public AuthenticationService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:55015/") };
        }
        public async Task<bool> LoginAsync(string login, string password)
        {
            var path = $"api/manager/adduser/{login}/{password}";
            var httpResponseMessage = await _httpClient.GetAsync(path);
            return httpResponseMessage.IsSuccessStatusCode;
        }
    }
}