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
        public static string BasePath = "https://www.codewars.com/api/v1/";

        public CodeWarsApiService()
        {

        }

        public async Task<string> Get(string path)
        {
            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(path);

            return response;
        }
    }
}
