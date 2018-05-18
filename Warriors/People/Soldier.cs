using System;
using Warriors;
using Warriors.Soldiers;

namespace People
{
    class Soldier: Person
    {
        public int YearOfExperience { get; set; }
        public string Specialty { get; set; }

        public Soldier()
        {

        }

        public Soldier(string name, int id, Gender gender, int age, int experience, string specialty)
        : base (name, id, gender, age)
        {
            YearOfExperience = experience;
            Specialty = specialty;
        }

        public void Action()
        {
            Work("Assures safety of the land.");
        }

        public void Fight(string action, IBattleStrategy battleStrategy)
        {
            battleStrategy.Engage();
            Console.WriteLine(action);
            battleStrategy.Disenage();
        }
    }
}
