using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageServiceFrontEnd
{
    public class ReceiverModel : PageModel
    {
        public List<string> mReceivedMessages = new List<string>();
        public bool mPurgeNext = false;
        MessagingService.ServiceClient mMsgService = new MessagingService.ServiceClient();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Console.WriteLine("here");
        }

        public void OnPostGetMessage()
        {
            int receiverID = Int32.Parse(Request.Form["InputReceiverID"]);
            bool purge = Boolean.Parse(Request.Form["RadioPurge"] == "on" ? "true" : "false");
            string[] msgs = mMsgService.ReceiveMessage(receiverID, purge);

            if (mPurgeNext)
            {
                mReceivedMessages.Clear();
                mReceivedMessages.AddRange(msgs);
                mPurgeNext = false;
            }
            else
            {
                mReceivedMessages.AddRange(msgs);
                if (purge)
                {
                    mPurgeNext = true;
                }
            }

            //Request.Form["TextReceivedMessages"] = mReceivedMessages.ToString();
        }

    }
}