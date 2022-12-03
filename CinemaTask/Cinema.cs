using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTask
{
    internal class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Hall[] halls = { };

        public Cinema(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddHall(Hall hall)
        {
            Array.Resize(ref halls, halls.Length + 1);
            halls[halls.Length - 1] = hall;
        }

        public void RemoveHall(Hall hall)
        {
            Hall[] newHalls = { };
            foreach (Hall h in halls)
            {
                if (!h.Equals(hall))
                {
                    Array.Resize(ref newHalls,newHalls.Length+1);
                    newHalls[newHalls.Length - 1] = hall;
                }
            }
            halls = newHalls;
        }

        public void GetHalls()
        {
            foreach (Hall hall in halls)
            {
                Console.WriteLine(hall.Name);
            }
        }
    }
}
