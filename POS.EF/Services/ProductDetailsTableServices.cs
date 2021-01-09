using POS.Domain.Model;
using POS.Domain.Services;
using POS.Domain.Services.Common;
using POS.EF.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.EF.Services
{
    public class ProductDetailsTableServices : IProductDetailServices
    {
        private readonly IDataService<ProductsDetailTable> _productservices;

        public ProductDetailsTableServices()
        {
            _productservices = new GenericDataService<ProductsDetailTable>(new POSDBContextFactory());
        }

        public async Task<ProductsDetailTable> AddProduct(string ProductID, string ProductName, int CategoryID,
            int BrandID, string Barcode, decimal Price, decimal Cost, decimal Discount,
            bool ExpiryStatus, string ValuationMethod, bool ActiveStatus)
        {
            try
            {
                ProductsDetailTable product = new ProductsDetailTable
                {
                    ProductId = ProductID,
                    ProductName = ProductName,
                    CategoryId = CategoryID,
                    BrandId = BrandID,
                    Barcode = Barcode,
                    Price = Price,
                    Cost = Cost,
                    Discount = Discount,
                    ExpiryStatus = ExpiryStatus,
                    ValuationMethod = ValuationMethod,
                    ActiveStatus = ActiveStatus
                };
                return await _productservices.Create(product);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<string> GenerateProductID(int option)
        {
            switch (option)
            {
                case 1:
                    {
                        var List = await ListProducts();
                        var LastRecord = List.ToList().LastOrDefault();
                        return (int.Parse(LastRecord.ProductId) + 1).ToString();

                    }

                case 2:
                    {
                        Random rand = new Random();
                        return rand.Next().ToString();
                    }

                case 3:
                    {
                        var List = await ListProducts();
                        var CurrentRecordNo = int.Parse(List.ToList().LastOrDefault().ProductId) + 1;
                        var cYear = DateTime.Today.Year;
                        var cMonth = DateTime.Today.Month;
                        var cDate = DateTime.Today.Date;

                        return cYear.ToString() + cMonth.ToString() + cDate.ToString() + CurrentRecordNo.ToString();
                    }
                case 4:
                    {
                        Guid guid = new Guid();
                        return guid.ToString();
                    }
            }
            return null;
        }



        public async Task<bool> DeleteProduct(string ProductID)
        {
            try
            {
                ProductsDetailTable product = await SearchProductByID(ProductID);
                return await _productservices.Delete(product);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ICollection<ProductsDetailTable>> ListProducts()
        {
            try
            {
                return (ICollection<ProductsDetailTable>)await _productservices.GetAll();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ICollection<ProductsDetailTable>> SearchByProductName(string ProductName)
        {
            try
            {
                var listbrand = await ListProducts();
                return listbrand.Where(x => x.ProductName.StartsWith(ProductName)).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductsDetailTable> SearchProductByBarcode(string Barcode)
        {
            try
            {
                var List = await ListProducts();
                return List.ToList().Where(x => x.Barcode == Barcode).ToList().FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductsDetailTable> SearchProductByID(string ProductID)
        {
            try
            {
                var List = await ListProducts();
                return List.ToList().Where(x => x.ProductId == ProductID).ToList().FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductsDetailTable> UpdateBrand(string ProductID, string ProductName, 
            int CategoryID, int BrandID, string Barcode, decimal Price, decimal Cost,
            decimal Discount, bool ExpiryStatus, string ValuationMethod, bool ActiveStatus)
        {
            try
            {
                ProductsDetailTable product = await SearchProductByID(ProductID);
                product.ProductName =ProductName;
                product.CategoryId = CategoryID;
                product.BrandId = BrandID;
                product.Barcode = Barcode;
                product.Price = Price;
                product.Cost = Cost;
                product.Discount = Discount;
                product.ExpiryStatus = ExpiryStatus;
                product.ValuationMethod = ValuationMethod;
                product.ActiveStatus = ActiveStatus;
                return await  _productservices.Update(product);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
