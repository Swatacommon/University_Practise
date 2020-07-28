using System;
using System.ServiceModel;
using WcfService;

namespace HostForWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service1));
            host.Open();
            Console.WriteLine("Host started");
            Console.ReadKey();
            host.Close();
        }
    }
}
