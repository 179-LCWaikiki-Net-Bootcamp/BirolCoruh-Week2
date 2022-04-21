using BusinessLayer.Services;
using Dtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class ProductManager : IProductService
    {
        public void AddService(ProductAddDto item)
        {
            throw new NotImplementedException();
        }

        public void DeleteService(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDto> GetAllService()
        {
            throw new NotImplementedException();
        }

        public Product GetByIdService(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> Search([FromQuery] ProductDto search)
        {
            throw new NotImplementedException();
        }

        public void UpdateService(ProductUpdateDto item)
        {
            throw new NotImplementedException();
        }
    }
}
