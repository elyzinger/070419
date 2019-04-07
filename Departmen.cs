using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070419
{
    class Departmen
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public int TotalEmp { get; set; }
      
       

        public static bool operator ==(Departmen c1, Departmen c2)
        {
            if ((c1 == null) && (c2 == null))
                return true;
            if ((c1 == null) || (c2 == null))
                return false;

            return (c1.ID == c2.ID);
        }
        public static bool operator !=(Departmen c1, Departmen c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Departmen c = obj as Departmen;
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
            return $"Departmen Id {ID}, Name {Name}, TotalEmp {TotalEmp}";
        }
    }
}
