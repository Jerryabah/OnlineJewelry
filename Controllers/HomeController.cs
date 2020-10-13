using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineJewelry.Models;
using OnlineJewelry.ViewModels;

namespace OnlineJewelry.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJewelryRepository _jewelryRepository;

        public HomeController(IJewelryRepository jewelryRepository)
        {
            _jewelryRepository = jewelryRepository;
        }

        public IActionResult Index()
        {
            var listJewelry = new JewelryListViewModel();
            listJewelry.Jewelries = _jewelryRepository.GetAllJewelry().Take(6);
            return View(listJewelry);
        }
    }
}
