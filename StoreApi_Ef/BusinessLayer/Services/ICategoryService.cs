﻿using Dtos;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ICategoryService : IGenericService<Category,CategoryDto>
    {
        CustomResponseDto<CategoryWithProductDto> GetSingleCategoryByProductDto(int productId);
    }
}
