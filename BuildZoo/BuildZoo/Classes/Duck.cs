using BuildZoo.Classes.Vertabrate.Mammal;
using BuildZoo.Interfaces;

namespace BuildZoo
{
    public class Duck : Mammal, IFly
    {
        public override string Are()
        {
            return "Baby ducks or ducklings are cute!";
        }

        public override bool AreHeterotrophs()
        {
            return true;
        }

        public override bool AreMultiCellular()
        {
            return true;
        }

        public bool canFly()
        {
            return true;
        }

        public override string Eat()
        {
            return "Will chase you down for bread!";
        }

        public override bool FeedBabiesMilk()
        {
            return false;
        }

        public override bool HaveBackbone()
        {
            return true;
        }

        public override bool HaveHair()
        {
            return false;
        }

        public override bool LayEggs()
        {
            return true;
        }
    }

}
