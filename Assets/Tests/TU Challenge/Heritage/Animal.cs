using System;

namespace TU_Challenge.Heritage
{

    public class Animal
    {

        public event Action OnDie;

        public bool IsAlive { get; set; }
        public int Pattes { get; set; }
        public bool Feed { get; set; }

        public bool FeedFish { get; set; }
        public string Name { get; set; }

        public virtual string Crier()
        {
            throw new NotImplementedException();
        }
        public void Die()
        {
            IsAlive = false;
            OnDie.Invoke();
        }
    }
}
