using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_swagger_demo.Model
{
    public class Student
    {
        /// <summary>
        /// 学生id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 学生名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }        

    }
}
