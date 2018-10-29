using System;
using System.Collections.Generic;
using System.Text;

namespace BuildZoo.Classes
{
    class Puppy : CanisFamiliaris
    {
        public override string Are()
        {
            return "But they're super cute!";
        }

        public override bool AreHeterotrophs()
        {
            return true;
        }

        public override bool AreMultiCellular()
        {
            return true;
        }

        public override string Chew()
        {
            return "Chew dog toys...and your favorite sweater";
        }

        public override string Eat()
        {
            return "Love french fries!";
        }

        public override bool FeedBabiesMilk()
        {
            return true;
        }

        public override string Have()
        {
            return "Have cute puppy paws.";
        }

        public override bool HaveBackbone()
        {
            return true;
        }

        public override bool HaveHair()
        {
            return true;
        }

        public override string HaveVocalChords()
        {
            return "Have cute puppy barks!";
        }

        public override bool LayEggs()
        {
            return false;
        }
    }
}
