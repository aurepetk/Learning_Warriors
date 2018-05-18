using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace Warriors.Soldier
{
    class Officer: People.Soldier
    {
        public Officer (string name, int id, Gender gender, int age, int experience, string specialty)
            : base(name, id, gender, age, experience, specialty)
        {

        }

        public void OfficerAction()
        {

            Fight("Opens balistic fire to destroy the enemy.");
        }
    }
}
