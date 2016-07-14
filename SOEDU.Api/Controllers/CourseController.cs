using SOEDU.Api.Infrastructure.Core;
using SOEDU.Entities.Models;
using SOEDU.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOEDU.Api.Controllers
{
    [RoutePrefix("api/course")]
    public class CourseController : ApiControllerBase
    {
        ICourseService _courseService;
        public CourseController(IErrorService errorService, ICourseService courseService) : base(errorService)
        {
            this._courseService = courseService;
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listCategory = _courseService.GetAll();

                //var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(listCategory);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK);

                return response;
            });
        }
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, Sys_Course course)
        {
            return CreateHttpResponse(request, () => {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    //Sys_Course newCourse = new Sys_Course();

                    var newCourse = _courseService.Add(course);
                    _courseService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, newCourse);


                }
                return response;
            });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, Sys_Course course)
        {
            return CreateHttpResponse(request, () => {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    //Sys_Course newCourse = new Sys_Course();

                    _courseService.Update(course);
                    _courseService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);


                }
                return response;
            });
        }
        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _courseService.Delete(id);
                    _courseService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }
}
