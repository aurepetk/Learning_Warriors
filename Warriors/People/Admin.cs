using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors
{
    class Admin:People.Person
    {
        public Admin(string name, int id, Gender gender, int age)
        :base (name, id, gender, age)
        {
           
        }
        public void Action()
        {
            Work("Assures proper work of the project.");
        }
    }
}
