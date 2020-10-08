using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            l
            Family familly = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split().ToArray();
                int age = int.Parse(personInfo[1]);
                string name = personInfo[0];
                Person person = new Person(name, age);
                familly.AddMember(person);
            }
            HashSet<Person> result = familly.ReturnOver30();
            Console.WriteLine(string.Join(Environment.NewLine,result));
        }
    }
}
