using System.IO;
using System.Threading.Tasks;

namespace CodeWarsGenerator
{
    public interface IFileWrapper
    {
        Task WriteAllText(string path, string text);
    }

    public class FileWrapper : IFileWrapper
    {
        public async Task WriteAllText(string path, string text)
        {
            await File.WriteAllTextAsync(path, text);
        }
    }
}
