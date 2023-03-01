using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using ContactLibrary;

namespace ServerApplication
{
    class ServerApplication
    {
        static void Main()
        {
            TcpServerChannel channel = new TcpServerChannel(1290);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Contact), "Contacts", WellKnownObjectMode.Singleton);
            Console.WriteLine("The Server has started. Press <Enter> to terminate the session");
            Console.ReadLine();
        }
    }
}
