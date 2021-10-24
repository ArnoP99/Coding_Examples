using System;
using System.Collections.Generic;
using System.Text;

namespace Oef14
{
    class Mailbox
    {
        private string owner;

        private List<Mail> mails = new List<Mail>();

        public Mailbox(string newOwner)
        {
            owner = newOwner;
        }

        public void Post(Mail mail)
        {
            mails.Add(mail);
        }

        public void Open()
        {
            if (mails.Count == 0)
            {
                Console.WriteLine("De mailbox van " + owner + " is leeg!");
            }
            else
            {
                Console.WriteLine("Mailbox van " + owner + ":");
                int counter = 1;
                foreach (var mail in mails)
                {
                    Console.WriteLine("\nMail #" + counter + " " + mail.GetMailType());
                    mail.ShowContent();
                    counter++;
                }
                mails.Clear();
            }
        }
    }
}
