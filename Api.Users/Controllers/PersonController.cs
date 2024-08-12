using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[ApiController]
    //[Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        private List<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person { Id = 1, Name = "Juan Pérez", Age = 30 },
                new Person { Id = 2, Name = "Ana Gómez", Age = 25 },
                new Person { Id = 3, Name = "Carlos López", Age = 40 }
            };
        }

        [HttpGet(Name = "GetPersons")]
        public ActionResult<Person> Get()
        {
            var persons = GetPersons();
            return Ok(persons);

        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
