using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070419
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeDAO dao = new EmployeDAO();
            var result = dao.GetTotalEmployesOfDepartment();
            Console.WriteLine();
        }
    }
}
