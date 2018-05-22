using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace Warriors.Weapons
{
    public interface IWeapon
    {
        void Attack(Person person);
    }
}
