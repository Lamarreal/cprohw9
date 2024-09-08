using cprohw9;

namespace cprohw9
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Task1.Work();
            await Downloader.DownloadDataAsync("https://ru.wikipedia.org/wiki/URL","D:/text.txt");
            Console.WriteLine("File Saved");
        }
    }

}
