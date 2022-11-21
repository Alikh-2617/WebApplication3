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
            PersonVM person = CreatePerson.listOfPeople.FirstOrDefault(x => x.Id == id);
            List<PersonVM> tempList = new List<PersonVM>();
            tempList.Add(person);
            // skickar en partial view som tar in en person model
            return PartialView("_personPartial_View", tempList);
        }

        public IActionResult Delete(string id)
        {
            // första item (people med den ID som hittas i listan)
            var personToDelete = CreatePerson.listOfPeople.FirstOrDefault(x => x.Id == id);

            if (personToDelete != null)
            {
                CreatePerson.listOfPeople.Remove(personToDelete);
            }
            return PartialView("_personPartial_View", CreatePerson.listOfPeople);
        }


        [HttpPost]
        public IActionResult GetAllPeople()
        {
            if (CreatePerson.listOfPeople.Count == 0)
            {
                CreatePerson.GeneratePeople();
            }
            
            CreatePerson vm = new CreatePerson();
            vm.tempList = CreatePerson.listOfPeople;

            return PartialView("_personPartial_View", CreatePerson.listOfPeople);


        }

    }
}
