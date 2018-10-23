using System;
using System.Collections.Generic;
using System.Text;
using BuildZoo.Interfaces;

namespace BuildZoo.Classes
{
    public abstract class Aquatic : Animalia, IFly
    {
        public abstract bool LiveInWater();

        public abstract bool canFly();



        public bool CanFly()
        {
            return false;
        }

    }
}
