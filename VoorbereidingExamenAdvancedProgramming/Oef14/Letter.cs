using System;
using System.Collections.Generic;
using System.Text;

namespace Oef14
{
    class Letter : Mail
    {
        private string text;

        public Letter(string newText, Address newSender) : base(newSender)
        {
            text = newText;
        }

        public override void ShowContent()
        {

            base.ShowContent();
            Console.WriteLine("\nText in Letter: " + text + "\n");
        }

        public override string GetMailType()
        {
            return "(Letter)";
        }
    }
}
