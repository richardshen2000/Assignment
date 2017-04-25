using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDataSource.Implementation
{
    class DataBaseSource : WebDataSource.Interface.ISource
    {
        private WebDataSource.DAC.TestDataBaseEntities db = new DAC.TestDataBaseEntities();
        public DataBaseSource()
        { }

        public string GetMessage()
        {
            WebDataSource.DAC.Message m = db.Messages.First();
            return m.Content;
        }

        public void WriteMessage(String message)
        {
            WebDataSource.DAC.Message m = new DAC.Message();
            m.Content = message;
            m.Id = Guid.NewGuid();
            db.Messages.Add(m);

            db.SaveChanges();

        }
    }
}
