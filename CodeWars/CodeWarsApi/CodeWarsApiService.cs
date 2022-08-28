using System.Net.Http;
using System.Threading.Tasks;

namespace CodeWarsApi
{
    public interface ICodeWaresApiService
    {
        Task<string> Get(string path);
    }

    public class CodeWarsApiService : ICodeWaresApiService
    {
        private const string _basePath = "https://www.codewars.com/api/v1/";

        public CodeWarsApiService() { }

        public async Task<string> Get(string path)
        {
            var client = new HttpClient();

            string response = await client.GetStringAsync(_basePath + path);

            return response;
        }
    }
}
