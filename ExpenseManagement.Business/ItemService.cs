using ExpenseManagement.Business.Interfaces;
using ExpenseManagement.Data.Data;
using ExpenseManagement.Model;
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration config;
        public ItemService(ExpenseManagementDbContext _db, IConfiguration config)
        {
            this._db = _db;
            this.config = config;
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
