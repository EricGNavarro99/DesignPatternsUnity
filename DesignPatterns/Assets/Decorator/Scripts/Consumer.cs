using UnityEngine;

namespace Unity.Decorator
{
    public class Consumer : MonoBehaviour
    {
        [SerializeField] private DamageReceiver damageReceiver;

        private RegularAttacker regularAttacker;
        private FireAttackerDecorator fireAttacker;
        private WoodAttackerDecorator woodAttacker;

        private void Awake()
        {
            const int damage = 100;
            const int fireDamage = 10;
            const int woodDamage = 20;

            this.regularAttacker = new RegularAttacker(damage);
            this.fireAttacker = new FireAttackerDecorator(this.regularAttacker, fireDamage);
            this.woodAttacker = new WoodAttackerDecorator(this.regularAttacker, woodDamage);
        }

        public void RegularAttack() => this.regularAttacker.Attack(this.damageReceiver);

        public void FireAttack() => this.fireAttacker.Attack(this.damageReceiver);

        public void WoodAttack() => this.woodAttacker.Attack(this.damageReceiver);
    }
}
