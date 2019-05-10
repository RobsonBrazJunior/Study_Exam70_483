using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;

namespace Chapter01
{
    public class Program
    {
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            string content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);

            Output.Content = content;
        }
    }
}
