namespace BuildZoo.Classes
{
    /// <summary>
    /// Instantiation of the class Kingdom Animalia that all child classes down to concrete class inherit/derived from
    /// </summary>
    public abstract class Animalia
    {
        public abstract bool AreMultiCellular { get; set; }
        public abstract bool AreHeterotrophs { get; set; }

        /// <summary>
        /// Abstract method instantiated in class Animalia
        /// </summary>
        /// <returns>Description of animal</returns>
        public abstract string Are();


        /// <summary>
        /// Abstract method of instantiated class Animalia; heterotrophs can't produce its own food; method: action of eating
        /// </summary>
        /// <returns>What animal is eating or what they eat</returns>
        public abstract string Eat();
    }
}
