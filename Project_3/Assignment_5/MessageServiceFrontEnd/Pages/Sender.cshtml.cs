using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageServiceFrontEnd
{
    public class SenderModel : PageModel
    {
        MessagingService.ServiceClient mMsgService = new MessagingService.ServiceClient();

        public void OnGet()
        {

        }

        public void OnPost()
        {
            Console.WriteLine("heelo");
        }

        public void OnPostSendMessage()
        {
            int senderId = Int32.Parse(Request.Form["InputSenderID"]);
            int receiverId = Int32.Parse(Request.Form["InputReceiverID"]);
            string message = Request.Form["TextMessageData"];

            mMsgService.SendMessage(senderId, receiverId, message);
        }
    }
}