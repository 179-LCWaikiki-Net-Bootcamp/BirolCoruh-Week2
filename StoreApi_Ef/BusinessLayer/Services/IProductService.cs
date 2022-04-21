using Dtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IProductService
    {
        void AddService(ProductAddDto item);
        void UpdateService(ProductUpdateDto item);
        void DeleteService(int id);
        List<ProductDto> GetAllService();
        Product GetByIdService(int id);
        IEnumerable<ProductDto> Search([FromQuery] ProductDto search);
    }
}
