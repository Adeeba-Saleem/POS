using POS.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace POS.Domain.Services
{
    public interface IProductDetailServices
    {
        Task<ProductsDetailTable> AddProduct(string ProductID, string ProductName,
            int CategoryID, int BrandID, string Barcode, decimal Price, decimal Cost, decimal Discount,
            bool ExpiryStatus, string ValuationMethod, bool ActiveStatus);
        Task<ProductsDetailTable> UpdateBrand(string ProductID, string ProductName,
            int CategoryID, int BrandID, string Barcode, decimal Price, decimal Cost, decimal Discount,
            bool ExpiryStatus, string ValuationMethod, bool ActiveStatus);
        Task<bool> DeleteProduct(string ProductID);
        Task<ProductsDetailTable> SearchProductByID(string ProductID);
        Task<ProductsDetailTable> SearchProductByBarcode(string Barcode);
        Task<ICollection<ProductsDetailTable>> SearchByProductName(string ProductName);
        Task<ICollection<ProductsDetailTable>> ListProducts();
    }
}
