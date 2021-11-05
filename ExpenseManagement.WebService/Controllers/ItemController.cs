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
        private readonly ExpenseManagementDbContext _db;
        public ItemController(ExpenseManagementDbContext _db)
        {
            this._db = _db;
        }
        public IActionResult Index()
        {

            IEnumerable<Item> objectList = _db.Items.OrderBy(x=>x.Id).ToList();

            return View(objectList);
        }
    }
}
