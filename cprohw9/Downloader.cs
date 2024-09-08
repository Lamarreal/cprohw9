using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw9
{
    static class Downloader
    {
        public static async Task<string> DownloadDataAsync(string url, string filePath)
        {
            HttpClient client = new HttpClient();
            Uri uri;

            try
            {
                uri = new Uri(url);
            }
            catch (UriFormatException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
           
            string str = await client.GetStringAsync(uri);

            
            File.WriteAllText(filePath, str);

            Console.WriteLine("Download Completed");

            return str;
        }
    }
}
