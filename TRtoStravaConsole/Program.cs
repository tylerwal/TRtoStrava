using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TRtoStravaConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			WebClient wc = new WebClient();

			string page = wc.DownloadString(@"http://www.trainerroad.com/career/tylerwal");

			File.WriteAllText(@"C:\page.html", page);

			//Console.Write(page);

			//Console.ReadLine();
		}
	}
}
