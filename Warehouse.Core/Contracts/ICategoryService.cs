using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Core.Models;

namespace Warehouse.Core.Contracts
{
    public interface ICategoryService
    {
        Task<CategoryListViewModel> GetCategories(int pageNo, int pageSize);
    }
}
