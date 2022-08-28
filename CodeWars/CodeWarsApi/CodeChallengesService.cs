using CodeWarsApi.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CodeWarsApi
{
    public interface ICodeChallengesService
    {
        Task<CodeChallenge> GetCodeChallege(string id);
    }

    public class CodeChallengesService : ICodeChallengesService
    {
        private readonly string codeChallengesUrl = "code-challenges/";
        private readonly ICodeWaresApiService _codeWarsApiService;

        public CodeChallengesService(ICodeWaresApiService codeWaresApi)
        {
            _codeWarsApiService = codeWaresApi;
        }

        public async Task<CodeChallenge> GetCodeChallege(string id)
        {
            if (string.IsNullOrEmpty(id)) { return null; }

            var data = await _codeWarsApiService.Get(codeChallengesUrl + id);

            return JsonConvert.DeserializeObject<CodeChallenge>(data);
        }
    }
}
