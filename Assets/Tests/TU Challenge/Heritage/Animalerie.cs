using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TU_Challenge.Heritage
{
    public class Animalerie
    {
        static Animalerie _instance;
        public static Animalerie Instance => _instance;

        List<Animal> _zoo;

        public List<Animal> Zoo { get => _zoo; }

        public event Action<Animal> OnAddAnimal;

        public Animalerie()
        {
            _zoo = new List<Animal>();
        }   

        public void AddAnimal(Animal c)
        {
            for(int i = 0; i < _zoo.Count; i++) 
            {
                if (Zoo[i] == new Poisson("Bubulle"))
                {
                    Zoo[i].Die();
                }
            }
            c.FeedFish = true;
            Zoo.Add(c);
            OnAddAnimal?.Invoke(c);
        }

        public bool Contains(Animal a)
        {
            for(int i = 0; i < Zoo.Count ; i++)
            {
                if (GetAnimal(i) == a)
                {
                    return true;
                }
            }
            return false;
        }

        public Animal GetAnimal(int index)
        {
            return Zoo[index];
        }

        public void FeedAll()
        {
            for (int i = 0; i < Zoo.Count; i++)
            {
                Zoo[i].Feed = true;
            }
        }
    }
}
