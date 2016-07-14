using AutoMapper;
using SOEDU.Api.Models.ViewModels;
using SOEDU.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOEDU.Api.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Sys_Course, CourseViewModel>();
            //Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            //Mapper.CreateMap<Tag, TagViewModel>();
            //Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            //Mapper.CreateMap<Product, ProductViewModel>();
            //Mapper.CreateMap<ProductTag, ProductTagViewModel>();
            //Mapper.CreateMap<Footer, FooterViewModel>();
            //Mapper.CreateMap<Slide, SlideViewModel>();
        }
    }
}