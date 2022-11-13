using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        // kallas action och passar en id 
        [HttpPost]
        public IActionResult GetDetails(string id)
        {
         // lagera en person model i variabellen   /  hittar personen i lista med ID 
            Person person = CreatePerson.listOfPeople.FirstOrDefault(x => x.Id == id);

            // skickar en partial view som tar in en person model 
            return PartialView("_personPartial_View", person);
        }

        public IActionResult Delete(string id)
        {
            // första item (people med den ID som hittas i listan)
            var personToDelete = CreatePerson.listOfPeople.FirstOrDefault(x => x.Id == id);

            if (personToDelete != null)
            {
                CreatePerson.listOfPeople.Remove(personToDelete);
            }
            return View();
        }

        public IActionResult GetAllPeople()
        {
            if (CreatePerson.listOfPeople.Count == 0)
            {
                CreatePerson.GeneratePeople();
            }

            // för att temp list är inte static vi bör skapa
            // en stance av classen föratt kunna komma åt den !
            CreatePerson vm = new CreatePerson();
            vm.tempList = CreatePerson.listOfPeople;  // fylla på den lista med sökande Item 

            return View(vm); // skickar till view 
            
        }

    }
}
