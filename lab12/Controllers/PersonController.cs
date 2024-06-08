using lab12.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab12.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private static readonly string[] Nombres = new[]
        {
            "Rafael"
        };

        private static readonly string[] Apellidos = new[]
        {
            "Reynoso"
        };

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Listar")]
        public IEnumerable<Person> Listar()
        {
            return Enumerable.Range(1, 100).Select(index => new Person
            {
                Id = Random.Shared.Next(0, 100),
                Name = Nombres[Random.Shared.Next(Nombres.Length)],
                LastName = Apellidos[Random.Shared.Next(Apellidos.Length)],
                Age = Random.Shared.Next(1,80)
            })
            .ToArray();
        }

        [HttpPost(Name = "Listar2")]
        public IEnumerable<Person> Listar2(string Name, string LastName)
        {
            return Enumerable.Range(1, 100).Select(index => new Person
            {
                Id = Random.Shared.Next(0, 100),
                Name = Name,
                LastName = LastName,
                Age = Random.Shared.Next(1, 80)
            })
            .ToArray();
        }

    }
}
