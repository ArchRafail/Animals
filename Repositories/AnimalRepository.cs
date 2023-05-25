using Animals.Interfaces;
using Animals.Models;

namespace Animals.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private List<Animal> _animals;

        public AnimalRepository()
        {
            _animals = new List<Animal>()
            {
                new Mammal()
                {
                    Id = 1,
                    Name = "Wolf",
                    Sex = "Male",
                    Rank = "Carnivorous",
                    CoverColor = "Grey",
                    Sound = "Owoo-oo-oo"
                },
                new Mammal()
                {
                    Id = 2,
                    Name = "Bear",
                    Sex = "Female",
                    Rank = "Carnivorous",
                    CoverColor = "BrownBrown",
                    Sound = "Ur-r-r"
                },
                new Reptile()
                {
                    Id = 3,
                    Name = "Crocodile",
                    Sex = "Male",
                    Rank = "Carnivorous",
                    CoverColor = "LightGrey",
                    Sound = "Grunt, grunt, grunt"
                },
                new Reptile()
                {
                    Id = 4,
                    Name = "Turtle",
                    Sex = "Female",
                    Rank = "Herbivorous",
                    CoverColor = "LightGrey",
                    Sound = "Creek, creek, creek"
                },
                new Amphibia()
                {
                    Id = 5,
                    Name = "Frog",
                    Sex = "Female",
                    Rank = "Herbivorous",
                    CoverColor = "Green",
                    Sound = "Kwa-kwa-kwa"
                }
            };

        }

        public List<Animal> GetAll()
        {
            return _animals;
        }

        public Animal GetById(int id)
        {
            return _animals.Single(x=>x.Id == id);
        }

        public Animal GetByName(string name)
        {
            name = name.ToLower();
            return _animals.Single(x =>
            {
                var animalName = x.Name.ToLower();
                return animalName.Contains(name);
            });
        }

        public Animal GetBySound(string sound)
        {
            sound = sound.ToLower();
            return _animals.Single(x =>
            {
                var animalSound = x.Sound.ToLower();
                return animalSound.Contains(sound);
            });
        }

        public void Add(Animal animal)
        {
            animal.Id = _animals.Count;
            _animals.Add(animal);
        }

    }
}
