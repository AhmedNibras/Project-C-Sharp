using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SongProject;

namespace ServerApplication
{
    class Program
    {
        static void Main()
        {
            TcpServerChannel channel = new TcpServerChannel(1290);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Songs), "Songs", WellKnownObjectMode.Singleton);
            Console.WriteLine("The Server has started. Press <Enter> to terminate the session");
            Console.ReadLine();
        }
    }
}
