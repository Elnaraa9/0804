using _08_04_2002.Models;
using System;
using System.Collections.Generic;

namespace _08_04_2002
{
    class Program
    {
        private static bool result;

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person person = new Person("A",21);
            Person person1 = new Person("B", 27);
            Person person2 = new Person("C", 23);
            Person person3 = new Person("D", 20);
            Person person4 = new Person("E", 22);
            Person person5 = new Person("F", 25);
            Person person6 = new Person("R", 29);
            Person person7 = new Person("Rail", 29);
            people.Add(person);
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);
            people.Add(person7);
            //people.Find(person => person.Age == 21);
            //people.FindAll(person => person.Age == 21);
            //Console.WriteLine(people.FindAll(person => person.Age == 21));
            people.Sort((x, y) => x.Age-y.Age);
            people.Exists(person => person.Name == "Rail");
            
            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }
           var result= people.FindLast(person => person.Age == 29).Name;
            Console.WriteLine(result);

            Console.WriteLine(people.Exists(person => person.Name == "Rail"));
        }

    }
}
