using System;
using Microsoft.Owin.Hosting;

namespace OwinWithGoogle.AuthServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8081/";

            using (WebApp.Start<Startup>(baseAddress))
            {
                Console.WriteLine("Owin app has been started");
                Console.ReadLine();
            }
        }
    }
}