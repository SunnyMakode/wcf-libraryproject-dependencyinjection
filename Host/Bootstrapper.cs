using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TestService;
using TestService.Utilities;

namespace Host
{
    public class Bootstrapper
    {
        public static ContainerBuilder RegisterContainerBuilder()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.Register(c => new StringMixer()).As<IStringMixer>();
            builder.Register(c => new DisplayService(c.Resolve<IStringMixer>())).As<IDisplayService>();
            return builder;
        }
    }
}
