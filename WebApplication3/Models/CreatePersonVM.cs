using System.Collections;

namespace WebApplication3.Models
{
    public class CreatePersonVM : IEnumerable
    {
        // view till tabel modeln person 


        // databasen tillfällit
        public static List<PersonDataModel> listOfPeople = new List<PersonDataModel>();

        public List<PersonDataModel> tempList = new List<PersonDataModel>();
        public List<PersonDataModel> tempList1 = new List<PersonDataModel>();


        // om vi vill ta data direkt från label felt
        public PersonDataModel person { get; set; }

        // läg till people i vår data bas
        public static void GeneratePeople()
        {
            // Add till listan 
            listOfPeople.Add(new PersonDataModel { Id = Guid.NewGuid().ToString(), Name = "ali khawari ", City = "staden 1", PhoneNumber = "123456789", Register = DateTime.Now });
            listOfPeople.Add(new PersonDataModel { Id = Guid.NewGuid().ToString(), Name = "seif ssssssss ", City = "staden 2", PhoneNumber = "123456789", Register = DateTime.Now });
            listOfPeople.Add(new PersonDataModel { Id = Guid.NewGuid().ToString(), Name = "meakel khakha  ", City = "staden 3", PhoneNumber = "123456789", Register = DateTime.Now });

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
