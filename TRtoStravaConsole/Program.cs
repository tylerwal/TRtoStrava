using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TRtoStravaConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			HttpContent content = new StringContent("");

			Uri trainerRoadApi = new Uri("http://www.trainerroad.com/api/rides");

			Task<HttpResponseMessage> response;

			using (HttpClient httpClient = new HttpClient())
			{
				response = httpClient.PostAsync(trainerRoadApi, content);
			}

			Console.WriteLine(response.Result.Content);

			Console.ReadKey();

			//Console.Write(page);

			//Console.ReadLine();
		}
	}
}
