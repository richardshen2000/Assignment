using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDataSource.Interface
{
  public  interface ISource
    {
        string GetMessage();
        void WriteMessage(String message);
    }
}
