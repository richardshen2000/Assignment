using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageCenterSource.MessageCenterClient messageCenterSoapClient = new MessageCenterSource.MessageCenterClient();
            String message = messageCenterSoapClient.HelloWorld();

            Console.Write(message);
            Console.ReadLine();


        }
    }
}
