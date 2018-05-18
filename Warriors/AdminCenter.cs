using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;
using Warriors.Soldier;

namespace Warriors
{
    public class AdminCenter
    {
        public const int neededSoldiersCount = 15;
        public const int minimalAge = 18;
        public const int maximumAge = 26;

        public List<Person> people = new List<People.Person>();

        public AdminCenter()
        {
            people = CreatePeople();
        }

        public List<Person> CreatePeople()
        {
            Person p1 = new General("Dominic Schultz", 1, Gender.Male, 45, 28, "Sniper").AddToList(people);
            Person p2 = new Admin("Maria Johnson", 2, Gender.Female, 36).AddToList(people);
            Person p3 = new Student("Peter Smith", 3, Gender.Male, 18).AddToList(people);
            Person p4 = new Recruiter("Sarah Star", 4, Gender.Female, 24, 6, "Balistics").AddToList(people);
            Person p5 = new Officer("Jack Sparrow", 5, Gender.Male, 32, 15, "Horseman").AddToList(people);
            Person p6 = new Student("Alice Morgan", 6, Gender.Female, 22).AddToList(people);
            Person p7 = new Officer("Dominic Pointer", 7, Gender.Male, 40, 22, "Horseman").AddToList(people);
            Person p8 = new Recruiter("Brian Junnior", 8, Gender.Male, 26, 8, "Balistics").AddToList(people);
            Person p9 = new Student("Peter Smith", 9, Gender.Male, 18).AddToList(people);
            Person p10 = new General("Dominic Schultz", 10, Gender.Male, 45, 28, "Sniper").AddToList(people);
            Person p11 = new Admin("Maria Johnson", 11, Gender.Female, 36).AddToList(people);
            Person p12 = new Student("Peter Smith", 12, Gender.Male, 18).AddToList(people);
            Person p13 = new Recruiter("Sarah Star", 13, Gender.Female, 24, 6, "Balistics").AddToList(people);
            Person p14 = new Officer("Jack Sparrow", 14, Gender.Male, 32, 15, "Horseman").AddToList(people);
            Person p15 = new Student("Alice Morgan", 15, Gender.Female, 22).AddToList(people);
            Person p16 = new Recruiter("Dominic Pointer", 16, Gender.Male, 40, 22, "Horseman").AddToList(people);
            Person p17 = new Recruiter("Brian Junnior", 17, Gender.Male, 26, 8, "Balistics").AddToList(people);
            Person p18 = new Student("Peter Smith", 18, Gender.Male, 18).AddToList(people);
            Person p19 = new General("Dominic Schultz", 19, Gender.Male, 45, 28, "Sniper").AddToList(people);
            Person p20 = new Admin("Maria Johnson", 20, Gender.Female, 36).AddToList(people);
            Person p21 = new Student("Peter Smith", 21, Gender.Male, 18).AddToList(people);
            Person p22 = new Recruiter("Sarah Star", 22, Gender.Female, 24, 6, "Balistics").AddToList(people);
            Person p23 = new Officer("Jack Sparrow", 23, Gender.Male, 32, 15, "Horseman").AddToList(people);
            Person p24 = new Student("Alice Morgan", 24, Gender.Female, 22).AddToList(people);
            Person p25 = new Recruiter("Dominic Pointer", 25, Gender.Male, 40, 22, "Horseman").AddToList(people);
            Person p26 = new Recruiter("Brian Junnior", 26, Gender.Male, 26, 8, "Balistics").AddToList(people);
            Person p27 = new Student("Peter Smith", 27, Gender.Male, 18).AddToList(people);
            Person p28 = new General("Dominic Schultz", 28, Gender.Male, 45, 28, "Sniper").AddToList(people);
            Person p29 = new Admin("Maria Johnson", 29, Gender.Female, 36).AddToList(people);
            Person p30 = new Student("Peter Smith", 30, Gender.Male, 18).AddToList(people);
            Person p31 = new Recruiter("Sarah Star", 31, Gender.Female, 24, 6, "Balistics").AddToList(people);
            Person p32 = new Officer("Jack Sparrow", 32, Gender.Male, 32, 15, "Horseman").AddToList(people);
            Person p33 = new Student("Alice Morgan", 33, Gender.Female, 22).AddToList(people);
            Person p34 = new Officer("Dominic Pointer", 34, Gender.Male, 40, 22, "Horseman").AddToList(people);
            Person p35 = new Recruiter("Brian Junnior", 35, Gender.Male, 26, 8, "Balistics").AddToList(people);
            Person p36 = new Student("Peter Smith", 36, Gender.Male, 18).AddToList(people);
            Person p37 = new General("Dominic Schultz", 37, Gender.Male, 45, 28, "Sniper").AddToList(people);
            Person p38 = new Admin("Maria Johnson", 38, Gender.Female, 36).AddToList(people);
            Person p39 = new Student("Peter Smith", 39, Gender.Male, 18).AddToList(people);
            Person p40 = new Recruiter("Sarah Star", 40, Gender.Female, 24, 6, "Balistics").AddToList(people);
            Person p41 = new Officer("Jack Sparrow", 41, Gender.Male, 32, 15, "Horseman").AddToList(people);
            Person p42 = new Student("Alice Morgan", 42, Gender.Female, 22).AddToList(people);
            Person p43 = new Recruiter("Dominic Pointer", 43, Gender.Male, 40, 22, "Horseman").AddToList(people);
            Person p44 = new Recruiter("Brian Junnior", 44, Gender.Male, 26, 8, "Balistics").AddToList(people);
            Person p45 = new Student("Peter Smith", 45, Gender.Male, 18).AddToList(people);
            Person p46 = new General("Dominic Schultz", 46, Gender.Male, 45, 28, "Sniper").AddToList(people);
            Person p47 = new Admin("Maria Johnson", 47, Gender.Female, 36).AddToList(people);
            Person p48 = new Student("Peter Smith", 48, Gender.Male, 18).AddToList(people);
            Person p49 = new Recruiter("Sarah Star", 49, Gender.Female, 24, 6, "Balistics").AddToList(people);
            Person p50 = new Officer("Jack Sparrow", 50, Gender.Male, 32, 15, "Horseman").AddToList(people);
            Person p51 = new Student("Alice Morgan", 51, Gender.Female, 22).AddToList(people);
            Person p52 = new Officer("Dominic Pointer", 52, Gender.Male, 40, 22, "Horseman").AddToList(people);
            Person p53 = new Recruiter("Brian Junnior", 53, Gender.Male, 26, 8, "Balistics").AddToList(people);
            Person p54 = new Student("Peter Smith", 54, Gender.Male, 18).AddToList(people);

            return people;
        }

        
        public void CreateGeneralIntoList(string name, int id, Gender gender, int age, int experiance, string specialty)
        {
            People.Person general = new General(name, id, gender, age, experiance, specialty);

        }

        List<People.Person> availableSoldiers = new List<People.Person>();
        List<People.Person> newsoldiers = new List<People.Person>();

        public List<int> ExtractIdsFromPeople(List<Person> people)
        {
            List<int> Ids = new List<int>();
            foreach (var person1 in people)
            {
                Ids.Add(person1.Id);
            }

            return Ids;
        }
        
        public void SetAvailablePeopleForSrervice()
        {
            foreach (var person in people)
            {
                if (person.Age < minimalAge && person.Age > maximumAge) continue;
                if (person.Gender != Gender.Male) continue;
                var availableSoldier = person;
                availableSoldiers.Add(availableSoldier);
            }
        }

        public void CallToService()
        {
            Random rnd = new Random();

            for (int i = 1; i <= neededSoldiersCount && i <= availableSoldiers.Count; i++)
            {
                var newsold = rnd.Next(0, availableSoldiers.Count);
                newsoldiers.Add(availableSoldiers[newsold]);
                availableSoldiers.RemoveAt(newsold);
            }
        }

        public void CheckForService()
        {
            List<int> ids = ExtractIdsFromPeople(newsoldiers);
            int insertedId = 0;
            do
            {
                Console.WriteLine("Insert person's Id number:");
                bool isSuccessfullyParsed = Int32.TryParse(Console.ReadLine(), out insertedId);

                if (!isSuccessfullyParsed)
                {
                    Console.WriteLine("You have inserted not a number. Program terminates.");
                    break;
                }
                var isIdInArmyList =  ids.Contains(insertedId);
                
                if (isIdInArmyList)
                    Console.WriteLine("You are in the new soldiers' list.");
                else
                    Console.WriteLine("You are not in the new soldiers' list.");
            } while (insertedId >= 1 || insertedId >= Int32.MaxValue);
            
            Console.ReadKey();
        }
    }
}
