using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warriors;
using People;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        AdminCenter adminCenter = new AdminCenter();
        
        Person person = new Person();

        List<Person> availableSoldiers = new List<Person>();
        List<Person> newsoldiers = new List<Person>();

        [TestMethod]
        public void TestAvailableSoldiers()
        {
            foreach (Person person in adminCenter.CreatePeople())
            {
                if (person.Age < AdminCenter.minimalAge || person.Age > AdminCenter.maximumAge) continue;
                if (person.Gender != Gender.Male) continue;
                Person availableSoldier = person;
                availableSoldiers.Add(availableSoldier);
            }
            Assert.AreEqual(18, availableSoldiers.Count);
        }

        [TestMethod]
        public void TestCallToService()
        {
            TestAvailableSoldiers();

            Random rnd = new Random();

            for (int i = 1; i <= AdminCenter.neededSoldiersCount; i++)
            {
                var newsold = rnd.Next(0, availableSoldiers.Count);
                newsoldiers.Add(availableSoldiers[newsold]);
                availableSoldiers.RemoveAt(newsold);
            }
            Assert.AreEqual(15, newsoldiers.Count);
        }

        [TestMethod]
        public void CheckForService()
        {
            int insertedId = 3;
            string notinlist = "You are not in the new soldiers' list.";
            string inlist = "You are in the new soldiers' list.";
            string output = "";
            int index = 0;
            do
            {
                index++;
            } while (insertedId == person.Id);

            if (index != 1)
                output = notinlist;
            else
                output = inlist;
            Assert.AreEqual("You are in the new soldiers' list.", output);
        }
    }
}
