using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using SalesWebMvc.Services.Exception;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                return RedirectToAction(nameof(Error), new { message = "Id is null" });
            }

            var obj = _selllerServices.FindById(id.Value);

            if(obj == null)
            {
             return RedirectToAction(nameof(Error), new { message = "Id not found" });
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
                return RedirectToAction(nameof(Error), new { message = "Id is null" });
            }

            var obj = _selllerServices.FindById(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }


        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id is null" });
            }

            var obj = _selllerServices.FindById(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<Departament> departaments = _departamentService.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departaments = departaments };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            
            if(id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }

            try
            {

                _selllerServices.Update(seller);

                return RedirectToAction(nameof(Index));

            }
            catch (NotFoundException e)
            {

                return RedirectToAction(nameof(Error), new { message = e.Message }); 
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
       
        }

        public IActionResult Error(string message)
        {

            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }
    }
}
