using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebDataSource
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMessageCenter" in both code and config file together.
    [ServiceContract]
    public interface IMessageCenter
    {
        [OperationContract]
        string HelloWorld();
        [OperationContract]
        void HelloWorldWrite(String message);
    }
}
