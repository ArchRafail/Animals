using Animals.Dtos;
using Animals.Models;

namespace Animals.Interfaces
{
    public interface IAnimalService
    {
        List<Animal> GetAll();

        Animal GetById(int id);

        Animal GetByName(string name);

        Animal GetBySound(string sound);

        void Add(string classOfAnimal, AnimalDto animal);

        void WriteToFile(string classOfAnimal, AnimalDto animal);
    }
}
