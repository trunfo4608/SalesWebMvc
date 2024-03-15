using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _selllerServices;
        private readonly DepartamentService _departamentService;
        public SellersController(SellerService selllerServices, DepartamentService departamentService)
        {
            _selllerServices = selllerServices;
            _departamentService = departamentService;
        }

        public IActionResult Index()
        {
            var list = _selllerServices.FindAll();

            return View(list);
        }

        public IActionResult Create()
        {
            var departaments = _departamentService.FindAll();
            var viewModel =  new SellerFormViewModel { Departaments = departaments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _selllerServices.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _selllerServices.FindById(id.Value);

            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _selllerServices.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if( id == null)
            {
                return NotFound();
            }

            var obj = _selllerServices.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
    }
}
