using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using BusinessEntities;
using AutoMapper;

namespace MapperUtility
{
    public class MapperUtil
    {

        public static void InitializeMapper()
        {


            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Category, CategoryEntity>().ReverseMap();
            });
        }
    }
}
