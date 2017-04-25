using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDataSource.Implementation
{
    class ConsoleSource : WebDataSource.Interface.ISource
    {
        public ConsoleSource()
        { }

        public string GetMessage()
        {
            return "Hello World";
        }

        public void WriteMessage(String message)
        {
            Console.WriteLine(message);
        }
    }
}
