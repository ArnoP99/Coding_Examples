using System;

namespace Oef14
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("Wortelstraat", "Antwerpen", 12, 2060);
            Address address2 = new Address("Gitschotellei", "Berchem", 102, 2600);

            Mailbox mailboxPieter = new Mailbox("Pieter");
            Mailbox mailboxKarel = new Mailbox("Karel");

            Letter letter1 = new Letter("Yuups de mannen, alles bon?", address1);
            Letter letter2 = new Letter("Fijne feestdagen!", address2);

            Package package1 = new Package(address2, 4.5, "Playstation 5");
            Package package2 = new Package(address1, 0.5, "HDMI Kabel");

            mailboxPieter.Post(letter2);
            mailboxPieter.Post(package1);

            mailboxKarel.Post(letter1);
            mailboxKarel.Post(package2);

            mailboxPieter.Open();
            mailboxKarel.Open();

            mailboxPieter.Open();

            Console.ReadKey();
        }
    }
}
