using System;
using System.Collections.Generic;
using Warriors;
using Warriors.Weapons;

namespace People
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Gender Gender{ get; set; }
        public int Age { get; set; }
        public Point Coordinate { get; set; }
        public IWeapon Weapon { get; set; }

        public Person(string name, int id, Gender gender, int age, Point coordinate)
        {
            Name = name;
            Id = id;
            Gender = gender;
            Age = age;
            Coordinate = coordinate;

            int weaponId = new Random().Next(0, 2);
            switch (weaponId)
            {
                case 0:
                    Weapon = new Sword();
                    break;
                case 1:
                    Weapon = new Bow();
                    break;
                case 2:
                    Weapon = new Pistol();
                    break;
            }
        }

        public void Work(string action)
        {
            Console.WriteLine(action);
        }

        public Person AddToList(List<Person> people)
        {
            people.Add(this);
            return this;
        }
    }
}
