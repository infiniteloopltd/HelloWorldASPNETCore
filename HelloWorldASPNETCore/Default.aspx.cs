using System;
using System.Net;
using System.Web;
using System.Web.UI;

namespace HelloWorldASPNETCore
{
    public partial class Default : System.Web.UI.Page
    {
        protected string IP = "";

        protected void Page_Load(object source, EventArgs e) 
        {
            WebClient wc = new WebClient();
            this.IP = wc.DownloadString("http://www.icanhazip.com");
        }

    }
}
