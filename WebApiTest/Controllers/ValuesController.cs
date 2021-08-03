using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.BE;

namespace WebApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        public object Get(int id)
        {
           object resultado = "value";
            switch (id)
            {
                case 1:
                    resultado = new StudentBE
                    {
                        Codigo = 1,
                        Nombre = "Estud1"
                    };
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            return resultado;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
