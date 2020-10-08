using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
   public  class Family
    {
        private HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }
        public void AddMember(Person member)
        {
            this.members.Add(member);
        }
       public Person GetOldestMember()
        {
            Person oldestPerson = this.members.OrderByDescending(p => p.Age).First();
            return oldestPerson;
        }
        public HashSet<Person> ReturnOver30()
        {
            return   this.members.Where(x => x.Age > 30).OrderBy(x => x.Name).ToHashSet();
        }
    }
}
