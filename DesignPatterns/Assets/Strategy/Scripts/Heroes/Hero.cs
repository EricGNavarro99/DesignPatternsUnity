using UnityEngine;

namespace Unity.Strategy
{
    public class Hero : MonoBehaviour, Damageable
    {
        private Weapon weapon;

        private void Update()
        {
            // Do not do this in real project
            if (Input.GetKeyDown(KeyCode.Space)) this.weapon.Attack();
        }

        public void DoDamage(int damage) => print("Damage recieved!"); 

        public void SetWeapon(Weapon weapon) => this.weapon = weapon;
    }
}
