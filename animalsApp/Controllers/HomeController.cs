using System.Diagnostics;
using animalsApp.Models;
using animalsApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace animalsApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private List<Animal> animals = new List<Animal>()
        {
            new Animal{Id = 1 ,Name ="Monkey"},
            new Animal{Id =2 ,Name = "Cat"},
            new Animal{Id =3 ,Name = "Dog"},
            new Animal{Id = 4 , Name ="Hawk"},
            new Animal {Id = 5 ,Name ="Eagle"}
        };

        private List<Zoo> zoos = new List<Zoo>()
        {
            new Zoo{Id =1 , City="London"},
            new Zoo{Id =2 ,City="New York"},
            new Zoo {Id =3 ,City = "paris"},
            new Zoo {Id =4 ,City ="Tokyo"},
            new Zoo {Id =5 ,City ="sydney"}
        };



        public IActionResult Index()
        {
            AnimalZooViewData vm = new AnimalZooViewData();
            vm.Animals = animals;
            vm.Zoos = zoos;


            return View(vm);
        }

       
    }
}
