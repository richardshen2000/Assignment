using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTester
{
    public partial class TestPage : System.Web.UI.Page
    {
        MessageCenterSource.MessageCenterClient messageCenterSoapClient = new MessageCenterSource.MessageCenterClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                String message = messageCenterSoapClient.HelloWorld();

            this.tbxDisplayer.Text = message;
            }
      
        
        }

        protected void btnWriteBack_Click(object sender, EventArgs e)
        {
            messageCenterSoapClient.HelloWorldWrite(this.tbxDisplayer.Text);
        }
    }
}