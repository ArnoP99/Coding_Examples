using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTalkInterface
{
    interface ILeggedAnimal
    {
       int NumLegs { get; }

        void WriteLegs();
    }
}
