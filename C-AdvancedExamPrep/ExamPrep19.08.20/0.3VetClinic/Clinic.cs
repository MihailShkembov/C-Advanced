using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> list;
        public int Capacity { get; set; }
        public int Count { get { return this.list.Count; } }
        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.list = new List<Pet>();
        }
        public void Add(Pet pet)
        {
            if (this.list.Count < this.Capacity)
            {
                this.list.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            foreach (var pet in this.list)
            {
                if (pet.Name == name)
                {
                    this.list.Remove(pet);
                    return true;
                }
            }
            return false;
        }
        public Pet GetPet(string name, string owner)
        {
            foreach (var pet in this.list)
            {
                if (pet.Name==name&&pet.Owner==owner)
                {
                    return pet;
                }
            }
            return null;
        }
        public Pet GetOldestPet()
        {  var oldestAge = this.list.Max(x => x.Age);
            var oldestPet = this.list.Find(x => x.Age == oldestAge);
            return oldestPet;
          
        }
        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The clinic has the following patients:");
            foreach (var pet in list)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString().Trim();

        }
    }
}
