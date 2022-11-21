using System.Collections;

namespace WebApplication3.Models
{
    public class CreatePerson : IEnumerable
    {
        // view till tabel modeln person 


        // databasen tillfällit
        public static List<PersonVM> listOfPeople = new List<PersonVM>();

        public List<PersonVM> tempList = new List<PersonVM>();
        public List<PersonVM> tempList1 = new List<PersonVM>();


        // om vi vill ta data direkt från label felt
        public PersonVM person { get; set; }

        // läg till people i vår data bas
        public static void GeneratePeople()
        {
            // Add till listan 
            listOfPeople.Add(new PersonVM { Id = Guid.NewGuid().ToString(), Name = "ali khawari ", City = "staden 1", PhoneNumber = "123456789", Register = DateTime.Now });
            listOfPeople.Add(new PersonVM { Id = Guid.NewGuid().ToString(), Name = "seif ssssssss ", City = "staden 2", PhoneNumber = "123456789", Register = DateTime.Now });
            listOfPeople.Add(new PersonVM { Id = Guid.NewGuid().ToString(), Name = "meakel khakha  ", City = "staden 3", PhoneNumber = "123456789", Register = DateTime.Now });

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
