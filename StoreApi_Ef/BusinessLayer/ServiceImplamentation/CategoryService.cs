using AutoMapper;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using DataAccessLayer.Abstract;
using Dtos;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ServiceImplamentation
{
    internal class CategoryService : ICategoryService
    {
        ICategoryDal _categoryDal;
        IMapper _mapper;
        public CategoryService(ICategoryDal categoryDal,IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        public void AddService(CategoryDto item)
        {
            Category Category = _mapper.Map<CategoryDto, Category>(item);
            _categoryDal.Insert(Category);
        }

        public void DeleteService(int id)
        {
            Category category =  _categoryDal.GetById(id);
            if (category == null)
            {
                throw new NotFoundException("Kategori bulunamadı");
            }
           _categoryDal.Delete(category);
        }

        public List<CategoryDto> GetAllService()
        {
            return _mapper.Map<IEnumerable<Category>, List<CategoryDto>>( _categoryDal.GetAll());
        }

        public void GetByIdService(int id)
        {
            _mapper.Map<Category, CategoryDto>( _categoryDal.GetById(id));
        }

        public CustomResponseDto<CategoryWithProductDto> GetSingleCategoryByProductDto(int productId) // bunu düzelt, search ekle ve controllerları yap
        {
          return _mapper.Map<Category, CategoryDto>(_categoryDal.GetSingleCategoryByProductAsync(productId));
        }

        public void UpdateService(CategoryDto item)
        {
            Category Category = _mapper.Map<CategoryDto, Category>(item);
            _categoryDal.Update(Category);
        }
    }