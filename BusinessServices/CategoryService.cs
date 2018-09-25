using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository;
using UnitOfWork;
using Interfaces;
using BusinessEntities;
using System.Data.SqlClient;
using DataBase;
using AutoMapper;
using MapperUtility;

namespace BusinessServices
{
    public class CategoryService : ICategoryService
    {

        private readonly UnitOfWork.UnitOfWork _unitOfWork;

        public CategoryService(UnitOfWork.UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void DeleteCategorybyId(Guid Id)
        {
            _unitOfWork.CategoryRepository.Delete(Id);
        }

        public List<CategoryEntity> GetAllCategories(string SearchValue, int PageNo, int PageSize, string SortColumn = null, string SortOrder = null)
        {
            var parameters = new SqlParameter[5];
            if (string.IsNullOrEmpty(SearchValue))
            {
                parameters[0] = new SqlParameter { ParameterName = "@SearchValue", Value = DBNull.Value };
            }
            else
            {
                parameters[0] = new SqlParameter { ParameterName = "@SearchValue", Value = SearchValue };

            }

            parameters[1] = new SqlParameter { ParameterName = "@PageNo", Value = PageNo };
            parameters[2] = new SqlParameter { ParameterName = "@PageSize", Value = PageSize };
            if (string.IsNullOrEmpty(SearchValue))
            {
                parameters[3] = new SqlParameter { ParameterName = "@SortColumn", Value = DBNull.Value };
            }
            else
            {
                parameters[3] = new SqlParameter { ParameterName = "@SortColumn", Value = SortColumn };

            }
            if (string.IsNullOrEmpty(SearchValue))
            {
                parameters[4] = new SqlParameter { ParameterName = "@SortOrder", Value = DBNull.Value };
            }
            else
            {
                parameters[4] = new SqlParameter { ParameterName = "@SortOrder", Value = SortOrder };


            }

            var categoriesData = _unitOfWork.CategoryRepository.SQLQuery<CategoryEntity>(
                 "exec usp_GetAllCategories @SearchValue, @PageNo, @PageSize, @SortColumn, @SortOrder ", parameters).ToList();

            if (categoriesData.Any())
            {
                List<CategoryEntity> datetoreturn = Mapper.Map<List<CategoryEntity>>(categoriesData);

                return datetoreturn;
            }
            return null;
        }

        public CategoryEntity GetCategorDetailbyId(Guid Id)
        {
            Category CategoryDetail = _unitOfWork.CategoryRepository.GetByID(Id);
            CategoryEntity _categoryentity = Mapper.Map<CategoryEntity>(CategoryDetail);
            return _categoryentity;

        }

        public Guid SaveData(CategoryEntity _categoryentity)
        {           
                Category _category = Mapper.Map<Category>(_categoryentity);
                
                if (_categoryentity.catID.ToString() !="")
                {
                    _unitOfWork.CategoryRepository.UpdateEntity(_category, _categoryentity.catID.ToString());
                }
                else
                {
                    _unitOfWork.CategoryRepository.Insert(_category);
                }

                _unitOfWork.Save();
                return _categoryentity.catID;
            
        }
    }
}
