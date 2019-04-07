using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070419
{
    class Employee
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int Department_ID { get; set; }

        public static bool operator ==(Employee c1, Employee c2)
        {
            if ((c1 == null) && (c2 == null))
                return true;
            if ((c1 == null) || (c2 == null))
                return false;

            return (c1.ID == c2.ID);
        }
        public static bool operator !=(Employee c1, Employee c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Employee c = obj as Employee;
            if (c == null)
                return false;

            return this.ID == c.ID;
        }

        public override int GetHashCode()
        {
            return this.ID;
        }


        public override string ToString()
        {
            return $"Employee Id {ID}, Name {Name}, Age {Age}, Salary {Salary}";
        }
    }
}
