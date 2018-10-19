namespace BuildZoo.Classes.Vertebrates.Mammals.CanisFamiliaris
{
    public abstract class CanisFamiliaris
    {
        public abstract string Have();

        public virtual string HaveVocalChords { get; set; }

        public abstract string Chew();
    }
}
