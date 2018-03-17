using System;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
			Bot b = new Bot();
			b.RunAsync().Wait();
        }
    }
}
