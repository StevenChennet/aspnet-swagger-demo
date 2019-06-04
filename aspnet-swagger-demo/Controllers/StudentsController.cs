using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnet_swagger_demo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_swagger_demo.Controllers
{
    [Produces("application/json")]
    [Route("api/Students")]
    public class StudentsController : Controller
    {
        /// <summary>
        /// 获取所有学生
        /// </summary>
        /// <returns>学生列表集合</returns>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return new List<Student> {
                new Student { Id = "zhangsan", Name = "张三", Age = 10 },
                new Student { Id = "lisi", Name = "李四", Age = 11 },
            };
        }

        // GET: api/Students/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(string id)
        {
            return new Student { Id = id, Name = "张三", Age = 100 };
        }
        
        // POST: api/Students
        [HttpPost]
        public void Post([FromBody]Student student)
        {
        }
        
        // PUT: api/Students/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Student student)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {

        }
    }
}
