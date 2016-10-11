using System;
using System.Collections.Generic;

namespace Mocking
{
    public class MailBox
    {
        private List<Mail> mailList;
        public MailBox()
        {
            mailList = new List<Mail>();
        }

        public int NumReceivedMessages
        {
            get { return mailList.Count; }
            set{ }
        }

        public void Add(Mail o)
        {
            mailList.Add(o);
        }



        internal string GetLatestMessageText()
        {
            Mail mail = mailList[mailList.Count - 1];
            return mail.Content;
        }
    }
}