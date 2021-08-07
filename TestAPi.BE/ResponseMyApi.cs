using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.BE
{
    public class ResponseMyApi
    {
        public int Status { get; set; }
        public string DescRespuesta { get; set; }


        public override string ToString()
        {
            return "{ Status => " + this.Status.ToString() + " - DescRespuesta => " + this.DescRespuesta + "}"; 
        }
    }
}
