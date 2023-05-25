namespace Animals.Models
{
    public enum AnimalClass
    {
        Mammal,
        Reptile,
        Amphibia
    }

    public enum Sex
    {
        Male,
        Female
    }

    public enum Rank
    {
        Carnivorous,
        Herbivorous,
        Hybrids
    }

    public abstract class Animal
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Sex { get; set; }
        public abstract string Rank { get; set; }
        public abstract string Sound { get; set; }
        public abstract string AnimalClass { get; }
        public abstract string Birth { get; }
        public abstract string BodyTemperature { get; }
        public abstract string BodyCovering { get; }
        public abstract string CoverColor { get; set; }

    }
}
