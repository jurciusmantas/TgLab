using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;
using System.ServiceModel.Description;

namespace CalculatorServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sHost = new ServiceHost(typeof(Calculator), new Uri("http://localhost:8000/TgLab/"));

            try
            {
                sHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "Calculator");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                sHost.Description.Behaviors.Add(smb);
                sHost.Open();

                Console.WriteLine("Service ready. Press any key to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                sHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                sHost.Abort();
            }
        }
    }
}
