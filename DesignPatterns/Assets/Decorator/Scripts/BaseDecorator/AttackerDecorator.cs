namespace Unity.Decorator
{
    public abstract class AttackerDecorator : IAttacker
    {
        private readonly IAttacker attacker;

        public AttackerDecorator(IAttacker attacker) => this.attacker = attacker;

        public virtual void Attack(IDamageReceiver damageReceiver) => this.attacker.Attack(damageReceiver);
    }
}
