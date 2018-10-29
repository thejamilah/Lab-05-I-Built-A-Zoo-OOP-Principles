namespace BuildZoo
{
    public class Snake : Reptilian
    {
        public override string Are()
        {
            return "Are sneaky creatures that will bite you or strangle you.";
        }

        public override bool AreHeterotrophs()
        {
            return true;
        }

        public override bool AreMultiCellular()
        {
            return true;
        }

        public override bool Bite()
        {
            return true;
        }

        public override string Eat()
        {
            throw new System.NotImplementedException();
        }

        public override bool HaveBackbone()
        {
            return true;
        }

        public override bool HaveNoHair()
        {
            return true;
        }

        public override bool HaveScalySkin()
        {
            return true;
        }

        public override bool LaysEggs()
        {
            return true;
        }
    }
}
