using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDataSource.Interface;
using WebDataSource.Implementation;

namespace WebDataSource.Factory
{
    public class DataSourceFactory
    {
        public DataSourceFactory()
        { }

        public ISource CreateDataSource()
        {
            ISource CurrentSource;
            String source = System.Web.Configuration.WebConfigurationManager.AppSettings["Source"].ToString();

            switch (source)
            {
                case "DataBase":
                    CurrentSource = new DataBaseSource();
                    break;
                case "Console":
                    CurrentSource = new ConsoleSource();
                    break;
                default:
                    CurrentSource = null;
                    break;
            }
            return CurrentSource;
        }
    }
}
