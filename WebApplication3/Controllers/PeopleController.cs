using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            if(CreatePerson.listOfPeople.Count ==0)
            {
                CreatePerson.GeneratePeople();
            }

             // för att temp list är inte static vi bör skapa
             // en stance av classen föratt kunna komma åt den !
            CreatePerson vm = new CreatePerson();
            vm.tempList = CreatePerson.listOfPeople;  // fylla på den lista med sökande Item 
            
            return View(vm); // skickar till view 
        }

        // kalla metoden till View
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]                  // istället (string name , int age , string phonenumber)
        public IActionResult Create(Person person)
        {


            if(person != null)
            {
                person.Id = Guid.NewGuid().ToString();
                person.Register = DateTime.Now;

                CreatePerson.listOfPeople.Add(person);
            } 

                   // gå till ACTION Indec ( inte till någon VIEW )
            return RedirectToAction("Index");

            //if (ModelState.IsValid)
            //{
            //    return RedirectToAction("Index");
            //}
        }



        // action till Delete vilken sker när man klicka på Delet button och tagit (person.Id) med sig 
        public IActionResult Delete(string id)
        {
                                             // första item (people med den ID som hittas i listan)
            var personToDelete = CreatePerson.listOfPeople.FirstOrDefault(x => x.Id == id);

            if(personToDelete != null)
            {
                CreatePerson.listOfPeople.Remove(personToDelete);
            }
            return RedirectToAction("Index");
        }



    }
}
