using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebDataSource.Interface;
using WebDataSource.Factory;
namespace WebDataSource
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MessageCenter" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MessageCenter.svc or MessageCenter.svc.cs at the Solution Explorer and start debugging.
    public class MessageCenter : IMessageCenter
    {
        public string HelloWorld()
        {
            DataSourceFactory dsf = new DataSourceFactory();
            ISource currentSource = dsf.CreateDataSource();

            String message = currentSource.GetMessage();

            return message;
        }

    
        public void HelloWorldWrite(String message)
        {
            DataSourceFactory dsf = new DataSourceFactory();
            ISource currentSource = dsf.CreateDataSource();

            currentSource.WriteMessage(message);
        }
    }
}
