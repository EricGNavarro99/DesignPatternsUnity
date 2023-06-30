using UnityEngine;

namespace Unity.Strategy
{
    public class Installer : MonoBehaviour
    {
        [SerializeField] private Hero heroPrefab;
        [SerializeField] private Sword swordPrefab;
        [SerializeField] private Bow bowPrefab;

        [SerializeField] private bool useSword;

        private void Awake()
        {
            var hero = Instantiate(this.heroPrefab);
            var sword = GetWeapon(hero.transform);

            hero.SetWeapon(sword);
        }

        private Weapon GetWeapon(Transform parent)
        {
            if (this.useSword) 
                return Instantiate(this.swordPrefab, parent);

            return Instantiate(this.bowPrefab, parent);
        }
    }
}
