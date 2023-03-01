using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using SongProject;

namespace ClientApplication
{
    class Client
    {
        static void Main()
        {
            Songs songs;

            TcpClientChannel channel = new TcpClientChannel();
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownClientType(typeof(Songs), "tcp://localhost:1290/Songs");
            songs = new Songs();

            string choice = "1";
            while (choice != "3")
            {
                Console.WriteLine();
                Console.WriteLine("Please selection an option from menu");
                Console.WriteLine("1) Retrieve all artist names");
                Console.WriteLine("2) Retrive a song's title");
                Console.WriteLine("3) Exit");
                Console.WriteLine("Your Choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        ArrayList allArtists = (ArrayList)songs.GetAllSongs();
                        foreach (string songArtist in allArtists)
                        {
                            Console.WriteLine(songArtist);
                        }
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Enter a artist name: ");
                        Console.WriteLine("Title: {0}", songs.GetSong(Console.ReadLine()));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
