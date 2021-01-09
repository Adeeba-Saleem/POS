using POS.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Services
{
    public interface IBrandTable
    {
       Task<BrandTable> AddBrand(string BrandName);
       Task<BrandTable> UpdateBrand(int ID, string BrandName );
       Task<bool> DeleteBrand(int ID);
        Task<BrandTable> SearchBrandById(int ID);
        Task<ICollection<BrandTable>> SearchByBrandName(string BrandName);
        Task<ICollection<BrandTable>> ListBrands();

    }
}
