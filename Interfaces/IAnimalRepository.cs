using Animals.Models;

namespace Animals.Interfaces
{
    public interface IAnimalRepository
    {

        List<Animal> GetAll();

        void Add(Animal animal);

        Animal GetById(int id);

        Animal GetByName(string name);

        Animal GetBySound(string sound);

    }
}
