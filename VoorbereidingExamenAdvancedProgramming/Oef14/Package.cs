using System;
using System.Collections.Generic;
using System.Text;

namespace Oef14
{
    class Package : Mail
    {
        private double weight;

        private string content;

        public Package(Address newSender, double newWeight, string newContent) : base(newSender)
        {
            weight = newWeight;
            content = newContent;
        }

        public override void ShowContent()
        {
            base.ShowContent();
            Console.WriteLine("\nWeight: " + weight);
            Console.WriteLine("Content: " + content + "\n");
        }

        public override string GetMailType()
        {
            return "(Package)";
        }
    }
}
