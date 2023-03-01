using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using ContactLibrary;

namespace ClientApplication
{
    class ClientApplication
    {
        static void Main() { 

        Contact contacts;

        TcpClientChannel channel = new TcpClientChannel();
        ChannelServices.RegisterChannel(channel, false);
        RemotingConfiguration.RegisterWellKnownClientType(typeof(Contact), "tcp://localhost:1290/Songs");
        contacts = new Contact();

        string choice = "1";
        while (choice != "3")
        {
            Console.WriteLine();
            Console.WriteLine("Please selection an option from menu");
            Console.WriteLine("1) Retrieve all contact names");
            Console.WriteLine("2) Retrive a contact  number");
            Console.WriteLine("3) Exit");
            Console.WriteLine("Your Choice: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine();
                    ArrayList allNames = (ArrayList)contacts.GetAllContacts();
                    foreach (string contactName in allNames)
                    {
                        Console.WriteLine(contactName);
                    }
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Enter a contact name: ");
                    Console.WriteLine("Number: {0}", contacts.GetContact(Console.ReadLine()));
                    break;
                default:
                    break;
            }
        }
    }
    }
}
