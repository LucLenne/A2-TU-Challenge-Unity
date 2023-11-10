using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _zoo.Add(c);
        }

        public bool Contains(Animal a)
        {
            for(int i = 0; i < _zoo.Count ; i++)
            {
                if (_zoo[i] == a)
                {
                    return true;
                }
            }
            return false;
        }

        public Animal GetAnimal(int index)
        {
            return _zoo[index];
        }

        public void FeedAll()
        {
            throw new NotImplementedException();
        }
    }
}
