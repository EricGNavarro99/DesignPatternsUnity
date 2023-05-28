using UnityEngine;

namespace Unity.Decorator
{
    public class WoodAttackerDecorator : AttackerDecorator
    {
        private readonly int woodDamage;

        public WoodAttackerDecorator(IAttacker attacker, int woodDamage) : base (attacker)
            => this.woodDamage = woodDamage;

        public override void Attack(IDamageReceiver damageReceiver)
        {
            base.Attack(damageReceiver);
            damageReceiver.ReceiveDamage(woodDamage, Color.green);
        }
    }
}
