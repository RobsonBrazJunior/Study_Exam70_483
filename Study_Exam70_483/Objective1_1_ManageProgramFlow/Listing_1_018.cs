using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Async and Await
	public static class Listing_1_018
	{
		public static void Main()
		{
			string result = DownloadContent().Result;
			Console.WriteLine(result);
		}

		public static async Task<string> DownloadContent()
		{
			using (HttpClient client = new HttpClient())
			{
				string result = await client.GetStringAsync("http://www.microsoft.com");
				return result;
			}
		}
	}
}