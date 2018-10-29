using BuildZoo.Classes;
using BuildZoo.Interfaces;

namespace BuildZoo
{
    public class Lobster : Crustacea
    {
        public override string Are()
        {
            return "Lobsters are delicious with garlic and melted butter";
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
            return "Weird trivial fact: Sometimes lobsters eat other lobsters! Is that lobsterism?";
        }

        public override bool HaveNoBackbone()
        {
            return true;
        }
    }

}
