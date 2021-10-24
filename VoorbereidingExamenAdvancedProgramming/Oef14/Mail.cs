using System;
using System.Collections.Generic;
using System.Text;

namespace Oef14
{
    class Mail
    {
        private Address address;
        public Mail(Address newAddress)
        {
            address = newAddress;
        }
        public virtual void ShowContent()
        {
            Console.WriteLine("Sender: " + address.GetDescription());
        }

        public virtual string GetMailType()
        {
            return "(Mail)";
        }
    }
}
