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
    public class BrandTableServices : IBrandTable
    {
        private readonly IDataService<BrandTable> _brandservices;

        public BrandTableServices()
        {
            _brandservices = new GenericDataService<BrandTable>(new POSDBContextFactory());
        }

        public async Task<BrandTable> AddBrand(string BrandName)
        {
            try
            {
                if (BrandName == string.Empty)
                {
                    throw new Exception("Brand Name Can not Empty");

                }
                else
                {
                    BrandTable brand = new BrandTable
                    {
                        BrandName = BrandName

                    };
                   return await _brandservices.Create(brand);

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteBrand(int ID)
        {
            try
            {
                BrandTable brand = await SearchBrandById(ID);
                return await _brandservices.Delete(brand);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ICollection<BrandTable>> ListBrands()
        {
            try
            {
                return (ICollection<BrandTable>)await _brandservices.GetAll();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Task<BrandTable> SearchBrandById(int ID)
        {
            try
            {
                return _brandservices.Get(ID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ICollection<BrandTable>> SearchByBrandName(string BrandName)
        {
            try
            {
                var listbrand = await ListBrands();
                return listbrand.Where(x => x.BrandName.StartsWith(BrandName)).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<BrandTable> UpdateBrand(int ID, string BrandName)
        {
            try
            {
                BrandTable brand = await SearchBrandById(ID);
                brand.BrandName = BrandName;
                return await _brandservices.Update(brand);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
