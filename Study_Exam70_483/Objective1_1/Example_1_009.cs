using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1
{
	//MultiThreading
	public class Example_1_009
	{
		public static void Main(string[] args)
		{
			string objectText = DownloadContentFromApi(1).Result;
			Console.WriteLine(objectText);

			Console.ReadLine();
		}

		private static async Task<string> DownloadContentFromApi(int postId)
		{
			using (HttpClient client = new HttpClient())
			{
				string result = await client.GetStringAsync($"https://jsonplaceholder.typicode.com/posts/{postId}");
				return result;
			}
		}
	}
}
