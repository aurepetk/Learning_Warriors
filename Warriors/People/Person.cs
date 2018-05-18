using System;
using System.Collections.Generic;
using Warriors;

namespace People
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Gender Gender{ get; set; }
        public int Age { get; set; }

        public Person()
        {
            
        }

        public Person(string name, int id, Gender gender, int age)
        {
            Name = name;
            Id = id;
            Gender = gender;
            Age = age;
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
