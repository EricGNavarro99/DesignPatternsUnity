using UnityEngine;

namespace Unity.Decorator
{
    public class RegularAttacker : IAttacker
    {
        private readonly int damage;

        public RegularAttacker(int damage) => this.damage = damage;

        public void Attack(IDamageReceiver damageReceiver) 
            => damageReceiver.ReceiveDamage(this.damage, Color.white);
    }
}
