using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        MessageCenterSource.MessageCenterClient messageCenterSoapClient = new MessageCenterSource.MessageCenterClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            String message = messageCenterSoapClient.HelloWorld();

            this.tbxDisplayer.Text = message;
        }

        private void btnWriteBack_Click(object sender, EventArgs e)
        {
            messageCenterSoapClient.HelloWorldWrite(tbxDisplayer.Text);
        }
    }
}
