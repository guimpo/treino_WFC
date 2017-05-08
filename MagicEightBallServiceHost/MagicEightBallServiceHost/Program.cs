using System;
using System.ServiceModel;
using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Console Based WCF Host *****");

            using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
            {
                // Iniciar o provedor e esperar por mensagens
                serviceHost.Open();

                // Manter serviço executando até a tecla 'enter' ser precionada
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
            
        }
    }
}
