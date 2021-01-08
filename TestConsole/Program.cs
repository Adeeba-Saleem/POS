using POS.Domain.Model;
using POS.Domain.Services;
using POS.EF.Services;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<BrandTable> brandService = new GenericDataService<BrandTable>(new POS.EF.POSDBContextFactory());

            brandService.Create(new BrandTable { BrandName = "sony" }).Wait();
              
        }
    }
}
