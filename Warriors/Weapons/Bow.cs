using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace Warriors.Weapons
{
    class Bow: IWeapon
    {
        private const int maxDistance = 20;
        public Person owner { get; set; }

        public bool IsInRange(Person person)
        {
            var distance = DistanceCalculator.DistanceBetweenWarriors(owner.Coordinate, person.Coordinate);
            return distance <= maxDistance;
        }

        public void Attack(Person person)
        {
            if (IsInRange(person))
            {
                Console.WriteLine("Shooting arrrows into the enemy.");
            }
            else
            {
                Console.WriteLine("Enemy is not in range.");
            }
        }
    }
}
