using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace Interfaces
{
    public interface ICategoryService
    {
        List<CategoryEntity> GetAllCategories(string SearchValue, int PageNo, int PageSize, string SortColumn = null, string SortOrder = null);
        CategoryEntity GetCategorDetailbyId(Guid Id);
        Guid SaveData(CategoryEntity tvm);
        void DeleteCategorybyId(Guid Id);
    }
}
