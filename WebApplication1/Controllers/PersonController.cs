using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public static List<Person> allPeople = new List<Person>() 
        { 
            new Person { id = 1, username = "Avi", password = "12345678", jobSearchField = "01/01/2000" },
            new Person { id = 2, username = "Yosy", password = "Levi", jobSearchField = "01/02/1990" },
            new Person { id = 3, username = "Yosy", password = "Tal", jobSearchField = "01/02/1990" },
            new Person { id = 4, username = "Yosy", password = "Raz", jobSearchField = "01/02/1990" }
        };
    // GET: api/<PersonController>
        [HttpGet]
        public Person Get(string username, string password)
        {
            foreach (var person in allPeople)
            {

                System.Console.WriteLine(     "rrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr"  );
                if (person.username == username && person.password == password)
                {
                    return person; // מצאנו את האדם המתאים, מחזירים אותו
                }
            }

            return null; // אם לא מצאנו אדם מתאים, מחזירים ערך מוחזר ריק
        }
        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost("AddPerson")]
        public void Post([FromBody] Person newPerson)
        {
            allPeople.Add(newPerson);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
