using System;

namespace BuildZoo.Classes.NonVertabrates.HasLegs.Crustacea
{
    class Lobsters : Aquatic, IComparable<Lobsters>
    {
        public float weight;

        public int CompareTo(Lobsters other)
        {
            return weight.CompareTo(other.weight);//-1,0 or 1
        }


        public override bool AreMultiCellular { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public override bool AreHeterotrophs { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public override string Are()
        {
           return "Are delicious!";
        }

        public override bool canFly()
        {
            return CanFly();
        }

        

        public override string Eat()
        {
            throw new System.NotImplementedException();
        }

        public override bool LiveInWater()
        {
            throw new System.NotImplementedException();
        }
    }
}
