using System.Reflection;
using System.Xml.Linq;

namespace WebApplicationtest1.Models.Person
{
    public class PersonViewModel
    {
        public PersonViewModel() 
        {

        }
        public List<PersonModel> Persons { get; set; }

        public List<PersonModel> GetPersons()
        {
            return new List<PersonModel>()
            {
                new PersonModel()
                {
                    Name = "Andrzej",
                    City = "Rzeszów",
                    Gender = GenderEnum.Male,
                    ID = 1,
                },
                new PersonModel()
                {
                    Name = "Anna",
                    City = "Kraków",
                    Gender = GenderEnum.Female,
                    ID = 2,
                },
                new PersonModel()
                {
                    Name = "Jan",
                    City = "Rzeszów",
                    Gender = GenderEnum.Male,
                    ID = 3,
                },
            };
        }
            
    }
}
