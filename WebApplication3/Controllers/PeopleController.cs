using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            if (CreatePersonVM.listOfPeople.Count == 0)
            {
                CreatePersonVM.GeneratePeople();
            }

            // för att temp list är inte static vi bör skapa
            // en stance av classen föratt kunna komma åt den !
            CreatePersonVM vm = new CreatePersonVM();
            vm.tempList = CreatePersonVM.listOfPeople;  // fylla på den lista med sökande Item 

            return View(vm); // skickar till view 
        }

        // kalla metoden till View
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]                  // istället (string name , int age , string phonenumber)
        public IActionResult Create(PersonDataModel person)
        {


            if (person != null)
            {
                person.Id = Guid.NewGuid().ToString();
                person.Register = DateTime.Now;

                CreatePersonVM.listOfPeople.Add(person);
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
            var personToDelete = CreatePersonVM.listOfPeople.FirstOrDefault(x => x.Id == id);

            if (personToDelete != null)
            {
                CreatePersonVM.listOfPeople.Remove(personToDelete);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Serch(string name)
        {

            if (CreatePersonVM.listOfPeople.Count == 0)
            {
                CreatePersonVM.GeneratePeople();
            }
            //Testar git

            CreatePersonVM vm = new CreatePersonVM();

            PersonDataModel person = CreatePersonVM.listOfPeople.FirstOrDefault(x =>
                string.Equals(x.Name, name, StringComparison.Ordinal));

            if (person != null)
            {
                vm.tempList.Add(person);
            }

            return View("Index" , vm);
        }

    }
}
