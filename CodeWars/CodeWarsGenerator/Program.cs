using CodeWarsApi;

namespace CodeWarsGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var api = new CodeWarsApiService();
            var codeChallengeService = new CodeChallengesService(api);
            var file = new FileWrapper();
            var generator = new CodeChallengeGenerator(codeChallengeService, file);

            var id = "valid-braces";
            generator.Generate(id).GetAwaiter().GetResult();
        }
    }
}
