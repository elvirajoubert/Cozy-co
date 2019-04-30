using CozyCo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CozyCo.WebUI.Controllers
{
    public class PropertyController : Controller
    {
        private List<Property> Properties = new List<Property>
        {
            new Property {Id = 1, Address = "123 Main Street", City = "Austin", Zipcode = "78753"},
            new Property {Id = 2, Address = "456 Second Street", City = "Boston", Zipcode = "123456"},
        };



        //property index
        public IActionResult Index()

        {
            return View(Properties);
        }

        //GET property/add
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Property newProperty) //receive data from HTML form.
        {
            Properties.Add(newProperty);
            return View(nameof(Index), Properties);

        }

        public IActionResult Detail(int id) //we get id from URL
        {

            var property = Properties.Single(p => p.Id == id);

            return View(property);
        }

        public IActionResult Delete(int id)
        {
            var property = Properties.Single(p => p.Id == id);

            Properties.Remove(property);

            return View(nameof(Index), Properties);
        }


        //property/edit/1
        public IActionResult Edit(int id)  //--> we get Id  from URL
        {

            var property = Properties.Single(p => p.Id == id);
            return View(property);
        }
    }
}