﻿using BuildZoo.Classes;
using BuildZoo.Interfaces;

namespace BuildZoo
{
    public class Lobster : Crustacea
    {
        public override string Are()
        {
            return "Are delicious with garlic and melted butter";
        }

        public override bool AreHeterotrophs()
        {
            return true;
        }

        public override bool AreMultiCellular()
        {
            return true;
        }

        public override string Eat()
        {
            return "Sometimes eat other lobsters!";
        }

        public override bool HaveNoBackbone()
        {
            return true;
        }
    }

}