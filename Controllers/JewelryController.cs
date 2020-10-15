using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineJewelry.Models;
using OnlineJewelry.ViewModels;

namespace OnlineJewelry.Controllers
{
    public class JewelryController : Controller
    {
        private readonly IJewelryRepository _jewelryRepository;
        private readonly ICategoryRepository _categoryRepository;
        public JewelryController(IJewelryRepository jewelryRepository, ICategoryRepository categoryRepository)
        {
            _jewelryRepository = jewelryRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var jewelriesListViewModel = new JewelryListViewModel();
            jewelriesListViewModel.Jewelries = _jewelryRepository.GetAllJewelry();
            return View(jewelriesListViewModel);
        }

        public IActionResult Details(int idJewelry)
        {
            var jewelry = _jewelryRepository.GetJewelryById(idJewelry);
            if (jewelry == null)
            {
                return NotFound();
            }
            return View(jewelry);
        }

        //public IActionResult About()
        //{
           
        //    return View(About);
        //}

        //private IActionResult View(Func<IActionResult> about)
        //{
        //    return View(About);
        //}
    }
}
