using ExpenseManagement.Business.Interfaces;
using ExpenseManagement.Data.Data;
using ExpenseManagement.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManagement.WebService.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService _itemService)
        {
            this._itemService = _itemService;
        }
        public IActionResult Index()
        {

            var response = _itemService.GetAllItems();

            return View(response);
        }
    }
}
