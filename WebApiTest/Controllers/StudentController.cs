using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.BE;
using TestApi.BL;

namespace WebApiTest.Controllers
{
    public class StudentController : ApiController
    {
        // GET api/Student
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Student/5
        public IEnumerable<StudentBE> Get(int id)
        {
            IEnumerable<StudentBE> res = null;
            StudentBL studentBL = new StudentBL();
            switch (id)
            {
                case 1:
                    res = studentBL.GetAllStudents();
                    break;
                default:
                    break;
            }
            return res;
        }

        // POST api/Student
        public ResponseMyApi Post([FromBody]  StudentBE student)
        {
            ResponseMyApi res = new ResponseMyApi();

            res.Status = 0;
            res.DescRespuesta = student.ToString();

            return res;
        }

        // PUT api/Student/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Student/5
        public void Delete(int id)
        {
        }
    }
}