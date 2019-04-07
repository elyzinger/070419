using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070419
{
    interface IEmployeeDAO
    {
        List<object> GetTotalEmployesOfDepartment();
    }
}
