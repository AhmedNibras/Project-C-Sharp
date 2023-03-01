using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using TrigValueLibrary;

namespace ClientApplication
{
    class Client
    {
        static void Main()
        {
            TrigValue trigValues;

            TcpClientChannel channel = new TcpClientChannel();

            ChannelServices.RegisterChannel((IChannel)channel, true);

            RemotingConfiguration.RegisterWellKnownClientType(typeof(TrigValue), "tcp://localhost:1290/TrigValues");

            trigValues = new TrigValue();

            int degree;
            string function;

            string choice = "1";
            while (choice != "3")
            {
                Console.WriteLine();
                Console.WriteLine("Please an option from the menu.");
                Console.WriteLine("1) Retrive all value for an angle");
                Console.WriteLine("2) Retrive a value for an  angle of a specific function");
                Console.WriteLine("3) Exit");
                Console.WriteLine("Your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Enter an angle: ");
                        degree = int.Parse(Console.ReadLine());
                        ArrayList values = trigValues.GetAllValues(degree);
                        if (values != null)
                        {
                            Console.WriteLine("Sin, Cos, and Tan values:");
                            foreach (int value in values)
                            {
                                Console.WriteLine(value);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No values found.");
                        }
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Enter an angle: ");
                        degree = int.Parse(Console.ReadLine());
                        Console.Write("Enter a function: ");
                        function = Console.ReadLine();
                        string tvalue = trigValues.GetValue(degree, function);
                        Console.WriteLine("Value: (0)", tvalue);
                        break;
                    default:
                        break;
                }

            }

        }
    }
}
