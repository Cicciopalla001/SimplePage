using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingPartCount
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<string> datas = new List<string> { };

        protected void Page_Load(object sender, EventArgs e)
        {
            updateLabelsContent();
            Response.Expires = 0;
            Response.Buffer = true;
            Response.Clear();
            Response.AddHeader("Refresh", "15");
        }


        private void updateLabelsContent()
        {
            string toShow;//the auxiliary string we are going to use to output on labels.
            ActivityChecker ac = new ActivityChecker();


            if (PingHost("192.168.1.10"))
            {
                toShow = ac.getPartCount("http://192.168.1.10:5000/current");
                lblParam1Output.Text = toShow;
                toShow = ac.getJob("http://192.168.1.10:5000/current");
                lblParam2Output.Text = toShow;
            }
            else
            {
                lblMoreInfos.Text = "La macchina è al momento spenta.";
            }
        }


        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            return pingable;
        }
    }
}