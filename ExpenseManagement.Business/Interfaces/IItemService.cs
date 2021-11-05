using ExpenseManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Business.Interfaces
{
    public interface IItemService
    {
        List<Item> GetAllItems();
    }
}
