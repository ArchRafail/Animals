using Animals.Dtos;
using Animals.Interfaces;
using Animals.Models;
using Microsoft.AspNetCore.Mvc;

namespace Animals.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet("GetAllAnimals")]
        public IActionResult GetAll()
        {
            return Ok(_animalService.GetAll());
        }

        [HttpGet("GetAnimalById")]
        public IActionResult GetById([FromQuery]int id)
        {
            try
            {
                return Ok(_animalService.GetById(id));
            }
            catch (Exception _)
            {
                return BadRequest($"parameter {nameof(id)} is out of range.");
            }
        }

        [HttpGet("GetAnimalByName")]
        public IActionResult GetByName([FromQuery]string name)
        {
            try
            {
                return Ok(_animalService.GetByName(name));
            }
            catch (Exception _)
            {
                return BadRequest($"your value of parameter {nameof(name)} is not present in repository.");
            }
        }

        [HttpPost("AddAnimalToRepository")]
        public IActionResult Add([FromQuery]string classOfAnimal, [FromBody] AnimalDto animal)
        {
            _animalService.Add(classOfAnimal, animal);
            return Ok();
        }

        [HttpPost("AddAnimalToFile")]
        public IActionResult WiteToFile([FromQuery] string classOfAnimal, [FromBody] AnimalDto animal)
        {
            _animalService.WriteToFile(classOfAnimal, animal);
            return Ok();
        }
    }
}
