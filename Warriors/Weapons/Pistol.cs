using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace Warriors.Weapons
{
    class Pistol: IWeapon
    {
        private const int maxDistance = 60;
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
                Console.WriteLine("Shooting bullets into the enemy.");
            }
            else
            {
                Console.WriteLine("Enemy is not in range.");
            }
        }
    }
}
