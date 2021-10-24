using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTalkInterface
{
    interface IAnimalTalk
    {

        string Text { get; }

        void Speak();
    }
}
