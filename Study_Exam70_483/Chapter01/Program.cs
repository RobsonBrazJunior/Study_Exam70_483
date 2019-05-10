using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.IO;

namespace Chapter01
{
    public class Program
    {
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            string content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);

            using (FileStream sourceStream = new FileStream("temp.html", FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
            {
                byte[] encondedText = Enconding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encondedText, 0, encondedText.Length).ConfigureAwait(false);
            }
        }
    }
}
