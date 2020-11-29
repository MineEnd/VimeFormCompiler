using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Vime_Form_Compiler
{
    public partial class Staffgui : Form
    {
        public Staffgui()
        {
            InitializeComponent();
        }

        private void staffgui_Load(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            web.Proxy = new WebProxy();
            string reply = web.DownloadString("https://api.vimeworld.ru/online/staff");
        }
    }
} 
