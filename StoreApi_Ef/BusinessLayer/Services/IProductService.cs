using Dtos;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IProductService:IGenericService<Category,ProductDto>
    {
        CustomResponseDto<List<ProductWithCategoryDto>> GetProductsWithCategoryDto(int categoryId);
    }
}
