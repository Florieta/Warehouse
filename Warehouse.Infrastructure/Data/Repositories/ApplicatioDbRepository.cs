using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Infrastructure.Data.Common;

namespace Warehouse.Infrastructure.Data.Repositories
{
    
        public class ApplicatioDbRepository : Repository, IApplicatioDbRepository
        {
            public ApplicatioDbRepository(ApplicationDbContext context)
            {
                this.Context = context;
            }
        }
    
}
