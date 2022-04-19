﻿using Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ICategoryService
    {
        Task<CustomResponseDto<CategoryWithProductDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}