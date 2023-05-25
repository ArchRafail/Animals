using System.ComponentModel.DataAnnotations;

namespace Animals.Models
{
    public class Mammal : Animal
    {
        public override int Id { get; set; }

        [Required]
        public override string Name { get; set; }

        public override string Sex
        {
            get { return sex.ToString(); }
            set
            {
                Sex sexType;
                if (Enum.TryParse<Sex>(value, out sexType))
                {
                    switch (sexType)
                    {
                        case Models.Sex.Male:
                            sex = Models.Sex.Male;
                            break;
                        case Models.Sex.Female:
                            sex = Models.Sex.Female;
                            break;
                    }
                }
            }
        }

        public override string Rank
        {
            get { return rank.ToString(); }
            set
            {
                Rank rankType;
                if (Enum.TryParse<Rank>(value, out rankType))
                {
                    switch (rankType)
                    {
                        case Models.Rank.Carnivorous:
                            rank = Models.Rank.Carnivorous;
                            break;
                        case Models.Rank.Herbivorous:
                            rank = Models.Rank.Herbivorous;
                            break;
                        case Models.Rank.Hybrids:
                            rank = Models.Rank.Hybrids;
                            break;
                    }
                }
            }
        }

        [Required]
        public override string Sound { get; set; }

        public override string CoverColor { get; set; }

        private string animalClass = "Mammal";
        private string birth = "Live birth";
        private string bodyTemperature = "Hematothermal";
        private string bodyCovering = "Hair";
        private Sex sex;
        private Rank rank;

        public override string AnimalClass { get { return animalClass; } }
        public override string Birth { get { return birth; } }
        public override string BodyTemperature { get { return bodyTemperature; } }
        public override string BodyCovering { get { return bodyCovering; } }
    }
}
