using AutomationSorting.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSorting.Data
{
    public static class RepositoryFactory
    {
        public static IUpcRepository GetUpcRepository()
        {
            throw new NotImplementedException();
        }

        public static ISlpRepository GetSlpRepository()
        {
            throw new NotImplementedException();
        }

        public static IProductRepository GetProductRepository()
        {
            throw new NotImplementedException();
        }
    }
}
