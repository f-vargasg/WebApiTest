using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.BE;

namespace TestApi.BL
{
    public class StudentBL
    {

        public StudentBE GetStudentPorID (int id)
        {
            StudentBE res = null;

            res = new StudentBE
            {
                Codigo = 1,
                Nombre = "Estud1"
            };

            return res;
        }

        public List<StudentBE> GetAllStudents()
        {
            List<StudentBE> res = new List<StudentBE>();

            res.Add(new StudentBE
            {
                Codigo = 1,
                Nombre = "Estud1"
            });

            res.Add(new StudentBE
            {
                Codigo = 2,
                Nombre = "Estud2"
            });

            res.Add(new StudentBE
            {
                Codigo = 3,
                Nombre = "Estud3"
            });

            return res;
        }


    }
}
