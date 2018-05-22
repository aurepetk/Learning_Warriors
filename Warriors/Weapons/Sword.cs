using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace Warriors.Weapons
{
    class Sword: IWeapon
    {
        private const int maxDistance = 2;
        public Person owner { get; set; }

        private double distance = 0;

        public bool IsInRange(Person person)
        {
            distance = DistanceCalculator.DistanceBetweenWarriors(person.Coordinate, owner.Coordinate);
            return distance <= maxDistance;
        }

        public void Attack(Person person)
        {
            if (IsInRange(person))
            {
                Console.WriteLine("Hits the enemy.");
            }
            else
            {
                Console.WriteLine("Enemy is not in range.");
            }
        }
    }
}
