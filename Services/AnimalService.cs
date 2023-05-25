using Animals.Dtos;
using Animals.Interfaces;
using Animals.Models;

namespace Animals.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _repository;
        private bool _canBeAdded;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _repository = animalRepository;
            _canBeAdded = false;
        }

        public List<Animal> GetAll()
        {
            return _repository.GetAll();
        }

        public Animal GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Animal GetByName(string name)
        {
            return _repository.GetByName(name);
        }

        public Animal GetBySound(string sound)
        {
            return _repository.GetBySound(Sound);
        }

        public void Add(string classOfAnimal, AnimalDto animalDto)
        {
            AnimalClass animalClassType;
            Animal animal = null;
            if (Enum.TryParse<AnimalClass>(classOfAnimal, out animalClassType))
            {
                switch (animalClassType)
                {
                    case Models.AnimalClass.Mammal:
                        animal = new Mammal()
                        {
                            Id = animalDto.Id,
                            Name = animalDto.Name,
                            Sex = animalDto.Sex,
                            Rank = animalDto.Rank,
                            CoverColor = animalDto.CoverColor,
                            Sound = animalDto.Sound
                        };
                        break;
                    case Models.AnimalClass.Reptile:
                        animal = new Reptile()
                        {
                            Id = animalDto.Id,
                            Name = animalDto.Name,
                            Sex = animalDto.Sex,
                            Rank = animalDto.Rank,
                            CoverColor = animalDto.CoverColor,
                            Sound = animalDto.Sound
                        };
                        break;
                    case Models.AnimalClass.Amphibia:
                        animal = new Amphibia()
                        {
                            Id = animalDto.Id,
                            Name = animalDto.Name,
                            Sex = animalDto.Sex,
                            Rank = animalDto.Rank,
                            CoverColor = animalDto.CoverColor,
                            Sound = animalDto.Sound
                        };
                        break;
                }
            }
            if (animal != null)
            {
                var allAnimals = _repository.GetAll();
                if (!allAnimals.Any(x => StringComparer.CurrentCultureIgnoreCase.Compare(x.Name, animal.Name) == 0))
                {
                    _repository.Add(animal);
                    _canBeAdded = true;
                }
                else
                {
                    _canBeAdded = false;
                }
            }
            else
            {
                _canBeAdded = false;
            }
        }

        public void WriteToFile(string classOfAnimal, AnimalDto animalDto)
        {
            Add(classOfAnimal, animalDto);
            if (_canBeAdded)
            {
                Animal animal = GetByName(animalDto.Name);
                var fileName = "animals";
                try
                {
                    fileName += ".txt";
                    string FolderPath = @"D:\Projects\ASPNet\HomeWork1\Animals\Animals\Files\";
                    if (!Directory.Exists(FolderPath))
                        Directory.CreateDirectory(FolderPath);
                    if (!File.Exists(FolderPath + fileName))
                        File.Create(FolderPath + fileName).Close();

                    StreamWriter stream = new StreamWriter(FolderPath + fileName, true);
                    stream.Write("Id: ");
                    stream.WriteLine(animal.Id);
                    stream.Write("Name: ");
                    stream.WriteLine(animal.Name);
                    stream.Write("Sound: ");
                    stream.WriteLine(animal.Sound);
                    stream.Write("Sex: ");
                    stream.WriteLine(animal.Sex);
                    stream.Write("Rank: ");
                    stream.WriteLine(animal.Rank);
                    stream.Write("Animal class: ");
                    stream.WriteLine(animal.AnimalClass);
                    stream.Write("Birth: ");
                    stream.WriteLine(animal.Birth);
                    stream.Write("Body temperature: ");
                    stream.WriteLine(animal.BodyTemperature);
                    stream.Write("Body covering: ");
                    stream.WriteLine(animal.BodyCovering);
                    stream.Write("Cover color: ");
                    stream.WriteLine(animal.CoverColor);
                    stream.WriteLine("\n");
                    stream.Close();
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }
    }
}
