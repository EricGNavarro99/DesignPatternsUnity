using UnityEngine;

namespace Unity.Builder
{
    public class Hero : MonoBehaviour
    {
        private Weapon weapon;
        private Magic magic;

        public void SetComponents(Weapon weapon, Magic magic)
        {
            this.weapon = weapon;
            this.magic = magic;
        }
    }
}
