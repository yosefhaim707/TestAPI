using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace TestAPI.Controllers
{
    public class ProductController : Controller
    {
        private readonly HttpClient _client;

        public ProductController(HttpClient client)
        {
            _client = client;
        }

        

    }
}
