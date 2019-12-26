using System;
using System.ServiceModel;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Wcf;
using TestService;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IContainer container = Bootstrapper.RegisterContainerBuilder().Build())
            {
                ServiceHost host = new ServiceHost(typeof(DisplayService));

                IComponentRegistration registration;
                if (!container.ComponentRegistry.TryGetRegistration(new TypedService(typeof(IDisplayService)), out registration))
                {
                    Console.WriteLine("The service contract has not been registered in the container.");
                    Console.ReadLine();
                    Environment.Exit(-1);
                }

                host.AddDependencyInjectionBehavior<IDisplayService>(container);
                host.Open();
                Console.WriteLine("Host has started");
                Console.ReadLine();

                host.Close();
                Environment.Exit(0);
            }
        }
    }
}
