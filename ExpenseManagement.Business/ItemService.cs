using ExpenseManagement.Business.Interfaces;
using ExpenseManagement.Data.Data;
using ExpenseManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Business
{
    public class ItemService : IItemService
    {
        private readonly ExpenseManagementDbContext _db;
        public ItemService(ExpenseManagementDbContext _db)
        {
            this._db = _db;
        }

        public List<Item> GetAllItems()
        {
            var response = new List<Item>();

            var itemList = _db.Items;

            foreach(var items in itemList)
            {
                response.Add(items);
            }  

            return response;
        }
    }
}
