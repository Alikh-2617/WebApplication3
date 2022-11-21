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
            PersonDataModel person = CreatePersonVM.listOfPeople.FirstOrDefault(x => x.Id == id);
            List<PersonDataModel> tempList = new List<PersonDataModel>();
            tempList.Add(person);
            // skickar en partial view som tar in en person model
            return PartialView("_personPartial_View", tempList);
        }

        public IActionResult Delete(string id)
        {
            // första item (people med den ID som hittas i listan)
            var personToDelete = CreatePersonVM.listOfPeople.FirstOrDefault(x => x.Id == id);

            if (personToDelete != null)
            {
                CreatePersonVM.listOfPeople.Remove(personToDelete);
            }
            return PartialView("_personPartial_View", CreatePersonVM.listOfPeople);
        }


        [HttpPost]
        public IActionResult GetAllPeople()
        {
            if (CreatePersonVM.listOfPeople.Count == 0)
            {
                CreatePersonVM.GeneratePeople();
            }
            
            CreatePersonVM vm = new CreatePersonVM();
            vm.tempList = CreatePersonVM.listOfPeople;

            return PartialView("_personPartial_View", CreatePersonVM.listOfPeople);


        }

    }
}
