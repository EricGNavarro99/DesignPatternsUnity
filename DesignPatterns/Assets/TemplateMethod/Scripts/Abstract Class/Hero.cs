using System;
using UnityEngine;

namespace Unity.TemplateMethod
{
    public abstract class Hero : MonoBehaviour
    {
        protected int currentHealth = 100;
        public event Action OnDamageRecieved;

        public void Attack() 
        {
            if (CanAttack()) 
                DoAttack();
        }

        protected abstract bool CanAttack();
        protected abstract void DoAttack();

        public void RecievedDamage(int damage)
        {
            var isDead = ApplyDamage(damage);
            DamagedRecieved(isDead);
            NotifyDamageRecieved();
        }

        private bool ApplyDamage(int damage)
        {
            currentHealth -= damage;

            if (currentHealth > 0) return false;

            currentHealth = 0;

            return true;
        }

        protected abstract void DamagedRecieved(bool isDead);

        private void NotifyDamageRecieved() => OnDamageRecieved?.Invoke();
    }
}
