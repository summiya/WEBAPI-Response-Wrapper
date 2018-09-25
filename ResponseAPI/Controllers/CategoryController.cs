using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Web;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Web.Configuration;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities;
using Interfaces;
using VMD.RESTApiResponseWrapper.Net.Wrappers;
using AkshaakWebAPI.Helpers;
using System.Net.Http.Formatting;

namespace AkshaakWebAPI.Controllers
{

    public class CategoryController : ApiController
    {

        private readonly ICategoryService _categoryservice;
        CategoryEntity _categoryentity = null;

        public CategoryController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }

        [HttpGet]
        [Route("api/GetAllCategories/")]
        public APIResponse GetAllCategories(string SearchValue = null, int PageNo = 1, int PageSize = 10, string SortColumn = null, string SortOrder = null)
        {
            var response = _categoryservice.GetAllCategories(SearchValue, PageNo, PageSize, SortColumn, SortOrder);
            return new APIResponse(200, "Success", response, null, "1.0.0.0");
        }

        [HttpGet]
        [Route("api/GetCategorDetailbyId/{Id}")]
        public APIResponse GetCategorDetailbyId(Guid Id)
        {
            try
            {
                _categoryentity = _categoryservice.GetCategorDetailbyId(Id);

                if (_categoryentity != null)
                {

                    return new APIResponse((int)HttpStatusCode.OK, "Success", _categoryentity, null, "1.0.0.0");
                }

                return new APIResponse((int)HttpStatusCode.NotFound, "No Record Found with ID" + Id, null, null, "1.0.0.0");
            }
            catch (Exception e)
            {
                return new APIResponse((int)HttpStatusCode.ExpectationFailed, e.Message, null, null, "1.0.0.0");
            }
        }


        [HttpPost]
        [Route("api/AddCategory")]
        [Route("api/UpdateCategory")]
        public APIResponse AddCategory([FromBody]dynamic form)
        {
            try
            {
                Guid Id = _categoryservice.SaveData(form);
                return new APIResponse((int)HttpStatusCode.Created, "Success", null, null, "1.0.0.0");

            }
            catch (Exception ex)
            {
                return new APIResponse((int)HttpStatusCode.BadRequest, ex.Message, null, null, "1.0.0.0");

            }

        }


        [HttpDelete]
        [Route("api/DeleteCategory")]
        public APIResponse DeleteCategory(Guid Id)
        {
            try
            {
                _categoryentity = _categoryservice.GetCategorDetailbyId(Id);
                if (_categoryentity == null )
                {
                    return new APIResponse((int)HttpStatusCode.NotFound, "Failed", null, null, "1.0.0.0");
                }
                _categoryservice.DeleteCategorybyId(Id);
                return new APIResponse((int)HttpStatusCode.Created, "Success", null, null, "1.0.0.0");

            }
            catch (Exception ex)
            {
                return new APIResponse((int)HttpStatusCode.BadRequest, ex.Message, null, null, "1.0.0.0");

            }

        }




    }

}
