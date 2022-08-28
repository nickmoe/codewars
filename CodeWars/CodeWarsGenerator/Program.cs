using CodeWarsApi;
using System;

namespace CodeWarsGenerator
{
    internal class Program
    {
        static void Main(string[] _)
        {
            var api = new CodeWarsApiService();
            var codeChallengeService = new CodeChallengesService(api);

            var id = "";

            var challenge = codeChallengeService.GetCodeChallege(id).GetAwaiter().GetResult();

            Console.WriteLine(challenge);
        }
    }
}
