using CodeWarsApi;
using System.Threading.Tasks;

namespace CodeWarsGenerator
{
    public interface ICodeChallengeGenerator
    {
        Task Generate(string id);
    }

    public class CodeChallengeGenerator : ICodeChallengeGenerator
    {
        private readonly ICodeChallengesService _codeChallengeService;
        private readonly IFileWrapper _file;

        public CodeChallengeGenerator(ICodeChallengesService codeChallengesService, IFileWrapper fileWrapper)
        {
            _codeChallengeService = codeChallengesService;
            _file = fileWrapper;
        }

        public async Task Generate(string id)
        {
            if (string.IsNullOrEmpty(id)) return;

            var challenge = await _codeChallengeService.GetCodeChallege(id);

            if (challenge == null) return;

            var name = challenge.name.Replace(" ", "");

            await _file.WriteAllText($"../../../../Kata/{name}.cs", FileText(name, challenge.description));
            await _file.WriteAllText($"../../../../KataTests/{name}Tests.cs", TestText(name));
        }

        private static string FileText(string name, string description)
        {
            return $@"namespace Kata
{{
    /*
    {description}
    */
    public class {name}
    {{
    }}
}}
";
        }

        private static string TestText(string name)
        {
            return $@"using Kata;
using Xunit;

namespace KataTests
{{
    public class {name}Tests
    {{
        [Fact]
        public void Test1()
        {{

        }}
    }}
}}
";
        }
    }
}
