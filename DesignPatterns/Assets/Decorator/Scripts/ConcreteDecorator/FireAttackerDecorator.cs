using UnityEngine;

namespace Unity.Decorator
{
    public class FireAttackerDecorator : AttackerDecorator
    {
        private readonly int fireDamage;

        public FireAttackerDecorator(IAttacker attacker, int fireDamage) : base(attacker)
            => this.fireDamage = fireDamage;

        public override void Attack(IDamageReceiver damageReceiver)
        {
            base.Attack(damageReceiver);
            damageReceiver.ReceiveDamage(this.fireDamage, Color.red);
        }
    }
}
