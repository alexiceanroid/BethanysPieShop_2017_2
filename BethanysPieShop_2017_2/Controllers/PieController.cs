using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop_2017_2.Models;
using BethanysPieShop_2017_2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop_2017_2.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var piesListViewModel = new PiesListViewModel()
            {
                Pies = _pieRepository.Pies,
                CurrentCategory = "Cheese cakes"
            };
            return View(piesListViewModel);
        }
    }
}
