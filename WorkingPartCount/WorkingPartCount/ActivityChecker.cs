using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WorkingPartCount
{
    public class ActivityChecker
    {
        private string usefulDatas;//string containing the machine's parameters that i m looking for. 

        /// <summary>
        /// method that searches for the part count parameter from the web page and trims the excess text returning only the number needed.
        /// </summary>
        /// <param name="machineIP"></param>
        /// <returns></returns>
        public string getPartCount(string machineIP)
        {

            try
            {
                using (var client = new WebClient())
                {
                    string result = client.DownloadString(machineIP);
                    var r = result.Substring(result.IndexOf("<PartCount") + 1);
                    r = r.Split('<').First();
                    r = r.Split('>').Last();
                    usefulDatas = r.ToString();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
            }
            return usefulDatas;
        }

        /// <summary>
        /// method that gets the ongoing program of the machine from the dedicated "web page", trims some stuff and outputs the usuful infos.
        /// </summary>
        /// <param name="machineIP"></param>
        /// <returns></returns>
        public string getJob(string machineIP)
        {
            try
            {
                using (var client = new WebClient())
                {
                    string result = client.DownloadString(machineIP);
                    var r = result.Substring(result.IndexOf("<Program") + 1);
                    r = r.Split('<').First();
                    r = r.Split('>').Last();
                    usefulDatas = r;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
            }
            return usefulDatas;
        }
    }
}