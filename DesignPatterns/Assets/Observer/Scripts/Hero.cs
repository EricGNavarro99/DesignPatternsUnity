using System;

namespace Unity.Observer
{
    public class Hero : IHero
    {
        public int Health { get; set; }
        public event Action<int> OnHealthUpdated;

        public Hero()
        {
            this.Health = 100;
            Notify();
        }

        public void Notify() => OnHealthUpdated?.Invoke(this.Health);

        public void ApplyDamage(int damage)
        {
            this.Health -= damage;
            Notify();
        }
    }
}
