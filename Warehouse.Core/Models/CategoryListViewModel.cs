using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Infrastructure.Data;

namespace Warehouse.Core.Models
{
    public class CategoryListViewModel
    {
        public int PageNo { get; set; }
        public int TotalRecords { get; set; }
        public int PageSize { get; set; }
        public List<Category> Categories { get; set; }
    }
}
